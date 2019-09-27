using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Consumables;
using Logger;

namespace MCQTestWinFormApp
{
    public partial class S_StudentHome : Form
    {
        UserSession currentUser;
        List<Test> tests;
        int selectedTest = -1;
        public S_StudentHome(UserSession currentUser)
        {
            InitializeComponent();
            tsiHome.BackColor = Color.DarkRed;
            this.currentUser = currentUser;
            tsiAccount.Text = currentUser.Username;

            int takenCount = 0, average = 0;
            
            //load tests from database
            try
            {
                tests = new DBControl().GetTests(currentUser);
            }
            catch (Exception ex)
            {
                StackLog.GetInstance().Log(ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Test test in tests)
            {
                if (test.AttemptsMade > 0)
                {
                    takenCount++;
                    average += test.Percentage;
                }
                dataGridView1.Rows.Add(
                    test.TestName, 
                    test.AttemptsMade + " of " + (test.AttemptsAllowed == -1 ? "unlimited" : test.AttemptsAllowed.ToString()), 
                    test.AttemptsMade == 0 ? "--" : test.Mark.ToString() + " / " + test.Questions.Count.ToString(),
                    test.AttemptsMade == 0 ? "--" : test.Percentage.ToString() + "%");
            }

            //update UI with student data
            lblTestsTaken.Text = takenCount.ToString();
            lblTestTotalCount.Text = tests.Count.ToString();
            if (takenCount > 0)
            {
                average /= takenCount;
                lblAverage.Text = average.ToString();
            }
            else lblAverage.Text = "--";

            //add listner to datagrid view
            dataGridView1.SelectionChanged += (object obj, EventArgs e) => 
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    selectedTest = dataGridView1.SelectedRows[0].Index;
                else if (dataGridView1.SelectedCells.Count > 0)
                    selectedTest = dataGridView1.SelectedCells[0].RowIndex;
            };
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnTakeTest_Click(object sender, EventArgs e)
        {
            if (selectedTest >= 0)
            {
                Test toTake = tests[selectedTest];
                if (toTake.AttemptsAllowed == -1 || toTake.AttemptsMade < toTake.AttemptsAllowed)
                {// -1 means unlimited retakes

                    DialogResult res = DialogResult.Yes;

                    if (toTake.AttemptsMade > 0)
                    {
                        res = MessageBox.Show(
                            "The new test score will override the current one \nAre you sure you want to retake?",
                            "Confirm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                    }

                    if (res == DialogResult.Yes)
                    {
                        //reset the answers
                        foreach (Question question in tests[selectedTest].Questions)
                            question.StudentAnswer = default(char);

                        new S_TakeTestForm(currentUser, tests[selectedTest]).Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("You are not allowed to retake the test.", "Limit Reached", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnViewTest_Click(object sender, EventArgs e)
        {
            if (selectedTest >= 0)
            {
                Test toView = tests[selectedTest];
                if (toView.AttemptsMade > 0)
                {
                    new S_ViewMemoForm(currentUser, toView).Show();
                    this.Hide();
                } else
                    MessageBox.Show("You may not view the test memorundum before taking it", "Restricted",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void TsiLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

       
    }
}
