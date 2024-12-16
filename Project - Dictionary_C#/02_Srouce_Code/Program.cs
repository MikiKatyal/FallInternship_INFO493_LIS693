using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CF_CHash_Dictionary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 objForm1;
            objForm1 = new Form1();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            objForm1.Form_Initialize();
            objForm1.Show();

            Application.Run();

            //Application.Run(new Form1());
        }
    }
}
