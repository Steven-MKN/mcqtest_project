namespace MCQTestWinFormApp
{
    partial class L_ViewTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L_ViewTestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsiAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTests = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiNewTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiViewTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiClassList = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTests = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAveragePercent = new System.Windows.Forms.Label();
            this.dgvTestQAndA = new System.Windows.Forms.DataGridView();
            this.dgvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestQAndA)).BeginInit();
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
            this.toolStrip1.TabIndex = 11;
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
            this.tsiNewTest.ToolTipText = "Create new test";
            this.tsiNewTest.Click += new System.EventHandler(this.TsiNewTest_Click);
            // 
            // tsiViewTests
            // 
            this.tsiViewTests.Name = "tsiViewTests";
            this.tsiViewTests.Size = new System.Drawing.Size(142, 22);
            this.tsiViewTests.Text = "View Tests";
            this.tsiViewTests.ToolTipText = "View existing tests";
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
            this.btnMinimize.TabIndex = 10;
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
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(899, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "%";
            // 
            // cbxTests
            // 
            this.cbxTests.FormattingEnabled = true;
            this.cbxTests.Location = new System.Drawing.Point(215, 92);
            this.cbxTests.Name = "cbxTests";
            this.cbxTests.Size = new System.Drawing.Size(200, 25);
            this.cbxTests.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(173, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Test:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(776, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Test Average:";
            // 
            // lblAveragePercent
            // 
            this.lblAveragePercent.AutoSize = true;
            this.lblAveragePercent.BackColor = System.Drawing.Color.Transparent;
            this.lblAveragePercent.Location = new System.Drawing.Point(871, 100);
            this.lblAveragePercent.Name = "lblAveragePercent";
            this.lblAveragePercent.Size = new System.Drawing.Size(22, 17);
            this.lblAveragePercent.TabIndex = 17;
            this.lblAveragePercent.Text = "00";
            // 
            // dgvTestQAndA
            // 
            this.dgvTestQAndA.AllowUserToAddRows = false;
            this.dgvTestQAndA.AllowUserToDeleteRows = false;
            this.dgvTestQAndA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestQAndA.ColumnHeadersVisible = false;
            this.dgvTestQAndA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol});
            this.dgvTestQAndA.GridColor = System.Drawing.Color.Maroon;
            this.dgvTestQAndA.Location = new System.Drawing.Point(176, 136);
            this.dgvTestQAndA.MultiSelect = false;
            this.dgvTestQAndA.Name = "dgvTestQAndA";
            this.dgvTestQAndA.ReadOnly = true;
            this.dgvTestQAndA.Size = new System.Drawing.Size(744, 364);
            this.dgvTestQAndA.TabIndex = 25;
            // 
            // dgvCol
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCol.HeaderText = "";
            this.dgvCol.Name = "dgvCol";
            this.dgvCol.ReadOnly = true;
            this.dgvCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvCol.Width = 700;
            // 
            // L_ViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvTestQAndA);
            this.Controls.Add(this.lblAveragePercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "L_ViewTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L_ViewTestForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestQAndA)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAveragePercent;
        private System.Windows.Forms.DataGridView dgvTestQAndA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol;
    }
}