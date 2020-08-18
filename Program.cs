using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinForms
{
    static class Program
    {
        /// <summary> sum
        /// The main entry point for the application.
        /// </summary> sum
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HOME());
        }
    }
}
//
