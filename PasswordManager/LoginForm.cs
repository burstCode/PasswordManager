namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CodeEnterMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mtbCodeEnter.Text.Length == 4)
            {
                bool verified = VerifyPinCode(mtbCodeEnter.Text);

                if (verified)
                {
                    lblCodeEnter.Text = "Успешно!";
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    lblCodeEnter.Text = "Неправильно!";
                }
            }
            else
            {
                lblCodeEnter.Text = "Введите секретный код";
            }
        }

        private bool VerifyPinCode(string inputPin)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configFilePath = Path.Combine(appDataPath, "PasswordManager", "config.cfg");

            if (!File.Exists(configFilePath))
            {
                return false;
            }

            string savedPinHash = File.ReadAllLines(configFilePath)[1].Split('=')[1];
            string inputPinHash = Hasher.ComputeSHA512Hash(inputPin);

            return savedPinHash == inputPinHash;
        }
    }
}
