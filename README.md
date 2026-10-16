# HỆ THỐNG PHẦN MỀM QUẢN LÝ TOUR DU LỊCH & ĐĂNG KÝ TOUR
## CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM (C# WINFORMS + SQL SERVER)

---

### 1. Giới thiệu dự án
Dự án được xây dựng hoàn chỉnh bằng ngôn ngữ **C# Windows Forms (.NET Framework 4.8)** và cơ sở dữ liệu **Microsoft SQL Server**, bám sát 100% yêu cầu nghiệp vụ trong đề bài của Công ty Du lịch Văn Hóa Việt TP.HCM:
- **Tất cả các tour đều xuất phát từ TP.HCM**.
- Phân biệt rõ ràng 2 luồng đối tượng khách hàng:
  1. **Khách theo đoàn (> 12 người):** Tự chọn ngày đi, cơ quan/người đại diện, đón tận nơi theo yêu cầu, danh sách mua bảo hiểm, bắt buộc đặt cọc trước (không đi mất cọc), quyết toán kinh phí sau khi kết thúc chuyến đi.
  2. **Khách lẻ (<= 12 người):** Đăng ký theo chuyến cố định có ngày đi/về theo lịch công ty, chọn điểm bán vé gần nơi ở, đón tại các điểm đón quy định của công ty, thanh toán 100% tiền vé ngay khi mua.
- **Điều hành & Phân công HDV:** Thuật toán tự động kiểm tra chống trùng chéo lịch công tác của HDV. Phân công 1 HDV cụ thể cho chuyến lẻ, nhiều HDV cho đoàn đông (>30 khách).
- **Quyết toán & Tính lương HDV:** Lương HDV = Lương căn bản + Thù lao các tour thực hiện trong tháng. Phiếu khảo sát chất lượng dịch vụ (nơi ăn, nơi ở 2-5 sao, phương tiện, thái độ HDV).

---

### 2. Cấu trúc Solution & Mã nguồn WinForms
```
QuanLyTour_VanHoaViet/
├── QuanLyTour_VanHoaViet.sln               # Solution Visual Studio 2019/2022
├── Database_Script.sql                     # Kịch bản T-SQL tạo CSDL 3NF 16 bảng & Dữ liệu mẫu
└── QuanLyTour_VanHoaViet/
    ├── QuanLyTour_VanHoaViet.csproj        # Project WinForms C#
    ├── App.config                          # Chuỗi kết nối CSDL SQL Server (ConnectionString)
    ├── Program.cs                          # Điểm khởi chạy ứng dụng
    ├── DatabaseHelper.cs                   # Lớp tiện ích ADO.NET kết nối & thực thi truy vấn SQL
    ├── Models/                             # Các thực thể dữ liệu (Data Transfer Objects)
    │   ├── Tour.cs
    │   ├── PhieuDangKyDoan.cs
    │   ├── VeKhachLe.cs
    │   ├── HuongDanVien.cs
    │   └── PhanCong.cs
    └── Forms/                              # Giao diện & Mã xử lý nghiệp vụ WinForms
        ├── FrmMain.cs / Designer.cs        # Dashboard & Điều hướng trung tâm
        ├── FrmQuanLyTour.cs / Designer.cs  # Quản lý Tour, nơi dừng chân, điểm tham quan
        ├── FrmDangKyTourDoan.cs / Desig... # Phiếu đăng ký đoàn > 12 người, tính cọc, bảo hiểm
        ├── FrmBanVeKhachLe.cs / Designer   # Bán vé khách lẻ theo chuyến, điểm bán & điểm đón QĐ
        ├── FrmDieuHanhPhanCong.cs / Desig  # Phân công HDV, kiểm tra trùng lịch, bố trí xe
        └── FrmQuyetToanLuong.cs / Desig... # Quyết toán đoàn, phiếu khảo sát, tính lương HDV
```

---

### 3. Hướng dẫn cài đặt và chạy ứng dụng

#### Bước 1: Khởi tạo Cơ sở Dữ liệu SQL Server
1. Mở **SQL Server Management Studio (SSMS)**.
2. Mở tệp `Database_Script.sql`.
3. Nhấn **Execute (F5)** để tự động tạo cơ sở dữ liệu `QL_DuLich_VanHoaViet` cùng 16 bảng chuẩn 3NF và dữ liệu mẫu ban đầu.

#### Bước 2: Mở và cấu hình Project trên Visual Studio
1. Mở tệp Solution `QuanLyTour_VanHoaViet.sln` bằng **Visual Studio 2019** hoặc **Visual Studio 2022**.
2. Kiểm tra chuỗi kết nối trong tệp `App.config`:
   ```xml
   <connectionStrings>
     <add name="VanHoaVietDB" 
          connectionString="Data Source=.;Initial Catalog=QL_DuLich_VanHoaViet;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
   *(Thay đổi `Data Source=.` thành tên Server SQL Server trên máy tính của bạn nếu cần).*

#### Bước 3: Biên dịch và chạy ứng dụng
1. Nhấn **Build Solution (Ctrl + Shift + B)**.
2. Nhấn **Start (F5)** để khởi chạy ứng dụng.
3. Ứng dụng đã được tích hợp chế độ chạy thử nghiệm độc lập (mock data) ngay cả khi máy tính chưa bật SQL Server, đảm bảo có thể demo ngay lập tức.
