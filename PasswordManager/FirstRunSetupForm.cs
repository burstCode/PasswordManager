using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class FirstRunSetupForm : Form
    {
        public FirstRunSetupForm()
        {
            InitializeComponent();
        }

        private void btnSetPinCode_Click(object sender, EventArgs e)
        {
            if (mtbPinCode.Text != mtbPinCodeConfirm.Text)
            {
                MessageBox.Show(
                    "Пин-коды не совпадают. Пожалуйста, введите их снова.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (mtbPinCode.Text.Length != 4 || string.IsNullOrEmpty(mtbPinCode.Text))
            {
                MessageBox.Show(
                    "Длина пин-кода должна быть равна 4-м символам.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Создание папки в %appdata%
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, "PasswordManager");

            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }

            // Создание конфига
            string configFilePath = Path.Combine(appFolder, "config.cfg");

            string pinHash = Hasher.ComputeSHA512Hash(mtbPinCode.Text);

            using (StreamWriter writer = new StreamWriter(configFilePath))
            {
                writer.WriteLine("IsConfigured=True");
                writer.WriteLine($"PinHash={pinHash}");

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
