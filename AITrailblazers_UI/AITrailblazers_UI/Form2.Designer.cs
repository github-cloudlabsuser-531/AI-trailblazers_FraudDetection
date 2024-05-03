namespace AITrailblazers_UI
{
    partial class Form2
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
            form2Text = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(36, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Loan Stacking : Debt Trap";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(36, 117);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(183, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "KYC No. Mismatch";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // form2Text
            // 
            form2Text.Location = new Point(36, 175);
            form2Text.Multiline = true;
            form2Text.Name = "form2Text";
            form2Text.Size = new Size(721, 146);
            form2Text.TabIndex = 2;
            form2Text.Text = "Console Output : User has other loans and unable to service new loan. PAN mismatch on Bank and Income statement.";
            form2Text.TextChanged += form2Text_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(form2Text);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form2";
            Text = "Debt trap fraud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox form2Text;
    }
}