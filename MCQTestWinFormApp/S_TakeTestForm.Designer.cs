namespace MCQTestWinFormApp
{
    partial class S_TakeTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_TakeTestForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsiAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiHome = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.tbxAnswerC = new System.Windows.Forms.TextBox();
            this.rbnAnswerA = new System.Windows.Forms.RadioButton();
            this.lblTestName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestionNumTotal = new System.Windows.Forms.Label();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbnAnswerB = new System.Windows.Forms.RadioButton();
            this.rbnAnswerC = new System.Windows.Forms.RadioButton();
            this.tbxAnswerA = new System.Windows.Forms.TextBox();
            this.tbxAnswerB = new System.Windows.Forms.TextBox();
            this.btnPreviousQ = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Maroon;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAccount,
            this.tsiHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 600);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsiAccount
            // 
            this.tsiAccount.BackColor = System.Drawing.Color.Maroon;
            this.tsiAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsiAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLogout});
            this.tsiAccount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsiAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsiAccount.Image")));
            this.tsiAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiAccount.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsiAccount.Name = "tsiAccount";
            this.tsiAccount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsiAccount.Size = new System.Drawing.Size(98, 41);
            this.tsiAccount.Text = "<user>";
            this.tsiAccount.ToolTipText = "Account";
            // 
            // tsiLogout
            // 
            this.tsiLogout.Name = "tsiLogout";
            this.tsiLogout.Size = new System.Drawing.Size(117, 22);
            this.tsiLogout.Text = "Logout";
            this.tsiLogout.Click += new System.EventHandler(this.TsiLogout_Click);
            // 
            // tsiHome
            // 
            this.tsiHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsiHome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsiHome.Image = ((System.Drawing.Image)(resources.GetObject("tsiHome.Image")));
            this.tsiHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiHome.Name = "tsiHome";
            this.tsiHome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsiHome.ShowDropDownArrow = false;
            this.tsiHome.Size = new System.Drawing.Size(98, 41);
            this.tsiHome.Text = "Home";
            this.tsiHome.Click += new System.EventHandler(this.TsiHome_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnMinimize.Location = new System.Drawing.Point(932, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 16;
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
            this.btnQuit.Location = new System.Drawing.Point(963, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(25, 25);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnNextQ
            // 
            this.btnNextQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextQ.Location = new System.Drawing.Point(720, 468);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(160, 25);
            this.btnNextQ.TabIndex = 19;
            this.btnNextQ.Text = "Next Question >";
            this.btnNextQ.UseVisualStyleBackColor = true;
            this.btnNextQ.Click += new System.EventHandler(this.BtnNextQ_Click);
            // 
            // tbxAnswerC
            // 
            this.tbxAnswerC.Location = new System.Drawing.Point(233, 388);
            this.tbxAnswerC.Name = "tbxAnswerC";
            this.tbxAnswerC.ReadOnly = true;
            this.tbxAnswerC.Size = new System.Drawing.Size(647, 25);
            this.tbxAnswerC.TabIndex = 20;
            // 
            // rbnAnswerA
            // 
            this.rbnAnswerA.AutoSize = true;
            this.rbnAnswerA.Location = new System.Drawing.Point(187, 318);
            this.rbnAnswerA.Name = "rbnAnswerA";
            this.rbnAnswerA.Size = new System.Drawing.Size(40, 21);
            this.rbnAnswerA.TabIndex = 21;
            this.rbnAnswerA.TabStop = true;
            this.rbnAnswerA.Text = "A:";
            this.rbnAnswerA.UseVisualStyleBackColor = true;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(157, 64);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(142, 27);
            this.lblTestName.TabIndex = 22;
            this.lblTestName.Text = "<Test Name>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "of";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(246, 136);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(19, 21);
            this.lblQuestionNumber.TabIndex = 25;
            this.lblQuestionNumber.Text = "0";
            // 
            // lblQuestionNumTotal
            // 
            this.lblQuestionNumTotal.AutoSize = true;
            this.lblQuestionNumTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumTotal.Location = new System.Drawing.Point(303, 136);
            this.lblQuestionNumTotal.Name = "lblQuestionNumTotal";
            this.lblQuestionNumTotal.Size = new System.Drawing.Size(28, 21);
            this.lblQuestionNumTotal.TabIndex = 26;
            this.lblQuestionNumTotal.Text = "00";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(187, 160);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.ReadOnly = true;
            this.tbxQuestion.Size = new System.Drawing.Size(693, 79);
            this.tbxQuestion.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Select Correct Answer:";
            // 
            // rbnAnswerB
            // 
            this.rbnAnswerB.AutoSize = true;
            this.rbnAnswerB.Location = new System.Drawing.Point(187, 355);
            this.rbnAnswerB.Name = "rbnAnswerB";
            this.rbnAnswerB.Size = new System.Drawing.Size(39, 21);
            this.rbnAnswerB.TabIndex = 30;
            this.rbnAnswerB.TabStop = true;
            this.rbnAnswerB.Text = "B:";
            this.rbnAnswerB.UseVisualStyleBackColor = true;
            // 
            // rbnAnswerC
            // 
            this.rbnAnswerC.AutoSize = true;
            this.rbnAnswerC.Location = new System.Drawing.Point(187, 392);
            this.rbnAnswerC.Name = "rbnAnswerC";
            this.rbnAnswerC.Size = new System.Drawing.Size(39, 21);
            this.rbnAnswerC.TabIndex = 31;
            this.rbnAnswerC.TabStop = true;
            this.rbnAnswerC.Text = "C:";
            this.rbnAnswerC.UseVisualStyleBackColor = true;
            // 
            // tbxAnswerA
            // 
            this.tbxAnswerA.Location = new System.Drawing.Point(233, 314);
            this.tbxAnswerA.Name = "tbxAnswerA";
            this.tbxAnswerA.ReadOnly = true;
            this.tbxAnswerA.Size = new System.Drawing.Size(647, 25);
            this.tbxAnswerA.TabIndex = 32;
            // 
            // tbxAnswerB
            // 
            this.tbxAnswerB.Location = new System.Drawing.Point(233, 351);
            this.tbxAnswerB.Name = "tbxAnswerB";
            this.tbxAnswerB.ReadOnly = true;
            this.tbxAnswerB.Size = new System.Drawing.Size(647, 25);
            this.tbxAnswerB.TabIndex = 33;
            // 
            // btnPreviousQ
            // 
            this.btnPreviousQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousQ.Location = new System.Drawing.Point(554, 468);
            this.btnPreviousQ.Name = "btnPreviousQ";
            this.btnPreviousQ.Size = new System.Drawing.Size(160, 25);
            this.btnPreviousQ.TabIndex = 34;
            this.btnPreviousQ.Text = "< Previous Question";
            this.btnPreviousQ.UseVisualStyleBackColor = true;
            this.btnPreviousQ.Click += new System.EventHandler(this.BtnPreviousQ_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(772, 68);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 25);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // S_TakeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPreviousQ);
            this.Controls.Add(this.tbxAnswerB);
            this.Controls.Add(this.tbxAnswerA);
            this.Controls.Add(this.rbnAnswerC);
            this.Controls.Add(this.rbnAnswerB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.lblQuestionNumTotal);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.rbnAnswerA);
            this.Controls.Add(this.tbxAnswerC);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "S_TakeTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S_TakeTestForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsiAccount;
        private System.Windows.Forms.ToolStripMenuItem tsiLogout;
        private System.Windows.Forms.ToolStripDropDownButton tsiHome;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.TextBox tbxAnswerC;
        private System.Windows.Forms.RadioButton rbnAnswerA;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestionNumTotal;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbnAnswerB;
        private System.Windows.Forms.RadioButton rbnAnswerC;
        private System.Windows.Forms.TextBox tbxAnswerA;
        private System.Windows.Forms.TextBox tbxAnswerB;
        private System.Windows.Forms.Button btnPreviousQ;
        private System.Windows.Forms.Button btnSubmit;
    }
}