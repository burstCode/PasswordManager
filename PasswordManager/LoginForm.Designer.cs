namespace PasswordManager
{
    partial class LoginForm
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
            lblCodeEnter = new Label();
            mtbCodeEnter = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCodeEnter
            // 
            lblCodeEnter.Dock = DockStyle.Top;
            lblCodeEnter.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCodeEnter.Location = new Point(0, 0);
            lblCodeEnter.Name = "lblCodeEnter";
            lblCodeEnter.Size = new Size(482, 40);
            lblCodeEnter.TabIndex = 0;
            lblCodeEnter.Text = "Введите секретный код";
            lblCodeEnter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mtbCodeEnter
            // 
            mtbCodeEnter.BackColor = SystemColors.HighlightText;
            mtbCodeEnter.BorderStyle = BorderStyle.None;
            mtbCodeEnter.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mtbCodeEnter.Location = new Point(0, 85);
            mtbCodeEnter.Mask = "0000";
            mtbCodeEnter.Name = "mtbCodeEnter";
            mtbCodeEnter.PasswordChar = '•';
            mtbCodeEnter.PromptChar = ' ';
            mtbCodeEnter.Size = new Size(482, 36);
            mtbCodeEnter.TabIndex = 2;
            mtbCodeEnter.TextAlign = HorizontalAlignment.Center;
            mtbCodeEnter.ValidatingType = typeof(int);
            mtbCodeEnter.TextChanged += CodeEnterMaskedTextBox_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(482, 253);
            Controls.Add(mtbCodeEnter);
            Controls.Add(lblCodeEnter);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodeEnter;
        private MaskedTextBox mtbCodeEnter;
    }
}
