namespace PasswordManager
{
    partial class MainForm
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
            dataGridView = new DataGridView();
            serviceColumn = new DataGridViewTextBoxColumn();
            loginColumn = new DataGridViewTextBoxColumn();
            passwordColumn = new DataGridViewTextBoxColumn();
            passwordsListLabel = new Label();
            btnImport = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            tableLayoutPanelRow1 = new TableLayoutPanel();
            btnDelete = new Button();
            btnExport = new Button();
            tableLayoutPanelRow2 = new TableLayoutPanel();
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanelRow1.SuspendLayout();
            tableLayoutPanelRow2.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { serviceColumn, loginColumn, passwordColumn });
            dataGridView.Location = new Point(0, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(782, 282);
            dataGridView.TabIndex = 0;
            // 
            // serviceColumn
            // 
            serviceColumn.HeaderText = "Сервис";
            serviceColumn.MinimumWidth = 6;
            serviceColumn.Name = "serviceColumn";
            serviceColumn.ReadOnly = true;
            // 
            // loginColumn
            // 
            loginColumn.HeaderText = "Логин";
            loginColumn.MinimumWidth = 6;
            loginColumn.Name = "loginColumn";
            loginColumn.ReadOnly = true;
            // 
            // passwordColumn
            // 
            passwordColumn.HeaderText = "Пароль";
            passwordColumn.MinimumWidth = 6;
            passwordColumn.Name = "passwordColumn";
            passwordColumn.ReadOnly = true;
            // 
            // passwordsListLabel
            // 
            passwordsListLabel.Dock = DockStyle.Top;
            passwordsListLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordsListLabel.Location = new Point(0, 0);
            passwordsListLabel.Name = "passwordsListLabel";
            passwordsListLabel.Size = new Size(782, 40);
            passwordsListLabel.TabIndex = 1;
            passwordsListLabel.Text = "Список паролей";
            passwordsListLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnImport
            // 
            btnImport.Dock = DockStyle.Fill;
            btnImport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImport.Location = new Point(3, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(382, 51);
            btnImport.TabIndex = 5;
            btnImport.Text = "Импорт";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.Location = new Point(261, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(252, 50);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(252, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanelRow1
            // 
            tableLayoutPanelRow1.AutoSize = true;
            tableLayoutPanelRow1.ColumnCount = 3;
            tableLayoutPanelRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelRow1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanelRow1.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanelRow1.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanelRow1.Dock = DockStyle.Fill;
            tableLayoutPanelRow1.Location = new Point(3, 3);
            tableLayoutPanelRow1.Name = "tableLayoutPanelRow1";
            tableLayoutPanelRow1.RowCount = 1;
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRow1.Size = new Size(776, 56);
            tableLayoutPanelRow1.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(519, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(254, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Fill;
            btnExport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExport.Location = new Point(391, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(382, 51);
            btnExport.TabIndex = 6;
            btnExport.Text = "Экспорт";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // tableLayoutPanelRow2
            // 
            tableLayoutPanelRow2.ColumnCount = 2;
            tableLayoutPanelRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRow2.Controls.Add(btnImport, 0, 0);
            tableLayoutPanelRow2.Controls.Add(btnExport, 1, 0);
            tableLayoutPanelRow2.Dock = DockStyle.Fill;
            tableLayoutPanelRow2.Location = new Point(3, 65);
            tableLayoutPanelRow2.Name = "tableLayoutPanelRow2";
            tableLayoutPanelRow2.RowCount = 1;
            tableLayoutPanelRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRow2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRow2.Size = new Size(776, 57);
            tableLayoutPanelRow2.TabIndex = 8;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = SystemColors.Control;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(tableLayoutPanelRow1, 0, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanelRow2, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Bottom;
            tableLayoutPanel.Location = new Point(0, 328);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(782, 125);
            tableLayoutPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(tableLayoutPanel);
            Controls.Add(passwordsListLabel);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "Менеджер паролей";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanelRow1.ResumeLayout(false);
            tableLayoutPanelRow2.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Label passwordsListLabel;
        private DataGridViewTextBoxColumn serviceColumn;
        private DataGridViewTextBoxColumn loginColumn;
        private DataGridViewTextBoxColumn passwordColumn;
        private Button btnImport;
        private Button btnEdit;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanelRow1;
        private Button btnExport;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanelRow2;
        private TableLayoutPanel tableLayoutPanel;
    }
}