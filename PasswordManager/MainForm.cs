using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PasswordManager.Models;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Перегрузка кнопок для удобства
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Ctrl+A - добавление новой записи
            if (keyData == (Keys.Control | Keys.A))
            {
                btnAdd.PerformClick();
                return true;
            }

            // Ctrl+E - изменение выбранной записи
            if (keyData == (Keys.Control | Keys.E))
            {
                btnEdit.PerformClick();
                return true;
            }

            // Ctrl+D или Delete - удаление выбранной записи
            if (keyData == Keys.Delete || keyData == (Keys.Control | Keys.D))
            {
                btnDelete.PerformClick();
                return true;
            }

            /*
             * Ctrl+I - импорт
             * Ctrl+S - экспорт
             */

            // Ctrl+Q - выход из программы
            if (keyData == (Keys.Control | Keys.Q))
            {
                ExitApplication();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPasswordForm addPasswordForm = new AddPasswordForm();

            if (addPasswordForm.ShowDialog() == DialogResult.OK)
            {
                PasswordRecord newRecord = addPasswordForm.Record;

                if (newRecord != null)
                {
                    dataGridView.Rows.Add(
                        newRecord.Service,
                        newRecord.Login,
                        newRecord.Password);

                    MessageBox.Show(
                        "Запись успешно добавлена!",
                        "Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];

                string service = selectedRow.Cells["serviceColumn"].Value.ToString();
                string login = selectedRow.Cells["loginColumn"].Value.ToString();
                string password = selectedRow.Cells["passwordColumn"].Value.ToString();

                PasswordRecord selectedRecord = new PasswordRecord(service, login, password);

                EditPasswordForm editPasswordForm = new EditPasswordForm(selectedRecord);

                if (editPasswordForm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["serviceColumn"].Value = editPasswordForm.Record.Service;
                    selectedRow.Cells["loginColumn"].Value = editPasswordForm.Record.Login;
                    selectedRow.Cells["passwordColumn"].Value = editPasswordForm.Record.Password;

                    MessageBox.Show(
                        "Запись успешно изменена!",
                        "Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, выберите запись для редактирования, нажав на квадратик слева от нужной строчки.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                string serviceName = selectedRow.Cells["serviceColumn"].Value.ToString();

                var result = MessageBox.Show($"Вы уверены в том, что хотите удалить запись для сервиса {serviceName}?",
                                              "Подтверждение удаления",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataGridView.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, выберите запись для удаления, нажав на квадратик слева от нужной строчки.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void ExitApplication()
        {
            var result = MessageBox.Show(
                "Вы точно хотите выйти? Несохраненные данные будут утеряны.",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
