using System;
using System.Web;
using MyNumberLib; // DLL NumberToWords Tiếng Việt

namespace WebApp
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                string num = Request.Form["number"];
                string result = "";
                bool success = false;

                try
                {
                    long number = long.Parse(num);
                    result = NumberToWords.Convert(number); // Gọi DLL
                    success = true;
                }
                catch
                {
                    result = "Số không hợp lệ!";
                }

                Response.ContentType = "application/json";
                string json = "{ \"words\": \"" + result.Replace("\"", "\\\"") + "\", \"success\": " + success.ToString().ToLower() + " }";
                Response.Write(json);
                Response.End();
            }
        }
    }
}
