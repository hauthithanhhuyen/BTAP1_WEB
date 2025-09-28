<%@ Page Language="C#" AutoEventWireup="true" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json";
        string numberStr = Request.Form["number"];
        long num;
        if (long.TryParse(numberStr, out num))
        {
            string text = ConvertNumberToWords(num);
            Response.Write("{\"success\":true, \"text\":\"" + text + "\"}");
        }
        else
        {
            Response.Write("{\"success\":false, \"message\":\"Số không hợp lệ\"}");
        }
    }

    private string ConvertNumberToWords(long number)
    {
        // TODO: Viết hàm chuyển số thành chữ tiếng Việt
        return number.ToString(); // Tạm thời trả lại số
    }
</script>
