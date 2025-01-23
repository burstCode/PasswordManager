namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        // TODO: Подтягивать код из базы данных
        readonly int _code = 1234;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void CodeEnterMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mtbCodeEnter.Text.Length == 4)
            {
                if (int.Parse(mtbCodeEnter.Text) == _code)
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
    }
}
