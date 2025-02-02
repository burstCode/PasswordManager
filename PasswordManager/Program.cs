namespace PasswordManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderPath = Path.Combine(appDataPath, "PasswordManager");
            string configFilePath = Path.Combine(folderPath, "config.cfg");

            // Первоначальная настройка
            if (!File.Exists(configFilePath))
            {
                FirstRunSetupForm setupForm = new FirstRunSetupForm();
                if (setupForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            // Запуск основного приложения
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
