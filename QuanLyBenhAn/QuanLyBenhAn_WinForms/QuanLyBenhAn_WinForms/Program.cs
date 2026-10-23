using System;
using System.Windows.Forms;
using QuanLyBenhAn_WinForms.Forms;

namespace QuanLyBenhAn_WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}