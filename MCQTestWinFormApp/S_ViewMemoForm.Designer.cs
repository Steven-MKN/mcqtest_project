namespace MCQTestWinFormApp
{
    partial class S_ViewMemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_ViewMemoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsiAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiHome = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTestName = new System.Windows.Forms.Label();
            this.dgvViewMemo = new System.Windows.Forms.DataGridView();
            this.lblMarkObtained = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMarkTotal = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMemo)).BeginInit();
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
            this.toolStrip1.TabIndex = 20;
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
            this.btnMinimize.TabIndex = 19;
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
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(157, 64);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(142, 27);
            this.lblTestName.TabIndex = 23;
            this.lblTestName.Text = "<Test Name>";
            // 
            // dgvViewMemo
            // 
            this.dgvViewMemo.AllowUserToAddRows = false;
            this.dgvViewMemo.AllowUserToDeleteRows = false;
            this.dgvViewMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMemo.ColumnHeadersVisible = false;
            this.dgvViewMemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol});
            this.dgvViewMemo.GridColor = System.Drawing.Color.Maroon;
            this.dgvViewMemo.Location = new System.Drawing.Point(162, 132);
            this.dgvViewMemo.MultiSelect = false;
            this.dgvViewMemo.Name = "dgvViewMemo";
            this.dgvViewMemo.ReadOnly = true;
            this.dgvViewMemo.Size = new System.Drawing.Size(750, 336);
            this.dgvViewMemo.TabIndex = 24;
            // 
            // lblMarkObtained
            // 
            this.lblMarkObtained.AutoSize = true;
            this.lblMarkObtained.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkObtained.Location = new System.Drawing.Point(749, 72);
            this.lblMarkObtained.Name = "lblMarkObtained";
            this.lblMarkObtained.Size = new System.Drawing.Size(25, 19);
            this.lblMarkObtained.TabIndex = 25;
            this.lblMarkObtained.Text = "00";
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(816, 483);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(96, 25);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "/";
            // 
            // lblMarkTotal
            // 
            this.lblMarkTotal.AutoSize = true;
            this.lblMarkTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkTotal.Location = new System.Drawing.Point(780, 72);
            this.lblMarkTotal.Name = "lblMarkTotal";
            this.lblMarkTotal.Size = new System.Drawing.Size(25, 19);
            this.lblMarkTotal.TabIndex = 28;
            this.lblMarkTotal.Text = "00";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(860, 72);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(33, 19);
            this.lblPercentage.TabIndex = 29;
            this.lblPercentage.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(890, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "%";
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
            // S_ViewMemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblMarkTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblMarkObtained);
            this.Controls.Add(this.dgvViewMemo);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "S_ViewMemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S_ViewMemoForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMemo)).EndInit();
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
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.DataGridView dgvViewMemo;
        private System.Windows.Forms.Label lblMarkObtained;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMarkTotal;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol;
    }
}