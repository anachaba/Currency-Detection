using System.Windows.Forms.VisualStyles;

namespace Currency_Detection
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.VisualStyleState = VisualStyleState.NoneEnabled;
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}