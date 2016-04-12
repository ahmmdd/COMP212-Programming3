namespace DelegateAttemptASGN
{
    partial class WarningForm
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
            this.warningMessage = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warningMessage
            // 
            this.warningMessage.AutoSize = true;
            this.warningMessage.Location = new System.Drawing.Point(12, 27);
            this.warningMessage.Name = "warningMessage";
            this.warningMessage.Size = new System.Drawing.Size(266, 13);
            this.warningMessage.TabIndex = 0;
            this.warningMessage.Text = "Are you sure you wanna exit the subscription process ?";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(121, 69);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(45, 31);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 112);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.warningMessage);
            this.Name = "WarningForm";
            this.Text = "WarningForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningMessage;
        private System.Windows.Forms.Button okButton;
    }
}