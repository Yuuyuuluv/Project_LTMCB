using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPaint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GDC gdc = new GDC();
            Application.Run(gdc);
            if(gdc.DialogResult == DialogResult.OK)
            {
                GDMain gdMain = new GDMain();
                gdMain.clientSocket = gdc.clientSocket;
                gdMain.strName = gdc.strName;
                gdMain.ShowDialog();
            }
        }
    }
}
