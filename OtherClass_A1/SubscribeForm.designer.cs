namespace DelegateAttemptASGN
{
    partial class SubscribeForm
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
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(44, 44);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(136, 17);
            this.emailCheckBox.TabIndex = 0;
            this.emailCheckBox.Text = "Message Sent by Email";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            this.emailCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(237, 44);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Email Address";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(237, 94);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(227, 20);
            this.phoneTextBox.TabIndex = 3;
            this.phoneTextBox.Text = "xxx-xxx-xxxx";
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Location = new System.Drawing.Point(44, 94);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(142, 17);
            this.phoneCheckBox.TabIndex = 2;
            this.phoneCheckBox.Text = "Message Sent by Mobile";
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(63, 147);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(84, 29);
            this.subscribeButton.TabIndex = 4;
            this.subscribeButton.Text = "Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(214, 147);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(84, 29);
            this.unsubscribeButton.TabIndex = 5;
            this.unsubscribeButton.Text = "Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(361, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailCheckBox);
            this.Name = "SubscribeForm";
            this.Text = "SubscribeForm";
            this.Load += new System.EventHandler(this.SubscribeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}