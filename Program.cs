using System;
using System.Windows.Forms;

namespace DiceTool
{
    /// <summary>
    /// Main entry point class for the application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDiceTool());
        }
    }
}
