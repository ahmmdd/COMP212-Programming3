namespace W05TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.colorTab = new System.Windows.Forms.TabPage();
            this.sizeTab = new System.Windows.Forms.TabPage();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radSize12 = new System.Windows.Forms.RadioButton();
            this.radSize14 = new System.Windows.Forms.RadioButton();
            this.radMsgHi = new System.Windows.Forms.RadioButton();
            this.radMsgBye = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.colorTab.SuspendLayout();
            this.sizeTab.SuspendLayout();
            this.messageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.colorTab);
            this.tabControl1.Controls.Add(this.sizeTab);
            this.tabControl1.Controls.Add(this.messageTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 182);
            this.tabControl1.TabIndex = 0;
            // 
            // colorTab
            // 
            this.colorTab.Controls.Add(this.radRed);
            this.colorTab.Controls.Add(this.radBlue);
            this.colorTab.Location = new System.Drawing.Point(4, 22);
            this.colorTab.Name = "colorTab";
            this.colorTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorTab.Size = new System.Drawing.Size(424, 156);
            this.colorTab.TabIndex = 0;
            this.colorTab.Text = "Color";
            this.colorTab.UseVisualStyleBackColor = true;
            // 
            // sizeTab
            // 
            this.sizeTab.Controls.Add(this.radSize14);
            this.sizeTab.Controls.Add(this.radSize12);
            this.sizeTab.Location = new System.Drawing.Point(4, 22);
            this.sizeTab.Name = "sizeTab";
            this.sizeTab.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTab.Size = new System.Drawing.Size(424, 156);
            this.sizeTab.TabIndex = 1;
            this.sizeTab.Text = "Size";
            this.sizeTab.UseVisualStyleBackColor = true;
            // 
            // messageTab
            // 
            this.messageTab.Controls.Add(this.radMsgBye);
            this.messageTab.Controls.Add(this.radMsgHi);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Padding = new System.Windows.Forms.Padding(3);
            this.messageTab.Size = new System.Drawing.Size(424, 156);
            this.messageTab.TabIndex = 2;
            this.messageTab.Text = "Message";
            this.messageTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(27, 24);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(27, 68);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 1;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radSize12
            // 
            this.radSize12.AutoSize = true;
            this.radSize12.Location = new System.Drawing.Point(42, 28);
            this.radSize12.Name = "radSize12";
            this.radSize12.Size = new System.Drawing.Size(37, 17);
            this.radSize12.TabIndex = 0;
            this.radSize12.TabStop = true;
            this.radSize12.Text = "12";
            this.radSize12.UseVisualStyleBackColor = true;
            this.radSize12.CheckedChanged += new System.EventHandler(this.radSize12_CheckedChanged);
            // 
            // radSize14
            // 
            this.radSize14.AutoSize = true;
            this.radSize14.Location = new System.Drawing.Point(42, 73);
            this.radSize14.Name = "radSize14";
            this.radSize14.Size = new System.Drawing.Size(37, 17);
            this.radSize14.TabIndex = 1;
            this.radSize14.TabStop = true;
            this.radSize14.Text = "14";
            this.radSize14.UseVisualStyleBackColor = true;
            this.radSize14.CheckedChanged += new System.EventHandler(this.radSize14_CheckedChanged);
            // 
            // radMsgHi
            // 
            this.radMsgHi.AutoSize = true;
            this.radMsgHi.Location = new System.Drawing.Point(41, 33);
            this.radMsgHi.Name = "radMsgHi";
            this.radMsgHi.Size = new System.Drawing.Size(35, 17);
            this.radMsgHi.TabIndex = 0;
            this.radMsgHi.TabStop = true;
            this.radMsgHi.Text = "Hi";
            this.radMsgHi.UseVisualStyleBackColor = true;
            this.radMsgHi.CheckedChanged += new System.EventHandler(this.radMsgHi_CheckedChanged);
            // 
            // radMsgBye
            // 
            this.radMsgBye.AutoSize = true;
            this.radMsgBye.Location = new System.Drawing.Point(41, 82);
            this.radMsgBye.Name = "radMsgBye";
            this.radMsgBye.Size = new System.Drawing.Size(43, 17);
            this.radMsgBye.TabIndex = 1;
            this.radMsgBye.TabStop = true;
            this.radMsgBye.Text = "Bye";
            this.radMsgBye.UseVisualStyleBackColor = true;
            this.radMsgBye.CheckedChanged += new System.EventHandler(this.radMsgBye_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.colorTab.ResumeLayout(false);
            this.colorTab.PerformLayout();
            this.sizeTab.ResumeLayout(false);
            this.sizeTab.PerformLayout();
            this.messageTab.ResumeLayout(false);
            this.messageTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage colorTab;
        private System.Windows.Forms.TabPage sizeTab;
        private System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radSize14;
        private System.Windows.Forms.RadioButton radSize12;
        private System.Windows.Forms.RadioButton radMsgBye;
        private System.Windows.Forms.RadioButton radMsgHi;
    }
}

