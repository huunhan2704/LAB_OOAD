# HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN BỆNH NHÂN
## BỆNH VIỆN ĐA KHOA QUỐC TẾ (C# WINFORMS + SQL SERVER)
### Đại học Công nghệ TP.HCM (HUTECH) - Thực hành Phân tích Thiết kế Hướng đối tượng (Bài 5)

---

### 1. Giới thiệu dự án
Dự án được xây dựng hoàn chỉnh bằng ngôn ngữ **C# Windows Forms (.NET Framework 4.8)** và cơ sở dữ liệu **Microsoft SQL Server**, mô hình hóa đầy đủ các quy tắc nghiệp vụ trong đề bài HUTECH:
- **Đăng ký lần đầu & Lệ phí hàng năm:** Bệnh nhân lần đầu được cấp Phiếu đăng ký (Họ tên, ngày sinh, địa chỉ, SĐT, ảnh 3x4). Đóng lệ phí 1 năm để được cấp phát Hồ sơ bệnh án (HSBA).
- **Hồ sơ bệnh án dùng chung trọn đời:** Trang bìa ghi rõ Mã hồ sơ định danh và ảnh 3x4. Các trang sau ghi nhận chi tiết các đợt khám bệnh (triệu chứng, chẩn đoán, bác sĩ, khoa phòng, toa thuốc, xét nghiệm).
- **Tái khám & Tra cứu nhanh:** Báo mã hồ sơ hoặc thông tin tìm kiếm, bác sĩ trích xuất ngay lý lịch bệnh án và tiền sử bệnh.
- **Quyền lợi Khám sức khỏe định kỳ theo quý miễn phí:** Khách hàng có HSBA được đặt hẹn ngày giờ khám định kỳ miễn phí theo 4 quý trong năm qua phòng CSKH.
- **Xuất viện, Viện phí & Theo dõi thuốc:** Phòng CSKH ghi nhận lại toàn bộ thông tin đợt điều trị vào máy tính sau khi xuất viện và thanh toán viện phí để theo dõi diễn biến bệnh, phản ứng phụ của thuốc, hiệu quả điều trị và trách nhiệm chuyên môn của bác sĩ.

---

### 2. Cấu trúc Solution
```
QuanLyBenhAn_WinForms/
├── QuanLyBenhAn_WinForms.sln               # Solution Visual Studio 2019/2022
├── Database_Script.sql                     # Kịch bản T-SQL tạo CSDL 3NF 14 bảng & Seed Data
└── QuanLyBenhAn_WinForms/
    ├── QuanLyBenhAn_WinForms.csproj        # Project WinForms C#
    ├── App.config                          # Chuỗi kết nối CSDL SQL Server (ConnectionString)
    ├── Program.cs                          # Điểm khởi chạy ứng dụng
    ├── DatabaseHelper.cs                   # Lớp tiện ích ADO.NET kết nối & thực thi truy vấn SQL
    ├── Models/                             # Các thực thể dữ liệu (Data Transfer Objects)
    │   ├── BenhNhan.cs
    │   ├── HoSoBenhAn.cs
    │   ├── PhieuKhamBenh.cs
    │   └── ToaThuoc.cs
    └── Forms/                              # Giao diện & Mã xử lý nghiệp vụ WinForms
        ├── FrmMain.cs / Designer.cs        # Dashboard & Điều hướng trung tâm
        ├── FrmDangKy_CapHSBA.cs / Desig... # Đăng ký BN mới, nộp lệ phí năm, cấp mã HSBA
        ├── FrmKhamBenh_KeToa.cs / Desig... # Tra cứu bệnh án, đo sinh hiệu, chỉ định XN, kê toa
        ├── FrmXetNghiem.cs / Designer.cs   # Kỹ thuật viên nhập kết quả & chỉ số đo lường XN
        ├── FrmLichHenDinhKy.cs / Desig...  # Đặt hẹn khám định kỳ theo quý miễn phí
        └── FrmXuatVien_ThanhToan.cs / Des  # Viện phí, xuất viện & CSKH theo dõi phản ứng thuốc
```

---

### 3. Hướng dẫn cài đặt và chạy ứng dụng

#### Bước 1: Khởi tạo Cơ sở Dữ liệu SQL Server
1. Mở **SQL Server Management Studio (SSMS)**.
2. Mở tệp `Database_Script.sql`.
3. Nhấn **Execute (F5)** để tự động tạo cơ sở dữ liệu `QL_BenhAn_QuocTe` cùng 14 bảng chuẩn 3NF và dữ liệu mẫu ban đầu.

#### Bước 2: Mở và cấu hình Project trên Visual Studio
1. Mở tệp Solution `QuanLyBenhAn_WinForms.sln` bằng **Visual Studio 2019** hoặc **Visual Studio 2022**.
2. Kiểm tra chuỗi kết nối trong tệp `App.config`:
   ```xml
   <connectionStrings>
     <add name="BenhAnQuocTeDB" 
          connectionString="Data Source=.;Initial Catalog=QL_BenhAn_QuocTe;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

#### Bước 3: Biên dịch và chạy ứng dụng
1. Nhấn **Build Solution (Ctrl + Shift + B)**.
2. Nhấn **Start (F5)** để khởi chạy ứng dụng.
3. Ứng dụng đã được tích hợp chế độ chạy thử nghiệm độc lập (mock data) ngay cả khi máy tính chưa bật SQL Server, đảm bảo có thể demo trực quan ngay lập tức.