# BTAP1_WEB
Hầu Thị Thanh Huyền
DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE

Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
# BÀI LÀM

# 1.Tải ứng dụng virual code studio 2022
B1.Tạo projcet tìm kiếm đặt tên MyNumber ấn next.Chỉ chứa class, method, logic xử lý, không có giao diện.

<img width="1112" height="244" alt="{DF0057BD-B4E4-47D8-A51C-DDE728DD19F6}" src="https://github.com/user-attachments/assets/5c6b0321-a8a5-405f-804e-43d6cdcfb52c" />

B2.tìm Console App (.NET Framework 2.0) đặt tên ConsoleApp.ấn next.( chạy trên cửa sổ Command Prompt (đen trắng).Dùng để test nhanh cách gọi DLL.

<img width="1059" height="225" alt="{1395F431-B857-40EA-9C26-DC2587009B70}" src="https://github.com/user-attachments/assets/87b472bd-8bb5-43bf-9721-34d856c82eb5" />

B3.Tìm Windows Forms App (.NET Framework 2.0):tên là WinForm.(Ứng dụng có giao diện desktop (form, textbox, button, label). Có thể kéo-thả control rồi viết code gọi DLL để xử lý.

<img width="696" height="268" alt="{7F931538-888C-4AC6-B87A-2F6D8E70128D}" src="https://github.com/user-attachments/assets/fc503d9f-47b1-498f-bab9-20833815ea34" />

B4.Tìm ASP.NET Web Application (.NET Framework 2.0) tên là WebApp:(Ứng dụng web chạy trên IIS/localhost.)

<img width="835" height="291" alt="{B5F80A45-DE08-4CA0-B55B-D51C9D068F7B}" src="https://github.com/user-attachments/assets/2c1ddd43-4132-44da-b57c-3b4f0dc944ad" />

# Đây là ảnh khi tạo xong 

<img width="700" height="794" alt="{80F4AE48-998B-43A6-99D6-6A968E839361}" src="https://github.com/user-attachments/assets/0797d7fa-ed37-49c3-bcab-7b1306cef131" />

# 2.Đi vào bài
## Bộ chuyển đổi số thành chữ Tiếng Việt
# Console App (.NET Framework
1.Nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE

<img width="1173" height="407" alt="{C658DD92-8732-4AF8-ABAB-9717043E7E5C}" src="https://github.com/user-attachments/assets/8034cc65-b633-44c9-a439-63b73062ba0e" />
2.Kết quả

<img width="1438" height="534" alt="{5569D19B-37FF-4749-9B07-D44E33708581}" src="https://github.com/user-attachments/assets/bbb67830-ad13-4127-a1a1-b246db2c3f5a" />

# MyNumberLib 
<img width="851" height="270" alt="{02BA1FCE-BEC0-44D9-9774-E75F9072427E}" src="https://github.com/user-attachments/assets/0e3ceda3-3f0d-4788-99a3-7396eac4d243" />

#  WebApp



