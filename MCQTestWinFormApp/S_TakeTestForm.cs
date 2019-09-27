using System;
using System.Windows.Forms;
using Consumables;
using Logger;

namespace MCQTestWinFormApp
{
    public partial class S_TakeTestForm : Form
    {
        private UserSession currentUser;
        private Test test;
        private int questionIndex = 0;
        public S_TakeTestForm(UserSession currentUser, Test test)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            tsiAccount.Text = currentUser.Username;
            this.test = test;

            //load test data to UI
            lblTestName.Text = test.TestName;
            lblQuestionNumTotal.Text = test.Questions.Count.ToString();

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

        private void TsiLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void TsiHome_Click(object sender, EventArgs e)
        {
            new S_StudentHome(currentUser).Show();
            this.Hide();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool submit = true;

            //save current question answer
            test.Questions[questionIndex].StudentAnswer = rbnAnswerA.Checked ? 'a' :
               rbnAnswerB.Checked ? 'b' : rbnAnswerC.Checked ? 'c' : default(char);

            foreach (Question question in test.Questions)
            {
                if (question.StudentAnswer == default(char))
                {
                    DialogResult res = MessageBox.Show(
                        "You have not completed all the answers \nAre you sure you want to submit?",
                        "Incomplete Test",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);
                    if (res == DialogResult.No || res == DialogResult.Cancel)
                    {
                        submit = false;
                        break;
                    }
                }
            }

            if (submit)
            {
                try
                {
                    int mark = 0, percentage;
                    foreach (Question question in test.Questions)
                    {
                        if (question.CorrectAnswer == question.StudentAnswer)
                            mark++;
                    }

                    percentage = (int) ( (double)mark / (double)test.Questions.Count * 100.0);
                    test.Mark = mark;
                    test.Percentage = percentage;
                    test.AttemptsMade++;

                    bool subit = new DBControl().SubmitTest(currentUser, test);

                    if (subit) MessageBox.Show("Test saved successfully", "Success");

                    new S_ViewMemoForm(currentUser, test).Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    StackLog.GetInstance().Log(ex.Message + "\n" + ex.StackTrace);
                    MessageBox.Show("Failed to submit test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void BtnNextQ_Click(object sender, EventArgs e)
        {
            test.Questions[questionIndex].StudentAnswer = rbnAnswerA.Checked ? 'a' :
                rbnAnswerB.Checked ? 'b' : rbnAnswerC.Checked ? 'c' : default(char);

            if (1 + questionIndex < test.Questions.Count)
            {
                questionIndex++;
                Refresh();
            }
        }

        private void BtnPreviousQ_Click(object sender, EventArgs e)
        {
            test.Questions[questionIndex].StudentAnswer = rbnAnswerA.Checked ? 'a' :
                rbnAnswerB.Checked ? 'b' : rbnAnswerC.Checked ? 'c' : default(char);

            if (questionIndex > 0)
            {
                questionIndex--;
                Refresh();
            }
        }

        public override void Refresh()
        {
            base.Refresh();

            //update UI
            lblQuestionNumber.Text = (1 + questionIndex).ToString();
            tbxQuestion.Text = test.Questions[questionIndex].QuestionText;
            tbxAnswerA.Text = test.Questions[questionIndex].Answers['a'];
            tbxAnswerB.Text = test.Questions[questionIndex].Answers['b'];
            tbxAnswerC.Text = test.Questions[questionIndex].Answers['c'];

            rbnAnswerA.Checked = false; 
            rbnAnswerB.Checked = false; 
            rbnAnswerC.Checked = false;

            char selectedAnswer = test.Questions[questionIndex].StudentAnswer;
            if (selectedAnswer != default(char))
            {
                switch (selectedAnswer)
                {
                    case 'a': rbnAnswerA.Checked = true; break;
                    case 'b': rbnAnswerB.Checked = true; break;
                    case 'c': rbnAnswerC.Checked = true; break;
                }
            }

        }

        
    }
}
