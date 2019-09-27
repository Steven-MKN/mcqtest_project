using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;
using Logger;

namespace Consumables
{
    public class DBControl
    {
        public bool RegisterUser(UserSession currentUser, string username,
            string fname, string surname, string password, char userType)
        {
            bool isRegistered = false;

            if (currentUser.UserType == 'r')
            {
                try
                {
                    string query = String.Format("INSERT INTO users(USERNAME, FIRSTNAME, SURNAME, upassword, usertype)" +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", username, fname, surname, password, userType);
                    int result = new SQL().RunNonQuery(query);

                    if (result == 1) isRegistered = true;
                } catch (Exception ex){  throw ex;  }
            }

            return isRegistered;
        }

        public UserSession LoginUser(string username, string password)
        {
            UserSession session = null;

            try
            {
                string query = String.Format("select username, usertype from users where username='{0}' "+
                    "and upassword='{1}';", username, password);
                new SQL().RunQuery(query, (reader) =>
                {
                    if (reader.Read())
                        session = new UserSession(reader.GetString(0), reader.GetChar(1));
                });
            }
            catch (Exception ex) {  throw ex; }

            return session;
        }

        public List<Test> GetTests(UserSession currentUser)
        {
            List<Test> tests = new List<Test>();

            try
            {
                //get tests
                string query = String.Format("select testId, testName, attempts from Test;");
                new SQL().RunQuery(query, (reader) =>
                {
                    while (reader.Read())
                        tests.Add(new Test() { TestId = reader.GetInt32(0), TestName = reader.GetString(1), AttemptsAllowed = reader.GetInt32(2) });
                });


                //
                foreach (Test test in tests)
                {
                    //get test questions
                    query = String.Format("select questionNum, questionText, correctAnswer from TestQuestion where testId='{0}';",
                        test.TestId);
                    new SQL().RunQuery(query, (reader) =>
                    {
                        while (reader.Read())
                            test.Questions.Add(new Question() { QuestionNum = reader.GetInt32(0), QuestionText = reader.GetString(1),
                                CorrectAnswer = reader.GetChar(2)});
                    });

                    //get student data for particular test if exists
                    query = String.Format("select markObtained, attempts, percentageObtained from StudentTest where username='{0}' and testId={1};",
                        currentUser.Username, test.TestId);
                    new SQL().RunQuery(query, (reader) =>
                    {
                        while (reader.Read())
                        {
                            test.Mark = reader.GetInt32(0);
                            test.Percentage = reader.GetInt32(2);
                            test.AttemptsMade = reader.GetInt32(1);
                        }
                    });

                    
                    foreach (Question q in test.Questions)
                    {   
                        //get test question answers
                        query = String.Format("select answerChar, AnswerText from TestAnswer where testId='{0}' and questionNum={1};", 
                            test.TestId, q.QuestionNum);
                        new SQL().RunQuery(query, (reader) =>
                        {
                            while (reader.Read())
                            {
                                q.Answers.Add(reader.GetChar(0), reader.GetString(1));
                            }
                        });

                        //get studentAnswers as well
                        query = String.Format("select answerChar from StudentAnswer where username='{0}' and testId={1} and questionNum={2};",
                            currentUser.Username, test.TestId, q.QuestionNum);
                        new SQL().RunQuery(query, (reader) =>
                        {
                            while (reader.Read())
                                q.StudentAnswer = reader.GetChar(0);
                        });
                    }
                }

            } catch (Exception ex) {  throw ex; }

            return tests;
        }
        

        public bool SubmitTest(UserSession currentUser, Test test)
        {
            bool isSubmitted = false;

            try
            {
                //delete previous test data if exists
                string query = String.Format("delete from StudentTest where username='{0}' and testId={1};",
                    currentUser.Username, test.TestId);
                new SQL().RunNonQuery(query);

                query = String.Format("delete from StudentAnswer where username='{0}' and testId={1};",
                    currentUser.Username, test.TestId);
                new SQL().RunNonQuery(query);

                //insert new test data
                query = String.Format("insert into StudentTest(username, testId, markObtained, attempts, percentageObtained) values"+
                    "('{0}', {1}, {2}, {3}, {4});",currentUser.Username, test.TestId, test.Mark, test.AttemptsMade, test.Percentage);
                int result1 = new SQL().RunNonQuery(query);

                string results = "";

                foreach (Question question in test.Questions)
                {
                    query = String.Format("insert into StudentAnswer(username, testId, questionNum, answerChar)" +
                        "values ('{0}', {1}, {2}, '{3}');", currentUser.Username, test.TestId, question.QuestionNum, question.StudentAnswer);
                    int result2 = new SQL().RunNonQuery(query);
                    results += result2.ToString();
                }

                if (result1 == 1 && !results.Contains("0")) isSubmitted = true;
                

            } catch (Exception ex) {  throw ex; }

            return isSubmitted;
        }

        public bool SaveNewTest(UserSession currentUser, Test test)
        {
            bool isSaved = false;

            try
            {
                if (currentUser.UserType == 'l')
                {
                    string results = "";

                    //write to the test table
                    string query = String.Format("insert into Test (testName, attempts) values('{0}', {1}); SELECT LAST_INSERT_ID();",
                        test.TestName, test.AttemptsAllowed);
                    int lastInsertId = 0, result;
                    new SQL().RunQuery(query, (reader) => { if (reader.Read()) lastInsertId = reader.GetInt32(0); });

                    if (lastInsertId != 0)
                    {   
                        //write to the TestQuestion table
                        foreach (Question question in test.Questions)
                        {
                            query = String.Format("insert into TestQuestion(testId, questionNum, questionText, correctAnswer)" +
                                "values ({0}, {1}, '{2}', '{3}');", lastInsertId, question.QuestionNum, question.QuestionText, question.CorrectAnswer);
                            result = new SQL().RunNonQuery(query);
                            results += result.ToString();

                            //write each posible answer to the question to the TestAnswer table
                            foreach (var answer in question.Answers)
                            {
                                query = String.Format("insert into TestAnswer(testId, questionNum, answerChar, answerText)" +
                                    "values ({0}, {1}, '{2}', '{3}');", lastInsertId, question.QuestionNum, answer.Key, answer.Value);
                                result = new SQL().RunNonQuery(query);
                                results += result.ToString();
                            }
                        }

                        //check if all the data was successfully stored
                        if (!results.Contains("0")) isSaved = true;
                    }

                    
                }
            } catch (Exception ex) {  throw ex; }

            return isSaved;
        }

        public List<Student> GetStudentView(UserSession currentUser)
        {
            List<Student> students = new List<Student>();
            if (currentUser.UserType != 'l') return students;
            try
            {
                string query = "select username, firstname, surname from users where usertype='s';";
                new SQL().RunQuery(query, (reader) =>
                {
                    while (reader.Read())
                        students.Add(new Student(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2)));
                });

                foreach (Student stud in students)
                {
                    query = String.Format("select testId, markObtained, attempts, percentageObtained from StudentTest where username='{0}';", stud.Username);
                    new SQL().RunQuery(query, (reader) =>
                    {
                        while (reader.Read())
                            stud.Tests.Add(new Test()
                            {
                                TestId = reader.GetInt32(0),
                                Mark = reader.GetInt32(1),
                                AttemptsMade = reader.GetInt32(2),
                                Percentage = reader.GetInt32(3)
                            });
                    });
                }
            } catch (Exception ex) {  throw ex; }

            return students;
        }

