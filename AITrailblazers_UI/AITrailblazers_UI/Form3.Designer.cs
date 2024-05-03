namespace AITrailblazers_UI
{
    partial class Form3
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            KYCText = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(32, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(242, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Photo and PAN Mismatch";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(34, 112);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(265, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "PAN and Aadhar verify failed";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // KYCText
            // 
            KYCText.Location = new Point(32, 191);
            KYCText.Multiline = true;
            KYCText.Name = "KYCText";
            KYCText.Size = new Size(719, 131);
            KYCText.TabIndex = 2;
            KYCText.Text = "Console Output : PAN mismatch on Bank and Income statement. ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(614, 358);
            button1.Name = "button1";
            button1.Size = new Size(137, 44);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(KYCText);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form3";
            Text = "Identity Fraud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox KYCText;
        private Button button1;
    }
}