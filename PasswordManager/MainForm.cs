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
        Logger logger;

        public MainForm()
        {
            InitializeComponent();

            logger = new Logger();
            logger.Log("Успешный вход");
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

            // Ctrl+O - импорт файла с паролями
            if (keyData == (Keys.Control | Keys.O))
            {
                btnImport.PerformClick();
                return true;
            }

            // Ctrl+S - экспорт файла с паролями
            if (keyData == (Keys.Control | Keys.S))
            {
                btnExport.PerformClick();
                return true;
            }

            /*
             * F1 - страница помощи
             */

            // Ctrl+Q - выход из программы
            if (keyData == (Keys.Control | Keys.Q))
            {
                Application.Exit();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Перегрузка закрытия формы на "крестик"
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            DialogResult result = MessageBox.Show(
                "Вы точно хотите выйти? Несохраненные данные будут утеряны",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            logger.Log("Выход из программы");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPasswordForm addPasswordForm = new AddPasswordForm();

            logger.Log("Открытие формы добавления записи...");

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

                    logger.Log("Успешное добавление записи");
                }
                else
                {
                    logger.Log("Не удалось добавить запись", LogType.Error);
                }
            }
            else
            {
                logger.Log("Закрытие окна добавления записи...");
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

                logger.Log("Открытие формы изменения записи...");

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

                    logger.Log("Успешное изменение записи");
                }
                else
                {
                    logger.Log("Закрытие окна изменения записи...");
                }
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, выберите запись для редактирования, нажав на квадратик слева от нужной строчки",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                logger.Log("Не была выбрана запись для редактирования", LogType.Warning);
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

                    logger.Log("Успешное удаление записи");
                }
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, выберите запись для удаления, нажав на квадратик слева от нужной строчки",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                logger.Log("Не была выбрана запись для удаления", LogType.Warning);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Encryptor encryptor = new Encryptor();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Passwords file (*.pswd)|*.pswd|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    string decryptedData = string.Empty;

                    try
                    {
                        decryptedData = encryptor.Decrypt(fileName);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(
                            $"Не удалось расшифровать пароли",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        logger.Log($"Не удалось расшифровать пароли. Вызвано исключение: {ex}", LogType.Error);

                        return;
                    }

                    dataGridView.Rows.Clear();

                    if (!string.IsNullOrEmpty(decryptedData))
                    {
                        string[] records = decryptedData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string record in records)
                        {
                            string[] fields = record.Split(',');

                            if (fields.Length == 3)
                            {
                                PasswordRecord passwordRecord = new PasswordRecord(fields[0], fields[1], fields[2]);

                                dataGridView.Rows.Add(passwordRecord.Service, passwordRecord.Login, passwordRecord.Password);
                            }
                        }

                        MessageBox.Show(
                            "Пароли успешно расшифрованы!",
                            "Успех",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        logger.Log("Успешное расшифрование паролей");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Импортирован пустой файл",
                            "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        logger.Log("Импортирован пустой файл", LogType.Warning);
                    }
                }
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите сохранить пустой файл без паролей?",
                    "Пусто",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);

                if (result == DialogResult.No)
                {
                    return;
                }

                logger.Log("Экспорт пустого файла без паролей", LogType.Warning);
            }

            Encryptor encryptor = new Encryptor();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "Passwords file (*.pswd)|*.pswd|All files (*.*)|*.*";
                saveFileDialog.FileName = "Passwords";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    
                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string service = row.Cells["serviceColumn"].Value?.ToString();
                        string login = row.Cells["loginColumn"].Value?.ToString();
                        string password = row.Cells["passwordColumn"].Value?.ToString();

                        // Мне кажется, что использование модели в этой программе бессмысленно и никак
                        // не оптимизирует код :D
                        PasswordRecord record = new PasswordRecord(service, login, password);

                        stringBuilder.AppendLine($"{record.Service},{record.Login},{record.Password}");
                    }

                    string messageToEncrypt = stringBuilder.ToString();

                    try
                    {
                        encryptor.Encrypt(fileName, messageToEncrypt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Не удалось зашифровать пароли",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        logger.Log($"Не удалось зашифровать пароли. Вызвано исключение: {ex}", LogType.Error);

                        return;
                    }

                    MessageBox.Show(
                        $"Пароли успешно зашифрованы по пути {fileName}!",
                        "Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    logger.Log($"Пароли успешно зашифрованы по пути {fileName}");
                }
            }
        }
    }
}
