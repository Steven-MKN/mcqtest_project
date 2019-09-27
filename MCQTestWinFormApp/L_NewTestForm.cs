using System;
using System.Drawing;
using System.Windows.Forms;
using Consumables;
using Logger;

namespace MCQTestWinFormApp
{
    public partial class L_NewTestForm : Form
    {
        UserSession currentUser;
        Test test;
        int dispQuestionIndex;

        public L_NewTestForm(UserSession currentUser)
        {
            InitializeComponent();

            //initialize data
            tsiTests.BackColor = Color.DarkRed;
            this.currentUser = currentUser;
            tsiAccount.Text = currentUser.Username;
            dispQuestionIndex = 0;
            cbxAllowedAttempts.Items.AddRange(new string[] { "1", "2", "3", '\u221E'.ToString()});
            cbxAllowedAttempts.SelectedIndex = 3;
            cbxCorrectAnswer.Items.AddRange(new string[] { "a", "b", "c"});
            test = new Test();
            test.Questions.Add(new Question());

            Refresh();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TsiViewTests_Click(object sender, EventArgs e)
        {
            new L_ViewTestForm(currentUser).Show();
            this.Hide();
        }

        private void TsiClassList_Click(object sender, EventArgs e)
        {
            new L_ClassListForm(currentUser).Show();
            this.Hide();
        }

        private void TsiLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void BtnCreateText_Click(object sender, EventArgs e)
        {
            bool isValidTest = ValidateTest();
            bool isValidQuestion = ValidateTestQuestion();
            bool isConcent = false;

            if (!isValidTest)
            {
                MessageBox.Show("Cannot save test without a name", 
                    "Missing name", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                isConcent = ConsentUser(isValidQuestion);

                if (isValidQuestion && isConcent)
                {
                    //save question
                    int QIndex = dispQuestionIndex;
                    test.Questions[QIndex].QuestionNum = QIndex + 1;
                    test.Questions[QIndex].QuestionText = tbxQuestion.Text;
                    test.Questions[QIndex].CorrectAnswer = Convert.ToChar(cbxCorrectAnswer.SelectedItem.ToString());
                    test.Questions[QIndex].Answers['a'] = tbxAnswerA.Text;
                    test.Questions[QIndex].Answers['b'] = tbxAnswerB.Text;
                    test.Questions[QIndex].Answers['c'] = tbxAnswerC.Text;
                }
                else test.Questions.RemoveAt(dispQuestionIndex);

                try
                {
                    test.TestName = tbxTestName.Text;
                    test.AttemptsAllowed = cbxAllowedAttempts.SelectedIndex == 3 ? -1 : cbxAllowedAttempts.SelectedIndex + 1;

                    new DBControl().SaveNewTest(currentUser, test);
                    MessageBox.Show("Test saved!", "Success");

                    new L_ViewTestForm(currentUser).Show();
                    this.Hide();
                }
                catch (Exception ex) { StackLog.GetInstance().Log(ex.StackTrace); MessageBox.Show(ex.Message); }
            }

        }

       

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            Refresh();

            bool isValid = ValidateTestQuestion();
            bool isConcent = ConsentUser(isValid);
            int QIndex = dispQuestionIndex;
            bool _continue = false;

            if (isValid && isConcent)
            {
                //save current question
                test.Questions[QIndex].QuestionNum = QIndex + 1;
                test.Questions[QIndex].QuestionText = tbxQuestion.Text;
                test.Questions[QIndex].CorrectAnswer = Convert.ToChar(cbxCorrectAnswer.SelectedItem.ToString());
                test.Questions[QIndex].Answers['a'] = tbxAnswerA.Text;
                test.Questions[QIndex].Answers['b'] = tbxAnswerB.Text;
                test.Questions[QIndex].Answers['c'] = tbxAnswerC.Text;
                _continue = true; //both isValid and isConcent needs to be true to allow next question
            }

            if (_continue)
            {
                dispQuestionIndex++;

                bool isLastQuestion = dispQuestionIndex >= test.Questions.Count ? true : false;
                if (isLastQuestion) test.Questions.Add(new Question());

                LoadQuestion(isLastQuestion);
            }

        }

        private void BtnPreviousQuestion_Click(object sender, EventArgs e)
        {
            Refresh();

            bool isValid = ValidateTestQuestion();
            bool isConcent = ConsentUser(isValid);
            int QIndex = dispQuestionIndex;
            bool _continue = false;

            if (isValid && isConcent)
            {
                //save current question
                test.Questions[QIndex].QuestionNum = QIndex + 1;
                test.Questions[QIndex].QuestionText = tbxQuestion.Text;
                test.Questions[QIndex].CorrectAnswer = Convert.ToChar(cbxCorrectAnswer.SelectedItem.ToString());
                test.Questions[QIndex].Answers['a'] = tbxAnswerA.Text;
                test.Questions[QIndex].Answers['b'] = tbxAnswerB.Text;
                test.Questions[QIndex].Answers['c'] = tbxAnswerC.Text;
                _continue = true;
            }

            if (!isValid && isConcent)
            {
                _continue = true;
                test.Questions.RemoveAt(test.Questions.Count - 1);
            }

            bool isFirstQuestion = dispQuestionIndex == 0 ? true : false;
            if (isFirstQuestion) _continue = false;

            if (_continue)
            {
                dispQuestionIndex--;
                LoadQuestion(false);
            }
        }

        private void LoadQuestion(bool isNew)
        {
            Refresh();

            if (isNew)
            {
                tbxQuestion.Text = String.Empty;
                tbxAnswerA.Text = String.Empty;
                tbxAnswerB.Text = String.Empty;
                tbxAnswerC.Text = String.Empty;
                cbxCorrectAnswer.SelectedIndex = -1;
            }
            else
            {
                tbxQuestion.Text = test.Questions[dispQuestionIndex].QuestionText;
                tbxAnswerA.Text = test.Questions[dispQuestionIndex].Answers['a'];
                tbxAnswerB.Text = test.Questions[dispQuestionIndex].Answers['b'];
                tbxAnswerC.Text = test.Questions[dispQuestionIndex].Answers['c'];
                cbxCorrectAnswer.SelectedIndex = test.Questions[dispQuestionIndex].CorrectAnswer == 'a' ? 0 :
                    test.Questions[dispQuestionIndex].CorrectAnswer == 'b' ? 1 : 2;
            }
        }

        private bool ConsentUser(bool valid)
        {
            bool consent = false;

            if (!valid)
            {
                DialogResult res = MessageBox.Show("Some fields are missing, the question will not be saved\n\nDo you want to continue?",
                   "Incomplete Test Question",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                    consent = true;
            }
            else consent = true;

            return consent;
        }

        private bool ValidateTest()
        {
            bool isValid = false, isName = false;

            if (tbxTestName.Text == String.Empty)
                lblErrMshTestName.Visible = true;
            else isName = true;

            if (isName) isValid = true;

            return isValid;
        }

        private bool ValidateTestQuestion()
        {
            bool isQuestion = false, isAnswerA = false, isAnswerB = false, isAnswerC = false, 
                isCorrectAnswer = false, isValid = false;

            if (tbxQuestion.Text == String.Empty)
                lblErrMsgQuestion.Visible = true;
            else isQuestion = true;

            if (tbxAnswerA.Text == String.Empty)
                lblErrMsgAnswerA.Visible = true;
            else isAnswerA = true;

            if (tbxAnswerB.Text == String.Empty)
                lblErrMsgAnswerB.Visible = true;
            else isAnswerB = true;

            if (tbxAnswerC.Text == String.Empty)
                lblErrMsgAnswerC.Visible = true;
            else isAnswerC = true;

            if (cbxCorrectAnswer.SelectedIndex == -1)
                lblErrMsgCorrectAnswer.Visible = true;
            else isCorrectAnswer = true;

            if (isQuestion && isAnswerA && isAnswerB && isAnswerC && isCorrectAnswer)
                isValid = true;

            return isValid;
        }


        public override void Refresh()
        {
            base.Refresh();
            lblErrMsgAnswerA.Visible = false;
            lblErrMsgAnswerB.Visible = false;
            lblErrMsgAnswerC.Visible = false;
            lblErrMsgCorrectAnswer.Visible = false;
            lblErrMsgQuestion.Visible = false;
            lblErrMshTestName.Visible = false;

            int total = test.Questions.Count;
            int qNum = dispQuestionIndex;

            lblQuestionTotal.Text = total == 0 ? "1" : qNum + 1 > total ? (total + 1).ToString() : total.ToString();  
            lblQuestionNumber.Text = (qNum + 1).ToString();
        }
    }
}
