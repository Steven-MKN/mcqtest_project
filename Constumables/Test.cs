using System.Collections.Generic;

namespace Consumables
{
    public class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int Mark { get; set; }
        public int Percentage { get; set; }
        public int AttemptsMade { get; set; }
        public int AttemptsAllowed { get; set; }
        public List<Question> Questions;

        public Test() { Questions = new List<Question>(); }

    }

    public class Question
    {
        public int QuestionNum { get; set; }
        public string QuestionText { get; set; }
        public char CorrectAnswer { get; set; }
        public char StudentAnswer { get; set; }

        public Dictionary<char, string> Answers;
        public Question() { Answers = new Dictionary<char, string>(); }

    }
}
