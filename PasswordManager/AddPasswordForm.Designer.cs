namespace PasswordManager
{
    partial class AddPasswordForm
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
            tableLayoutPanelRow1 = new TableLayoutPanel();
            tbEnterPassword = new TextBox();
            tbEnterLogin = new TextBox();
            lblEnterService = new Label();
            lblEnterLogin = new Label();
            lblEnterPassword = new Label();
            tbEnterService = new TextBox();
            tableLayoutPanelRow2 = new TableLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanelRow1.SuspendLayout();
            tableLayoutPanelRow2.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelRow1
            // 
            tableLayoutPanelRow1.AutoSize = true;
            tableLayoutPanelRow1.ColumnCount = 1;
            tableLayoutPanelRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRow1.Controls.Add(tbEnterPassword, 0, 5);
            tableLayoutPanelRow1.Controls.Add(tbEnterLogin, 0, 3);
            tableLayoutPanelRow1.Controls.Add(lblEnterService, 0, 0);
            tableLayoutPanelRow1.Controls.Add(lblEnterLogin, 0, 2);
            tableLayoutPanelRow1.Controls.Add(lblEnterPassword, 0, 4);
            tableLayoutPanelRow1.Controls.Add(tbEnterService, 0, 1);
            tableLayoutPanelRow1.Dock = DockStyle.Fill;
            tableLayoutPanelRow1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableLayoutPanelRow1.Location = new Point(3, 3);
            tableLayoutPanelRow1.Name = "tableLayoutPanelRow1";
            tableLayoutPanelRow1.RowCount = 6;
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelRow1.Size = new Size(794, 376);
            tableLayoutPanelRow1.TabIndex = 0;
            // 
            // tbEnterPassword
            // 
            tbEnterPassword.Dock = DockStyle.Fill;
            tbEnterPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbEnterPassword.Location = new Point(3, 313);
            tbEnterPassword.Name = "tbEnterPassword";
            tbEnterPassword.Size = new Size(788, 38);
            tbEnterPassword.TabIndex = 5;
            // 
            // tbEnterLogin
            // 
            tbEnterLogin.Dock = DockStyle.Fill;
            tbEnterLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbEnterLogin.Location = new Point(3, 189);
            tbEnterLogin.Name = "tbEnterLogin";
            tbEnterLogin.Size = new Size(788, 38);
            tbEnterLogin.TabIndex = 4;
            // 
            // lblEnterService
            // 
            lblEnterService.AutoSize = true;
            lblEnterService.Dock = DockStyle.Fill;
            lblEnterService.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEnterService.Location = new Point(3, 0);
            lblEnterService.Name = "lblEnterService";
            lblEnterService.Size = new Size(788, 62);
            lblEnterService.TabIndex = 0;
            lblEnterService.Text = "Введите наименование сервиса";
            lblEnterService.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblEnterLogin
            // 
            lblEnterLogin.AutoSize = true;
            lblEnterLogin.Dock = DockStyle.Fill;
            lblEnterLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEnterLogin.Location = new Point(3, 124);
            lblEnterLogin.Name = "lblEnterLogin";
            lblEnterLogin.Size = new Size(788, 62);
            lblEnterLogin.TabIndex = 1;
            lblEnterLogin.Text = "Введите логин/почту";
            lblEnterLogin.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Dock = DockStyle.Fill;
            lblEnterPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEnterPassword.Location = new Point(3, 248);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(788, 62);
            lblEnterPassword.TabIndex = 2;
            lblEnterPassword.Text = "Введите пароль";
            lblEnterPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEnterService
            // 
            tbEnterService.Dock = DockStyle.Fill;
            tbEnterService.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbEnterService.Location = new Point(3, 65);
            tbEnterService.Name = "tbEnterService";
            tbEnterService.Size = new Size(788, 38);
            tbEnterService.TabIndex = 3;
            // 
            // tableLayoutPanelRow2
            // 
            tableLayoutPanelRow2.AutoSize = true;
            tableLayoutPanelRow2.ColumnCount = 2;
            tableLayoutPanelRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRow2.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanelRow2.Controls.Add(btnConfirm, 1, 0);
            tableLayoutPanelRow2.Dock = DockStyle.Fill;
            tableLayoutPanelRow2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableLayoutPanelRow2.Location = new Point(3, 385);
            tableLayoutPanelRow2.Name = "tableLayoutPanelRow2";
            tableLayoutPanelRow2.RowCount = 1;
            tableLayoutPanelRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRow2.Size = new Size(794, 62);
            tableLayoutPanelRow2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(391, 56);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.Location = new Point(400, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(391, 56);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Подтвердить";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(tableLayoutPanelRow2, 0, 1);
            tableLayoutPanel.Controls.Add(tableLayoutPanelRow1, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel.Size = new Size(800, 450);
            tableLayoutPanel.TabIndex = 2;
            // 
            // AddPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            Name = "AddPasswordForm";
            Text = "Добавление пароля";
            tableLayoutPanelRow1.ResumeLayout(false);
            tableLayoutPanelRow1.PerformLayout();
            tableLayoutPanelRow2.ResumeLayout(false);
            tableLayoutPanelRow2.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelRow1;
        private Label lblEnterService;
        private Label lblEnterLogin;
        private Label lblEnterPassword;
        private TextBox tbEnterPassword;
        private TextBox tbEnterLogin;
        private TextBox tbEnterService;
        private TableLayoutPanel tableLayoutPanelRow2;
        private Button btnCancel;
        private Button btnConfirm;
        private TableLayoutPanel tableLayoutPanel;
    }
}