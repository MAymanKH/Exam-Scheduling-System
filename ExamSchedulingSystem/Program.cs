namespace ExamSchedulingSystem
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
            while (true)
            {
                using var login = new log_in_form();
                if (login.ShowDialog() != DialogResult.OK) return;
                using var main = new frmMain();
                Application.Run(main);
                if (!main.LogoutRequested) return;
            }
        }
    }
}