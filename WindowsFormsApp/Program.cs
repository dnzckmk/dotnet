using ClassLibrary;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run Greet form with arguments
            if(args.Length > 0 ) {
                Application.Run(new Greet(args));
            }
            else {
                Application.Run(new Greet(new string[0]));
            }
        }
    }
}
