using System;
using System.Windows.Forms;
using System.Drawing;
using Consumables;

namespace MCQTestWinFormApp
{
    public partial class S_ViewMemoForm : Form
    {
        UserSession currentUser;
        Test test;
        public S_ViewMemoForm(UserSession currentUser, Test test)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            tsiAccount.Text = currentUser.Username;
            this.test = test;

            lblTestName.Text = test.TestName;
            lblMarkObtained.Text = test.Mark.ToString();
            lblMarkTotal.Text = test.Questions.Count.ToString();
            lblPercentage.Text = test.Percentage.ToString();

            int i;
            char correctAnswer, studentAnswer;
            foreach (Question question in test.Questions)
            {
                correctAnswer = question.CorrectAnswer;
                studentAnswer = question.StudentAnswer;

                dgvViewMemo.Rows.Add(question.QuestionNum + ". " +question.QuestionText);

                i = dgvViewMemo.Rows.Add();
                dgvViewMemo.Rows[i].Cells[0].Value = question.Answers['a'];
                if (correctAnswer == 'a' && studentAnswer == 'a')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.DarkSeaGreen;
                else if (correctAnswer == 'a')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                else if (studentAnswer == 'a')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.IndianRed;

                i = dgvViewMemo.Rows.Add();
                dgvViewMemo.Rows[i].Cells[0].Value = question.Answers['b'];
                if (correctAnswer == 'b' && studentAnswer == 'b')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.DarkSeaGreen;
                else if (correctAnswer == 'b')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                else if (studentAnswer == 'b')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.IndianRed;

                i = dgvViewMemo.Rows.Add();
                dgvViewMemo.Rows[i].Cells[0].Value = question.Answers['c'];
                if (correctAnswer == 'c' && studentAnswer == 'c')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.DarkSeaGreen;
                else if (correctAnswer == 'c')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                else if (studentAnswer == 'c')
                    dgvViewMemo.Rows[i].Cells[0].Style.BackColor = Color.IndianRed;

                dgvViewMemo.Rows.Add();
            }
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            new S_StudentHome(currentUser).Show();
            this.Hide();
        }
    }
}
