namespace MCQTestWinFormApp
{
    partial class S_StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_StudentHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsiAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiHome = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.lblTestsTaken = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTestTotalCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.dgvColTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAttempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStrip1.TabIndex = 14;
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
            this.btnMinimize.TabIndex = 13;
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
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Average:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColTestName,
            this.dgvColAttempts,
            this.dgvColMark,
            this.dgvColPercentage});
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(192, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 172);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnViewTest
            // 
            this.btnViewTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewTest.Location = new System.Drawing.Point(771, 145);
            this.btnViewTest.Name = "btnViewTest";
            this.btnViewTest.Size = new System.Drawing.Size(127, 25);
            this.btnViewTest.TabIndex = 17;
            this.btnViewTest.Text = "View Test";
            this.btnViewTest.UseVisualStyleBackColor = true;
            this.btnViewTest.Click += new System.EventHandler(this.BtnViewTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tests:";
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeTest.Location = new System.Drawing.Point(771, 96);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(127, 25);
            this.btnTakeTest.TabIndex = 19;
            this.btnTakeTest.Text = "Take Test";
            this.btnTakeTest.UseVisualStyleBackColor = true;
            this.btnTakeTest.Click += new System.EventHandler(this.BtnTakeTest_Click);
            // 
            // lblTestsTaken
            // 
            this.lblTestsTaken.AutoSize = true;
            this.lblTestsTaken.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestsTaken.Location = new System.Drawing.Point(306, 319);
            this.lblTestsTaken.Name = "lblTestsTaken";
            this.lblTestsTaken.Size = new System.Drawing.Size(21, 23);
            this.lblTestsTaken.TabIndex = 20;
            this.lblTestsTaken.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tests Taken:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "of";
            // 
            // lblTestTotalCount
            // 
            this.lblTestTotalCount.AutoSize = true;
            this.lblTestTotalCount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTotalCount.Location = new System.Drawing.Point(367, 319);
            this.lblTestTotalCount.Name = "lblTestTotalCount";
            this.lblTestTotalCount.Size = new System.Drawing.Size(21, 23);
            this.lblTestTotalCount.TabIndex = 23;
            this.lblTestTotalCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "%";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(276, 365);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(32, 23);
            this.lblAverage.TabIndex = 25;
            this.lblAverage.Text = "00";
            // 
            // dgvColTestName
            // 
            this.dgvColTestName.HeaderText = "Test Name";
            this.dgvColTestName.Name = "dgvColTestName";
            this.dgvColTestName.ReadOnly = true;
            this.dgvColTestName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvColTestName.Width = 190;
            // 
            // dgvColAttempts
            // 
            this.dgvColAttempts.HeaderText = "Attempts";
            this.dgvColAttempts.Name = "dgvColAttempts";
            this.dgvColAttempts.ReadOnly = true;
            this.dgvColAttempts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColMark
            // 
            this.dgvColMark.HeaderText = "Mark";
            this.dgvColMark.Name = "dgvColMark";
            this.dgvColMark.ReadOnly = true;
            this.dgvColMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColPercentage
            // 
            this.dgvColPercentage.HeaderText = "Percentage";
            this.dgvColPercentage.Name = "dgvColPercentage";
            this.dgvColPercentage.ReadOnly = true;
            this.dgvColPercentage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // S_StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTestTotalCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTestsTaken);
            this.Controls.Add(this.btnTakeTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewTest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "S_StudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S_StudentHome";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakeTest;
        private System.Windows.Forms.Label lblTestsTaken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTestTotalCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAttempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPercentage;
    }
}