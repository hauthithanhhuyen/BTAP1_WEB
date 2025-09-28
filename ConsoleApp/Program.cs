using System;
using MyNumberLib;   // Add Reference tới MyNumberLib.dll

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bộ chuyển đổi số thành chữ Tiếng Việt ===");
            Console.Write("Nhập số: ");
            long so = long.Parse(Console.ReadLine());

            string ketQua = NumberToVietnamese.DocSo(so);
            Console.WriteLine("Kết quả: " + ketQua);

            Console.WriteLine("\nNhấn Enter để thoát...");
            Console.ReadLine();
        }
    }
}
