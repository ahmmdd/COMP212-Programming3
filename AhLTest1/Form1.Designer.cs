namespace AhLTest1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAllAccounts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtxtDisplayAccounts = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExit});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(37, 20);
            this.tsFile.Text = "File";
            this.tsFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(152, 22);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tsAccount
            // 
            this.tsAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSearch,
            this.tsView});
            this.tsAccount.Name = "tsAccount";
            this.tsAccount.Size = new System.Drawing.Size(64, 20);
            this.tsAccount.Text = "Account";
            // 
            // tsSearch
            // 
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(152, 22);
            this.tsSearch.Text = "Search";
            this.tsSearch.Click += new System.EventHandler(this.tsSearch_Click);
            // 
            // tsView
            // 
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(152, 22);
            this.tsView.Text = "View";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(41, 42);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(126, 13);
            this.lblAccountNo.TabIndex = 1;
            this.lblAccountNo.Text = "Enter Your Account No. :";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(251, 39);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNo.TabIndex = 2;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewAllAccounts
            // 
            this.btnViewAllAccounts.Location = new System.Drawing.Point(93, 101);
            this.btnViewAllAccounts.Name = "btnViewAllAccounts";
            this.btnViewAllAccounts.Size = new System.Drawing.Size(229, 23);
            this.btnViewAllAccounts.TabIndex = 4;
            this.btnViewAllAccounts.Text = "View All Accounts";
            this.btnViewAllAccounts.UseVisualStyleBackColor = true;
            this.btnViewAllAccounts.Click += new System.EventHandler(this.btnViewAllAccounts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(229, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtxtDisplayAccounts
            // 
            this.rtxtDisplayAccounts.Location = new System.Drawing.Point(93, 159);
            this.rtxtDisplayAccounts.Name = "rtxtDisplayAccounts";
            this.rtxtDisplayAccounts.ReadOnly = true;
            this.rtxtDisplayAccounts.Size = new System.Drawing.Size(229, 96);
            this.rtxtDisplayAccounts.TabIndex = 6;
            this.rtxtDisplayAccounts.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.rtxtDisplayAccounts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewAllAccounts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mohammed Juned Ahmed - 300833356";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsAccount;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsSearch;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAllAccounts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtxtDisplayAccounts;
    }
}

