using System;

namespace MyNumberLib
{
    public class NumberToWords
    {
        static string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        public static string Convert(long number)
        {
            if (number == 0) return "Không";
            if (number < 0) return "Âm " + Convert(-number);

            string s = "";
            long mod1000 = number % 1000;
            long rest = number / 1000;

            if (rest > 0)
            {
                s = Convert(rest) + " nghìn ";
            }

            int hundreds = (int)(mod1000 / 100);
            int tens = (int)((mod1000 % 100) / 10);
            int units = (int)(mod1000 % 10);

            if (hundreds > 0) s += cs[hundreds] + " trăm ";
            if (tens > 1) s += cs[tens] + " mươi ";
            else if (tens == 1) s += "mười ";
            if (units > 0) s += cs[units] + " ";

            return s.Trim();
        }
    }
}
