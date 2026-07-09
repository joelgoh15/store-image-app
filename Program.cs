using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_store_image4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// Set DataDirectory to point to your solution's App_Data folder
            //string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            //string dataDir = Path.Combine(baseDir, @"..\..\App_Data");
            //AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formDisplayImage());
            
        }
    }
}
