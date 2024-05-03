namespace AITrailblazers_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            uploadIncomeText = new TextBox();
            bankText = new TextBox();
            incomeButton = new Button();
            bankButton = new Button();
            debtTrap = new Button();
            identity = new Button();
            upload1 = new Button();
            upload2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(298, 25);
            label1.TabIndex = 0;
            label1.Text = "Upload Income Statement/ Form 16";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "Bank Statement";
            // 
            // uploadIncomeText
            // 
            uploadIncomeText.Location = new Point(12, 71);
            uploadIncomeText.Multiline = true;
            uploadIncomeText.Name = "uploadIncomeText";
            uploadIncomeText.Size = new Size(312, 63);
            uploadIncomeText.TabIndex = 4;
            uploadIncomeText.TextAlign = HorizontalAlignment.Center;
            uploadIncomeText.TextChanged += uploadIncomeText_TextChanged;
            // 
            // bankText
            // 
            bankText.Location = new Point(12, 199);
            bankText.Multiline = true;
            bankText.Name = "bankText";
            bankText.Size = new Size(312, 62);
            bankText.TabIndex = 5;
            bankText.TextAlign = HorizontalAlignment.Center;
            // 
            // incomeButton
            // 
            incomeButton.BackColor = SystemColors.Highlight;
            incomeButton.Location = new Point(365, 79);
            incomeButton.Name = "incomeButton";
            incomeButton.Size = new Size(112, 34);
            incomeButton.TabIndex = 6;
            incomeButton.Text = "Browse";
            incomeButton.UseVisualStyleBackColor = false;
            incomeButton.Click += incomeButton_Click;
            // 
            // bankButton
            // 
            bankButton.BackColor = SystemColors.HotTrack;
            bankButton.Location = new Point(365, 211);
            bankButton.Name = "bankButton";
            bankButton.Size = new Size(112, 34);
            bankButton.TabIndex = 7;
            bankButton.Text = "Browse";
            bankButton.UseVisualStyleBackColor = false;
            bankButton.Click += bankButton_Click;
            // 
            // debtTrap
            // 
            debtTrap.BackColor = SystemColors.Info;
            debtTrap.Location = new Point(12, 281);
            debtTrap.Name = "debtTrap";
            debtTrap.Size = new Size(351, 58);
            debtTrap.TabIndex = 8;
            debtTrap.Text = "Process for Debt Trap Fraud";
            debtTrap.UseVisualStyleBackColor = false;
            debtTrap.Click += debtTrap_Click;
            // 
            // identity
            // 
            identity.BackColor = SystemColors.Info;
            identity.Location = new Point(405, 281);
            identity.Name = "identity";
            identity.Size = new Size(358, 58);
            identity.TabIndex = 9;
            identity.Text = "Process for Identity Fraud";
            identity.UseVisualStyleBackColor = false;
            identity.Click += identity_Click;
            // 
            // upload1
            // 
            upload1.BackColor = SystemColors.Highlight;
            upload1.Location = new Point(550, 79);
            upload1.Name = "upload1";
            upload1.Size = new Size(213, 34);
            upload1.TabIndex = 10;
            upload1.Text = "Upload Selected File";
            upload1.UseVisualStyleBackColor = false;
            upload1.Click += upload1_Click;
            // 
            // upload2
            // 
            upload2.BackColor = SystemColors.Highlight;
            upload2.Location = new Point(550, 211);
            upload2.Name = "upload2";
            upload2.Size = new Size(213, 34);
            upload2.TabIndex = 11;
            upload2.Text = "Upload Selected File";
            upload2.UseVisualStyleBackColor = false;
            upload2.Click += upload2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(upload2);
            Controls.Add(upload1);
            Controls.Add(identity);
            Controls.Add(debtTrap);
            Controls.Add(bankButton);
            Controls.Add(incomeButton);
            Controls.Add(bankText);
            Controls.Add(uploadIncomeText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Loan Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox uploadIncomeText;
        private TextBox bankText;
        private Button incomeButton;
        private Button bankButton;
        private Button debtTrap;
        private Button identity;
        private Button upload1;
        private Button upload2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}
