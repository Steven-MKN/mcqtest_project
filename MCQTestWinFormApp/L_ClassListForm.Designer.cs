namespace MCQTestWinFormApp
{
    partial class L_ClassListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L_ClassListForm));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsiAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTests = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiNewTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiViewTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiClassList = new System.Windows.Forms.ToolStripDropDownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTestName = new System.Windows.Forms.ComboBox();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.dgvStudentView = new System.Windows.Forms.DataGridView();
            this.dgvColStudentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentView)).BeginInit();
            this.SuspendLayout();
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
            this.btnMinimize.TabIndex = 4;
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
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
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
            this.toolStrip1.TabIndex = 5;
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
            this.tsiNewTest.ToolTipText = "Create a new test";
            this.tsiNewTest.Click += new System.EventHandler(this.TsiNewTest_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(244, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "View:";
            // 
            // cbxTestName
            // 
            this.cbxTestName.FormattingEnabled = true;
            this.cbxTestName.Location = new System.Drawing.Point(292, 71);
            this.cbxTestName.Name = "cbxTestName";
            this.cbxTestName.Size = new System.Drawing.Size(150, 25);
            this.cbxTestName.TabIndex = 7;
            this.cbxTestName.SelectedIndexChanged += new System.EventHandler(this.LoadDataGrid);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewStudent.Location = new System.Drawing.Point(723, 71);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(117, 25);
            this.btnViewStudent.TabIndex = 8;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.BtnViewStudent_Click);
            // 
            // dgvStudentView
            // 
            this.dgvStudentView.AllowUserToAddRows = false;
            this.dgvStudentView.AllowUserToDeleteRows = false;
            this.dgvStudentView.AllowUserToOrderColumns = true;
            this.dgvStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColStudentNum,
            this.dgvColName,
            this.dgvColMark,
            this.dgvColPercentage});
            this.dgvStudentView.GridColor = System.Drawing.Color.Maroon;
            this.dgvStudentView.Location = new System.Drawing.Point(247, 132);
            this.dgvStudentView.MultiSelect = false;
            this.dgvStudentView.Name = "dgvStudentView";
            this.dgvStudentView.ReadOnly = true;
            this.dgvStudentView.Size = new System.Drawing.Size(593, 456);
            this.dgvStudentView.TabIndex = 9;
            // 
            // dgvColStudentNum
            // 
            this.dgvColStudentNum.HeaderText = "Student Number";
            this.dgvColStudentNum.Name = "dgvColStudentNum";
            this.dgvColStudentNum.ReadOnly = true;
            this.dgvColStudentNum.Width = 150;
            // 
            // dgvColName
            // 
            this.dgvColName.HeaderText = "Student Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            this.dgvColName.Width = 190;
            // 
            // dgvColMark
            // 
            this.dgvColMark.HeaderText = "Mark";
            this.dgvColMark.Name = "dgvColMark";
            this.dgvColMark.ReadOnly = true;
            // 
            // dgvColPercentage
            // 
            this.dgvColPercentage.HeaderText = "Percentage";
            this.dgvColPercentage.Name = "dgvColPercentage";
            this.dgvColPercentage.ReadOnly = true;
            // 
            // L_ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvStudentView);
            this.Controls.Add(this.btnViewStudent);
            this.Controls.Add(this.cbxTestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "L_ClassListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L_ClassListForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsiAccount;
        private System.Windows.Forms.ToolStripMenuItem tsiLogout;
        private System.Windows.Forms.ToolStripDropDownButton tsiTests;
        private System.Windows.Forms.ToolStripMenuItem tsiNewTest;
        private System.Windows.Forms.ToolStripMenuItem tsiViewTests;
        private System.Windows.Forms.ToolStripDropDownButton tsiClassList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTestName;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.DataGridView dgvStudentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColStudentNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPercentage;
    }
}