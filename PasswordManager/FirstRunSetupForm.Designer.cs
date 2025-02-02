namespace PasswordManager
{
    partial class FirstRunSetupForm
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
            lblPinCode = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            mtbPinCodeConfirm = new MaskedTextBox();
            mtbPinCode = new MaskedTextBox();
            btnSetPinCode = new Button();
            lblEnterPinCode = new Label();
            lblPinCodeConfirm = new Label();
            lblHorizontalLine = new Label();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblPinCode
            // 
            lblPinCode.AutoSize = true;
            lblPinCode.Dock = DockStyle.Fill;
            lblPinCode.Location = new Point(5, 0);
            lblPinCode.Margin = new Padding(5, 0, 5, 0);
            lblPinCode.Name = "lblPinCode";
            lblPinCode.Size = new Size(374, 60);
            lblPinCode.TabIndex = 0;
            lblPinCode.Text = "Придумайте пин-код для входа в приложение";
            lblPinCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(btnSetPinCode, 0, 6);
            tableLayoutPanel.Controls.Add(mtbPinCodeConfirm, 0, 5);
            tableLayoutPanel.Controls.Add(mtbPinCode, 0, 3);
            tableLayoutPanel.Controls.Add(lblEnterPinCode, 0, 2);
            tableLayoutPanel.Controls.Add(lblPinCodeConfirm, 0, 4);
            tableLayoutPanel.Controls.Add(lblPinCode, 0, 0);
            tableLayoutPanel.Controls.Add(lblHorizontalLine, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 21.6383324F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1.08191657F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4559517F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4559517F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4559517F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4559517F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4559517F));
            tableLayoutPanel.Size = new Size(384, 281);
            tableLayoutPanel.TabIndex = 1;
            // 
            // mtbPinCodeConfirm
            // 
            mtbPinCodeConfirm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mtbPinCodeConfirm.BackColor = SystemColors.Window;
            mtbPinCodeConfirm.BorderStyle = BorderStyle.None;
            mtbPinCodeConfirm.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mtbPinCodeConfirm.Location = new Point(3, 199);
            mtbPinCodeConfirm.Margin = new Padding(3, 2, 3, 2);
            mtbPinCodeConfirm.Mask = "0000";
            mtbPinCodeConfirm.Name = "mtbPinCodeConfirm";
            mtbPinCodeConfirm.PasswordChar = '•';
            mtbPinCodeConfirm.PromptChar = ' ';
            mtbPinCodeConfirm.Size = new Size(378, 29);
            mtbPinCodeConfirm.TabIndex = 4;
            mtbPinCodeConfirm.TextAlign = HorizontalAlignment.Center;
            mtbPinCodeConfirm.ValidatingType = typeof(int);
            // 
            // mtbPinCode
            // 
            mtbPinCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mtbPinCode.BackColor = SystemColors.Window;
            mtbPinCode.BorderStyle = BorderStyle.None;
            mtbPinCode.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mtbPinCode.Location = new Point(3, 113);
            mtbPinCode.Margin = new Padding(3, 2, 3, 2);
            mtbPinCode.Mask = "0000";
            mtbPinCode.Name = "mtbPinCode";
            mtbPinCode.PasswordChar = '•';
            mtbPinCode.PromptChar = ' ';
            mtbPinCode.Size = new Size(378, 29);
            mtbPinCode.TabIndex = 3;
            mtbPinCode.TextAlign = HorizontalAlignment.Center;
            mtbPinCode.ValidatingType = typeof(int);
            // 
            // btnSetPinCode
            // 
            btnSetPinCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSetPinCode.Location = new Point(3, 238);
            btnSetPinCode.Name = "btnSetPinCode";
            btnSetPinCode.Size = new Size(378, 40);
            btnSetPinCode.TabIndex = 5;
            btnSetPinCode.Text = "Начать пользование";
            btnSetPinCode.UseVisualStyleBackColor = true;
            btnSetPinCode.Click += btnSetPinCode_Click;
            // 
            // lblEnterPinCode
            // 
            lblEnterPinCode.AutoSize = true;
            lblEnterPinCode.Dock = DockStyle.Fill;
            lblEnterPinCode.Location = new Point(3, 63);
            lblEnterPinCode.Name = "lblEnterPinCode";
            lblEnterPinCode.Size = new Size(378, 43);
            lblEnterPinCode.TabIndex = 6;
            lblEnterPinCode.Text = "Введите пин-код";
            lblEnterPinCode.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblPinCodeConfirm
            // 
            lblPinCodeConfirm.AutoSize = true;
            lblPinCodeConfirm.Dock = DockStyle.Fill;
            lblPinCodeConfirm.Location = new Point(3, 149);
            lblPinCodeConfirm.Name = "lblPinCodeConfirm";
            lblPinCodeConfirm.Size = new Size(378, 43);
            lblPinCodeConfirm.TabIndex = 7;
            lblPinCodeConfirm.Text = "Подтвердите пин-код";
            lblPinCodeConfirm.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblHorizontalLine
            // 
            lblHorizontalLine.BorderStyle = BorderStyle.Fixed3D;
            lblHorizontalLine.Dock = DockStyle.Top;
            lblHorizontalLine.Location = new Point(3, 60);
            lblHorizontalLine.MaximumSize = new Size(0, 2);
            lblHorizontalLine.Name = "lblHorizontalLine";
            lblHorizontalLine.Size = new Size(378, 2);
            lblHorizontalLine.TabIndex = 8;
            // 
            // FirstRunSetupForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 281);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FirstRunSetupForm";
            Text = "Первоначальная настройка";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPinCode;
        private TableLayoutPanel tableLayoutPanel;
        private MaskedTextBox mtbPinCode;
        private MaskedTextBox mtbPinCodeConfirm;
        private Button btnSetPinCode;
        private Label lblEnterPinCode;
        private Label lblPinCodeConfirm;
        private Label lblHorizontalLine;
    }
}