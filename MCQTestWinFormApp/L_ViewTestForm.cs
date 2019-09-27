using System;
using System.Drawing;
using System.Windows.Forms;
using Consumables;
using Logger;
using System.Collections.Generic;

namespace MCQTestWinFormApp
{
    public partial class L_ViewTestForm : Form
    {
        UserSession currentUser;
        List<Test> tests;

        public L_ViewTestForm(UserSession currentUser)
        {
            InitializeComponent();
            tsiTests.BackColor = Color.DarkRed;
            this.currentUser = currentUser;
            tsiAccount.Text = currentUser.Username;

            //registers the Refresh() method to the event handler
            cbxTests.SelectedIndexChanged += (object obj, EventArgs e) => { Refresh(); };

            //load tests from database
            try
            {
                tests = new DBControl().GetTests(currentUser);
                foreach (Test test in tests)
                {
                    cbxTests.Items.Add(test.TestName);
                }

                cbxTests.SelectedIndex = 0;//set as default selected

            } catch (Exception ex)
            {
                StackLog.GetInstance().Log(ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Failed to load tests", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TsiNewTest_Click(object sender, EventArgs e)
        {
            new L_NewTestForm(currentUser).Show();
            this.Hide();
        }

        private void TsiLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void TsiClassList_Click(object sender, EventArgs e)
        {
            new L_ClassListForm(currentUser).Show();
            this.Hide();
        }

        public override void Refresh()
        {
            base.Refresh();

            //loads selected test
            dgvTestQAndA.Rows.Clear();
            int selectedTest = cbxTests.SelectedIndex;

            foreach (Question question in tests[selectedTest].Questions)
            {
                int i = dgvTestQAndA.Rows.Add();
                dgvTestQAndA.Rows[i].Cells[0].Value = question.QuestionNum + ". " + question.QuestionText;
                char correctAnswer = question.CorrectAnswer;

                i = dgvTestQAndA.Rows.Add();
                dgvTestQAndA.Rows[i].Cells[0].Value = question.Answers['a'];
                if (correctAnswer == 'a') dgvTestQAndA.Rows[i].Cells[0].Style.BackColor = Color.DarkSeaGreen;

                i = dgvTestQAndA.Rows.Add();
                dgvTestQAndA.Rows[i].Cells[0].Value = question.Answers['b'];
                if (correctAnswer == 'b') dgvTestQAndA.Rows[i].Cells[0].Style.BackColor = Color.DarkSeaGreen;

                i = dgvTestQAndA.Rows.Add();
                dgvTestQAndA.Rows[i].Cells[0].Value = question.Answers['c'];
                if (correctAnswer == 'c') dgvTestQAndA.Rows[i].Cells[0].Style.BackColor = Color.DarkSeaGreen;

                dgvTestQAndA.Rows.Add();
            }

            try
            {
                int average = new DBControl().GetTestAverage(tests[cbxTests.SelectedIndex].TestId);

                if (average == -1)
                    lblAveragePercent.Text = "--";
                else
                    lblAveragePercent.Text = average.ToString();

            } catch (Exception ex) { StackLog.GetInstance().Log(ex.Message + "\n" + ex.StackTrace); }
        }
    }
}
