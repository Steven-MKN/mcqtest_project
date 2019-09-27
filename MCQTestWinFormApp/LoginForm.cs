using System;
using System.Windows.Forms;
using Consumables;
using Logger;

namespace MCQTestWinFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Refresh();

            bool isUsername = false;
            bool isPassword = false;

            if (tbxUsername.Text == "") lblErrMsgUsername.Visible = true;
            else isUsername = true;

            if (tbxPassword.Text == "") lblErrMsgPassword.Visible = true;
            else isPassword = true;

            if (isUsername && isPassword)
            {
                try
                {
                    UserSession currentUser = new DBControl().LoginUser(tbxUsername.Text, tbxPassword.Text);

                    if (currentUser == null)
                    {
                        MessageBox.Show("Username or/and password is incorrect.",
                            "Invalid Credentials");
                    }
                    else
                    {
                        switch (currentUser.UserType)
                        {
                            case 's':
                                new S_StudentHome(currentUser).Show(); this.Hide();
                                break;
                            case 'l':
                                new L_ClassListForm(currentUser).Show(); this.Hide();
                                break;
                            case 'r':
                                new R_RegisterForm(currentUser).Show(); this.Hide();
                                break;
                        }
                    }

                } catch (Exception ex)
                { StackLog.GetInstance().Log(ex.StackTrace); MessageBox.Show(ex.Message, "Error"); }

                
               
            }
            
        }

        public override void Refresh()
        {
            base.Refresh();
            lblErrMsgUsername.Visible = false;
            lblErrMsgPassword.Visible = false;
        }
    }
}