        /// <summary>
        /// Returns the average mark of the test, else -1 if no average exists
        /// </summary>
        /// <param name="testId"></param>
        /// <returns>int</returns>
        public int GetTestAverage(int testId)
        {
            int average = -1;
            try
            {
                List<int> testMarks = new List<int>();
                string query = String.Format("select percentageObtained from StudentTest where testId = {0};", testId);
                new SQL().RunQuery(query, (reader) =>
                {
                    while (reader.Read())
                    {
                        int? num = reader.GetInt32(0);
                        if (num != null)
                            testMarks.Add(Convert.ToInt32(num));
                    }
                });

                if (testMarks.Count > 0)
                {
                    average = 0;
                    int count = 0;
                    foreach (int mark in testMarks)
                    {
                        count++;
                        average += mark;
                    }

                    average /= count;
                }

            } catch (Exception ex) { throw ex; }

            return average;
        }

        private class SQL
        {
            private string ConnectionString = "datasource=localhost;port=3306;username=root;password=;database=MCQTestDB";
            private MySqlConnection Connector;
            private MySqlCommand Command;
            private MySqlDataReader Reader;
            private int Result;

            //delegate used to return the reader object to be used by the caller before connection is closed
            public delegate void ReaderHandler(MySqlDataReader reader);
            private ReaderHandler listOfHandlers;

            public int RunNonQuery(string query)
            {
                try
                {
                    Connector = new MySqlConnection(ConnectionString);
                    Connector.Open();

                    Command = new MySqlCommand(query, Connector);
                    Result = Command.ExecuteNonQuery();
                    Connector.Close();

                }
                catch (Exception ex) { throw ex; }

                return Result;
            }

            public void RunQuery(string query, ReaderHandler callback)
            {
                listOfHandlers += callback;
                try
                {
                    Connector = new MySqlConnection(ConnectionString);
                    Connector.Open();

                    Command = new MySqlCommand(query, Connector);
                    Reader = Command.ExecuteReader();

                    listOfHandlers(Reader);//the caller can use reader object before connection is closed

                    Connector.Close();

                }
                catch (Exception ex) { throw ex; }

            }
        }
    }
}
