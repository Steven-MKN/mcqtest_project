namespace MCQTestWinFormApp
{
    partial class R_RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblErrMsgName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblErrMsgUsername = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblErrMsgPassword = new System.Windows.Forms.Label();
            this.lblErrMsgSurname = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrMsgUserType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErrMsgName
            // 
            this.lblErrMsgName.AutoSize = true;
            this.lblErrMsgName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgName.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgName.Location = new System.Drawing.Point(351, 163);
            this.lblErrMsgName.Name = "lblErrMsgName";
            this.lblErrMsgName.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgName.TabIndex = 19;
            this.lblErrMsgName.Text = "*";
            this.lblErrMsgName.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(268, 323);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(77, 25);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lblErrMsgUsername
            // 
            this.lblErrMsgUsername.AutoSize = true;
            this.lblErrMsgUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgUsername.Location = new System.Drawing.Point(351, 122);
            this.lblErrMsgUsername.Name = "lblErrMsgUsername";
            this.lblErrMsgUsername.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgUsername.TabIndex = 17;
            this.lblErrMsgUsername.Text = "*";
            this.lblErrMsgUsername.Visible = false;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(225, 155);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(120, 25);
            this.tbxName.TabIndex = 16;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(225, 114);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(120, 25);
            this.tbxUsername.TabIndex = 15;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(172, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(147, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(159, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "MCQ Test";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnMinimize.Location = new System.Drawing.Point(432, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(463, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(25, 25);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lblErrMsgPassword
            // 
            this.lblErrMsgPassword.AutoSize = true;
            this.lblErrMsgPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgPassword.Location = new System.Drawing.Point(351, 245);
            this.lblErrMsgPassword.Name = "lblErrMsgPassword";
            this.lblErrMsgPassword.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgPassword.TabIndex = 25;
            this.lblErrMsgPassword.Text = "*";
            this.lblErrMsgPassword.Visible = false;
            // 
            // lblErrMsgSurname
            // 
            this.lblErrMsgSurname.AutoSize = true;
            this.lblErrMsgSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgSurname.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgSurname.Location = new System.Drawing.Point(351, 204);
            this.lblErrMsgSurname.Name = "lblErrMsgSurname";
            this.lblErrMsgSurname.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgSurname.TabIndex = 24;
            this.lblErrMsgSurname.Text = "*";
            this.lblErrMsgSurname.Visible = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(225, 237);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(120, 25);
            this.tbxPassword.TabIndex = 23;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(225, 196);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(120, 25);
            this.tbxSurname.TabIndex = 22;
            this.tbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(150, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(156, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Surname:";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(185, 323);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 25);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // cbxUserType
            // 
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Location = new System.Drawing.Point(225, 279);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(120, 25);
            this.cbxUserType.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(146, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "User Type:";
            // 
            // lblErrMsgUserType
            // 
            this.lblErrMsgUserType.AutoSize = true;
            this.lblErrMsgUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgUserType.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgUserType.Location = new System.Drawing.Point(351, 287);
            this.lblErrMsgUserType.Name = "lblErrMsgUserType";
            this.lblErrMsgUserType.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgUserType.TabIndex = 29;
            this.lblErrMsgUserType.Text = "*";
            this.lblErrMsgUserType.Visible = false;
            // 
            // R_RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblErrMsgUserType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblErrMsgPassword);
            this.Controls.Add(this.lblErrMsgSurname);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblErrMsgName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblErrMsgUsername);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "R_RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R_RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrMsgName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblErrMsgUsername;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblErrMsgPassword;
        private System.Windows.Forms.Label lblErrMsgSurname;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrMsgUserType;
    }
}