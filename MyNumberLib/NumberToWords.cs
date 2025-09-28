using System;

namespace MyNumberLib
{
    public class NumberToWords
    {
        private static string[] units = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static string[] teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm",
                                          "mười sáu", "mười bảy", "mười tám", "mười chín" };
        private static string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi",
                                        "bảy mươi", "tám mươi", "chín mươi" };

        public static string Convert(long number)
        {
            if (number == 0) return units[0];
            if (number < 0) return "âm " + Convert(-number);

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += Convert(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Convert(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Convert(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "") words += "lẻ ";

                if (number < 10) words += units[number];
                else if (number < 20) words += teens[number - 10];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        if ((number % 10) == 5) words += " lăm";
                        else words += " " + units[number % 10];
                    }
                }
            }

            return words.Trim();
        }
    }
}
