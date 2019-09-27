using System;
using System.Drawing;
using System.Windows.Forms;
using Consumables;
using System.Collections.Generic;
using Logger;

namespace MCQTestWinFormApp
{
    public partial class L_ClassListForm : Form
    {
        UserSession currentUser;
        List<Test> tests;
        List<Student> students;

        public L_ClassListForm(UserSession currentUser)
        {
            InitializeComponent();

            //initialize data
            tsiClassList.BackColor = Color.DarkRed;
            this.currentUser = currentUser;
            tsiAccount.Text = currentUser.Username;
            try {
                tests = new DBControl().GetTests(currentUser);
            }
            catch (Exception ex) { StackLog.GetInstance().Log(ex.Message + "\n" + ex.StackTrace); MessageBox.Show(ex.Message, "Error"); }

            cbxTestName.SelectedIndexChanged += (object obj, EventArgs e) => { LoadDataGrid(this, e); };

            foreach (Test test in tests)
            {
                cbxTestName.Items.Add(test.TestName);
            }
            if (cbxTestName.Items.Count > 0) cbxTestName.SelectedIndex = 0;

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

        private void TsiViewTests_Click(object sender, EventArgs e)
        {
            new L_ViewTestForm(currentUser).Show();
            this.Hide();
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            int row = -1;
            try { row = dgvStudentView.SelectedRows[0].Index; }
            catch {
                try { row = dgvStudentView.SelectedCells[0].RowIndex; }
                catch { }
            }

            if (row == -1) MessageBox.Show("Select a row to show its details", "Nothing selected");
            else
            {
                string username = dgvStudentView.Rows[row].Cells[0].Value.ToString();

                Student studentToView = students.Find((stud) => { if (stud.Username == username) return true; return false; });

                MessageBox.Show(String.Format("Student Number: {0}\nName: {1}", 
                    studentToView.Username, studentToView.LongName),studentToView.Username);//to add more, i'm lazy now
            }
            
            
        }

        private void TsiLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void LoadDataGrid(object sender, EventArgs e)
        {
            Refresh();
            int selectedTest = cbxTestName.SelectedIndex;

            try { students = new DBControl().GetStudentView(currentUser); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }

            foreach (Student student in students)
            {
                int i = dgvStudentView.Rows.Add();
                dgvStudentView.Rows[i].Cells[0].Value = student.Username;
                dgvStudentView.Rows[i].Cells[1].Value = student.LongName;

                int studTestIndex = student.Tests.FindIndex((searchTest) => 
                {
                    if (searchTest.TestId == tests[selectedTest].TestId) return true;
                    return false;
                });

                if (studTestIndex != -1)
                {
                    dgvStudentView.Rows[i].Cells[2].Value = student.Tests[studTestIndex].Mark;
                    dgvStudentView.Rows[i].Cells[3].Value = student.Tests[studTestIndex].Percentage;
                } else
                {
                    dgvStudentView.Rows[i].Cells[2].Value = "-";
                    dgvStudentView.Rows[i].Cells[3].Value = "-";
                }
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            dgvStudentView.Rows.Clear();
        }
    }
}
