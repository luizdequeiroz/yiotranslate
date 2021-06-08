using System;
using System.Windows.Forms;

namespace YioTranslate
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var database = new Database();
            database.Init();
            
            Application.Run(new YioTranslate());
        }
    }
}
