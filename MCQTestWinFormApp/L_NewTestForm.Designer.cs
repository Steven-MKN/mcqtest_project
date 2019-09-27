namespace MCQTestWinFormApp
{
    partial class L_NewTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L_NewTestForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsiAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTests = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiNewTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiViewTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiClassList = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblErrMshTestName = new System.Windows.Forms.Label();
            this.tbxAnswerA = new System.Windows.Forms.TextBox();
            this.cbxCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTestName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAllowedAttempts = new System.Windows.Forms.ComboBox();
            this.btnCreateText = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuestionTotal = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAnswerB = new System.Windows.Forms.TextBox();
            this.tbxAnswerC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.lblErrMsgQuestion = new System.Windows.Forms.Label();
            this.lblErrMsgAnswerA = new System.Windows.Forms.Label();
            this.lblErrMsgAnswerB = new System.Windows.Forms.Label();
            this.lblErrMsgAnswerC = new System.Windows.Forms.Label();
            this.lblErrMsgCorrectAnswer = new System.Windows.Forms.Label();
            this.btnPreviousQuestion = new System.Windows.Forms.Button();
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
            this.tsiTests,
            this.tsiClassList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 600);
            this.toolStrip1.TabIndex = 8;
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
            // tsiTests
            // 
            this.tsiTests.BackColor = System.Drawing.Color.Maroon;
            this.tsiTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsiTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNewTest,
            this.tsiViewTests});
            this.tsiTests.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsiTests.Image = ((System.Drawing.Image)(resources.GetObject("tsiTests.Image")));
            this.tsiTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiTests.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsiTests.Name = "tsiTests";
            this.tsiTests.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsiTests.Size = new System.Drawing.Size(98, 41);
            this.tsiTests.Text = "Tests";
            // 
            // tsiNewTest
            // 
            this.tsiNewTest.Name = "tsiNewTest";
            this.tsiNewTest.Size = new System.Drawing.Size(142, 22);
            this.tsiNewTest.Text = "New Test";
            this.tsiNewTest.ToolTipText = "Create new test";
            // 
            // tsiViewTests
            // 
            this.tsiViewTests.Name = "tsiViewTests";
            this.tsiViewTests.Size = new System.Drawing.Size(142, 22);
            this.tsiViewTests.Text = "View Tests";
            this.tsiViewTests.ToolTipText = "View existing tests";
            this.tsiViewTests.Click += new System.EventHandler(this.TsiViewTests_Click);
            // 
            // tsiClassList
            // 
            this.tsiClassList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsiClassList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsiClassList.Image = ((System.Drawing.Image)(resources.GetObject("tsiClassList.Image")));
            this.tsiClassList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiClassList.Name = "tsiClassList";
            this.tsiClassList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsiClassList.ShowDropDownArrow = false;
            this.tsiClassList.Size = new System.Drawing.Size(98, 41);
            this.tsiClassList.Text = "Class List";
            this.tsiClassList.ToolTipText = "View student marks";
            this.tsiClassList.Click += new System.EventHandler(this.TsiClassList_Click);
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
            this.btnMinimize.TabIndex = 7;
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
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lblErrMshTestName
            // 
            this.lblErrMshTestName.AutoSize = true;
            this.lblErrMshTestName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMshTestName.ForeColor = System.Drawing.Color.Red;
            this.lblErrMshTestName.Location = new System.Drawing.Point(405, 57);
            this.lblErrMshTestName.Name = "lblErrMshTestName";
            this.lblErrMshTestName.Size = new System.Drawing.Size(15, 17);
            this.lblErrMshTestName.TabIndex = 9;
            this.lblErrMshTestName.Text = "*";
            this.lblErrMshTestName.Visible = false;
            // 
            // tbxAnswerA
            // 
            this.tbxAnswerA.Location = new System.Drawing.Point(239, 306);
            this.tbxAnswerA.Name = "tbxAnswerA";
            this.tbxAnswerA.Size = new System.Drawing.Size(668, 25);
            this.tbxAnswerA.TabIndex = 10;
            // 
            // cbxCorrectAnswer
            // 
            this.cbxCorrectAnswer.FormattingEnabled = true;
            this.cbxCorrectAnswer.Location = new System.Drawing.Point(285, 444);
            this.cbxCorrectAnswer.Name = "cbxCorrectAnswer";
            this.cbxCorrectAnswer.Size = new System.Drawing.Size(50, 25);
            this.cbxCorrectAnswer.TabIndex = 11;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextQuestion.Location = new System.Drawing.Point(772, 524);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(135, 25);
            this.btnNextQuestion.TabIndex = 12;
            this.btnNextQuestion.Text = "Next Question >";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(167, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test Name:";
            // 
            // tbxTestName
            // 
            this.tbxTestName.Location = new System.Drawing.Point(249, 57);
            this.tbxTestName.Name = "tbxTestName";
            this.tbxTestName.Size = new System.Drawing.Size(150, 25);
            this.tbxTestName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(483, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Attemps Allowed:";
            // 
            // cbxAllowedAttempts
            // 
            this.cbxAllowedAttempts.FormattingEnabled = true;
            this.cbxAllowedAttempts.Location = new System.Drawing.Point(602, 57);
            this.cbxAllowedAttempts.Name = "cbxAllowedAttempts";
            this.cbxAllowedAttempts.Size = new System.Drawing.Size(50, 25);
            this.cbxAllowedAttempts.TabIndex = 16;
            // 
            // btnCreateText
            // 
            this.btnCreateText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateText.Location = new System.Drawing.Point(800, 57);
            this.btnCreateText.Name = "btnCreateText";
            this.btnCreateText.Size = new System.Drawing.Size(107, 25);
            this.btnCreateText.TabIndex = 17;
            this.btnCreateText.Text = "Create Test";
            this.btnCreateText.UseVisualStyleBackColor = true;
            this.btnCreateText.Click += new System.EventHandler(this.BtnCreateText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "of";
            // 
            // lblQuestionTotal
            // 
            this.lblQuestionTotal.AutoSize = true;
            this.lblQuestionTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionTotal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTotal.Location = new System.Drawing.Point(339, 136);
            this.lblQuestionTotal.Name = "lblQuestionTotal";
            this.lblQuestionTotal.Size = new System.Drawing.Size(24, 27);
            this.lblQuestionTotal.TabIndex = 20;
            this.lblQuestionTotal.Text = "n";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(271, 136);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(24, 27);
            this.lblQuestionNumber.TabIndex = 21;
            this.lblQuestionNumber.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(169, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Question:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(160, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Answer A:";
            // 
            // tbxAnswerB
            // 
            this.tbxAnswerB.Location = new System.Drawing.Point(239, 352);
            this.tbxAnswerB.Name = "tbxAnswerB";
            this.tbxAnswerB.Size = new System.Drawing.Size(668, 25);
            this.tbxAnswerB.TabIndex = 25;
            // 
            // tbxAnswerC
            // 
            this.tbxAnswerC.Location = new System.Drawing.Point(239, 398);
            this.tbxAnswerC.Name = "tbxAnswerC";
            this.tbxAnswerC.Size = new System.Drawing.Size(668, 25);
            this.tbxAnswerC.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(160, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Answer B:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(160, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Answer C:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(160, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Correct Answer is:";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(239, 216);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(668, 69);
            this.tbxQuestion.TabIndex = 30;
            // 
            // lblErrMsgQuestion
            // 
            this.lblErrMsgQuestion.AutoSize = true;
            this.lblErrMsgQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgQuestion.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgQuestion.Location = new System.Drawing.Point(913, 216);
            this.lblErrMsgQuestion.Name = "lblErrMsgQuestion";
            this.lblErrMsgQuestion.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgQuestion.TabIndex = 31;
            this.lblErrMsgQuestion.Text = "*";
            this.lblErrMsgQuestion.Visible = false;
            // 
            // lblErrMsgAnswerA
            // 
            this.lblErrMsgAnswerA.AutoSize = true;
            this.lblErrMsgAnswerA.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgAnswerA.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgAnswerA.Location = new System.Drawing.Point(913, 306);
            this.lblErrMsgAnswerA.Name = "lblErrMsgAnswerA";
            this.lblErrMsgAnswerA.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgAnswerA.TabIndex = 32;
            this.lblErrMsgAnswerA.Text = "*";
            this.lblErrMsgAnswerA.Visible = false;
            // 
            // lblErrMsgAnswerB
            // 
            this.lblErrMsgAnswerB.AutoSize = true;
            this.lblErrMsgAnswerB.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgAnswerB.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgAnswerB.Location = new System.Drawing.Point(913, 352);
            this.lblErrMsgAnswerB.Name = "lblErrMsgAnswerB";
            this.lblErrMsgAnswerB.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgAnswerB.TabIndex = 33;
            this.lblErrMsgAnswerB.Text = "*";
            this.lblErrMsgAnswerB.Visible = false;
            // 
            // lblErrMsgAnswerC
            // 
            this.lblErrMsgAnswerC.AutoSize = true;
            this.lblErrMsgAnswerC.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgAnswerC.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgAnswerC.Location = new System.Drawing.Point(913, 398);
            this.lblErrMsgAnswerC.Name = "lblErrMsgAnswerC";
            this.lblErrMsgAnswerC.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgAnswerC.TabIndex = 34;
            this.lblErrMsgAnswerC.Text = "*";
            this.lblErrMsgAnswerC.Visible = false;
            // 
            // lblErrMsgCorrectAnswer
            // 
            this.lblErrMsgCorrectAnswer.AutoSize = true;
            this.lblErrMsgCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblErrMsgCorrectAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgCorrectAnswer.Location = new System.Drawing.Point(341, 444);
            this.lblErrMsgCorrectAnswer.Name = "lblErrMsgCorrectAnswer";
            this.lblErrMsgCorrectAnswer.Size = new System.Drawing.Size(15, 17);
            this.lblErrMsgCorrectAnswer.TabIndex = 35;
            this.lblErrMsgCorrectAnswer.Text = "*";
            this.lblErrMsgCorrectAnswer.Visible = false;
            // 
            // btnPreviousQuestion
            // 
            this.btnPreviousQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousQuestion.Location = new System.Drawing.Point(631, 524);
            this.btnPreviousQuestion.Name = "btnPreviousQuestion";
            this.btnPreviousQuestion.Size = new System.Drawing.Size(135, 25);
            this.btnPreviousQuestion.TabIndex = 36;
            this.btnPreviousQuestion.Text = "< Previous Question";
            this.btnPreviousQuestion.UseVisualStyleBackColor = true;
            this.btnPreviousQuestion.Click += new System.EventHandler(this.BtnPreviousQuestion_Click);
            // 
            // L_NewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnPreviousQuestion);
            this.Controls.Add(this.lblErrMsgCorrectAnswer);
            this.Controls.Add(this.lblErrMsgAnswerC);
            this.Controls.Add(this.lblErrMsgAnswerB);
            this.Controls.Add(this.lblErrMsgAnswerA);
            this.Controls.Add(this.lblErrMsgQuestion);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxAnswerC);
            this.Controls.Add(this.tbxAnswerB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblQuestionTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreateText);
            this.Controls.Add(this.cbxAllowedAttempts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.cbxCorrectAnswer);
            this.Controls.Add(this.tbxAnswerA);
            this.Controls.Add(this.lblErrMshTestName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "L_NewTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L_NewTestForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsiAccount;
        private System.Windows.Forms.ToolStripMenuItem tsiLogout;
        private System.Windows.Forms.ToolStripDropDownButton tsiTests;
        private System.Windows.Forms.ToolStripMenuItem tsiNewTest;
        private System.Windows.Forms.ToolStripMenuItem tsiViewTests;
        private System.Windows.Forms.ToolStripDropDownButton tsiClassList;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblErrMshTestName;
        private System.Windows.Forms.TextBox tbxAnswerA;
        private System.Windows.Forms.ComboBox cbxCorrectAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTestName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxAllowedAttempts;
        private System.Windows.Forms.Button btnCreateText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuestionTotal;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAnswerB;
        private System.Windows.Forms.TextBox tbxAnswerC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Label lblErrMsgQuestion;
        private System.Windows.Forms.Label lblErrMsgAnswerA;
        private System.Windows.Forms.Label lblErrMsgAnswerB;
        private System.Windows.Forms.Label lblErrMsgAnswerC;
        private System.Windows.Forms.Label lblErrMsgCorrectAnswer;
        private System.Windows.Forms.Button btnPreviousQuestion;
    }
}