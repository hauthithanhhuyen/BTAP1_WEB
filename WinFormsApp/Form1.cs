using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button Click: chuyển số sang chữ
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long number = long.Parse(textBox1.Text.Trim());
                label1.Text = ConvertNumberToVietnamese(number);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        // -------------------------------
        // Hàm chuyển số sang chữ Tiếng Việt
        private string ConvertNumberToVietnamese(long number)
        {
            if (number == 0) return "Không";

            string[] dv = { "", "nghìn", "triệu", "tỷ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            string s = "";
            int dvIndex = 0;

            while (number > 0)
            {
                int block = (int)(number % 1000); // lấy 3 chữ số cuối
                string blockText = ReadBlock(block, cs);
                if (block > 0)
                {
                    s = blockText + (dvIndex > 0 ? " " + dv[dvIndex] + " " : " ") + s;
                }
                number /= 1000;
                dvIndex++;
            }

            return s.Trim();
        }

        private string ReadBlock(int number, string[] cs)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            string s = "";

            if (hundreds > 0)
            {
                s += cs[hundreds] + " trăm";
                if (tens == 0 && units > 0) s += " lẻ";
            }

            if (tens > 1)
            {
                s += " " + cs[tens] + " mươi";
                if (units == 1) s += " mốt";
                else if (units == 5) s += " lăm";
                else if (units > 0) s += " " + cs[units];
            }
            else if (tens == 1)
            {
                s += " mười";
                if (units == 1) s += " một";
                else if (units == 5) s += " lăm";
                else if (units > 1) s += " " + cs[units];
            }
            else if (tens == 0 && units > 0)
            {
                s += " " + cs[units];
            }

            return s.Trim();
        }
    }
}
