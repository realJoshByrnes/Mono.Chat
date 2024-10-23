using System.Diagnostics;

namespace Mono.Chat
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

            // Set the unhandled exception mode to catch all exceptions
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add a global exception handler for unhandled UI thread exceptions
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            
            Application.Run(new Form1());

        }

        // Global exception handler for unhandled UI thread exceptions
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Debug.WriteLine($"Unhandled UI Exception: {e.Exception.Message}\nStack Trace: {e.Exception.StackTrace}");
            MessageBox.Show($"An unhandled exception occurred: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}