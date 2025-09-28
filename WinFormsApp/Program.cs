using System;
using System.Windows.Forms;

namespace WinFormApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());   // Lỗi ở đây nếu không thấy Form1
        }
    }
}
