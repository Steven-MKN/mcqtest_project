using System;
using System.Windows.Forms;
using Consumables;
using Logger;

namespace MCQTestWinFormApp
{
    public partial class R_RegisterForm : Form
    {
        UserSession currentUser;
        public R_RegisterForm(UserSession currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            //initialize components data
            cbxUserType.Items.AddRange(new string[] { "Registra", "Student", "Lecturer"});
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Refresh();
            bool isUsername = false, isName = false, isSurname = false,isPassword = false, 
                isUserType = false;

            //validate inputs
            if (tbxUsername.Text == "") lblErrMsgUsername.Visible = true;
            else isUsername = true;

            if (tbxName.Text == "") lblErrMsgName.Visible = true;
            else isName = true;

            if (tbxSurname.Text == "") lblErrMsgSurname.Visible = true;
            else isSurname = true;

            if (tbxPassword.Text == "") lblErrMsgPassword.Visible = true;
            else isPassword = true;

            if (cbxUserType.SelectedItem == null) lblErrMsgUserType.Visible = true;
            else isUserType = true;

            //register user if inputs valid
            if (isUsername && isName && isSurname && isPassword && isUserType)
            {
                bool isRegistered = false;
                try
                {
                    char userType = cbxUserType.SelectedIndex == 0 ? 'r' : cbxUserType.SelectedIndex == 1 ? 's' : 'l';
                    isRegistered = new DBControl().RegisterUser(currentUser, tbxUsername.Text,
                        tbxName.Text, tbxSurname.Text, tbxPassword.Text, userType);

                    if (isRegistered)
                    {
                        MessageBox.Show("User successfully registered", "Success");
                        tbxName.Text = String.Empty;
                        tbxSurname.Text = String.Empty;
                        tbxPassword.Text = String.Empty;
                        tbxUsername.Text = String.Empty;
                        cbxUserType.SelectedIndex = -1;
                    }
                    else
                        MessageBox.Show("Failed to register user", "Failed");

                }
                catch (Exception ex)
                {
                    StackLog.GetInstance().Log(ex.StackTrace); MessageBox.Show(ex.Message, "Error");
                }

                
            }
        }

        public override void Refresh()
        {
            base.Refresh();

            lblErrMsgUsername.Visible = false;
            lblErrMsgName.Visible = false;
            lblErrMsgSurname.Visible = false;
            lblErrMsgPassword.Visible = false;
            lblErrMsgUserType.Visible = false;
        }
    }
}
