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
    public partial class EditPasswordForm : Form
    {
        private PasswordRecord _record;

        // Свойство для получения информации из MainForm
        public PasswordRecord Record => _record;

        public EditPasswordForm(PasswordRecord record)
        {
            InitializeComponent();
            
            tbEnterService.Text = record.Service;
            tbEnterLogin.Text = record.Login;
            tbEnterPassword.Text = record.Password;
        }

        // Удобное пользование клавиатурой на Enter и Escape
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnConfirm.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                btnCancel.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbEnterService.Text.Any() && tbEnterLogin.Text.Any() && tbEnterPassword.Text.Any())
            {
                _record = new PasswordRecord(
                    tbEnterService.Text,
                    tbEnterLogin.Text,
                    tbEnterPassword.Text);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Все поля должны быть заполнены!",
                    "Неудача",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
