# BÀI LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN (HOTEL MANAGEMENT SYSTEM)

Hệ thống ứng dụng Windows Forms quản lý quy trình nghiệp vụ khách sạn từ danh mục cơ sở, tiện nghi, đặt phòng, nhận phòng, dịch vụ, đền bù hư hại, lập hóa đơn, thanh toán đa phương thức đến thống kê doanh thu.

---

## 📌 1. CÔNG NGHỆ SỬ DỤNG
* **Ngôn ngữ:** C# (.NET Framework 4.7.2)
* **Giao diện:** Windows Forms (WinForms) trên Visual Studio 2022
* **Cơ sở dữ liệu:** Microsoft SQL Server (SQL Server Express / LocalDB)
* **Truy xuất dữ liệu:** ADO.NET (Sử dụng `SqlParameter` chống SQL Injection, quản lý `Transaction` toàn vẹn dữ liệu)

---

## 🏛️ 2. KIẾN TRÚC VÀ CẤU TRÚC DỰ ÁN
Dự án được xây dựng theo kiến trúc phân tầng (Multi-layer Architecture) tách biệt giữa giao diện, logic xử lý và cơ sở dữ liệu:
> **WinForms UI (Forms) ➔ Service / Business Logic ➔ Data / Db ➔ SQL Server**

### Cấu trúc thư mục nguồn (`Solution Explorer`):
```text
QuanLyKhachSan/
│
├── App.config                    # Cấu hình chuỗi kết nối CSDL (Connection String)
├── Program.cs                    # Điểm khởi chạy ứng dụng (Khởi động FrmMain)
│
├── Data/
│   └── Db.cs                     # Lớp helper kết nối, thực thi Query/Execute/Scalar
│
├── Services/
│   ├── Models.cs                 # Các lớp thực thể trung gian (KetQuaXuLy, PhongDatItem, DenBuItem)
│   ├── DanhMucService.cs         # Nghiệp vụ quản lý danh mục nền
│   ├── PhongTienNghiService.cs   # Nghiệp vụ quản lý phòng, tiện nghi, lắp đặt
│   ├── DatPhongService.cs        # Nghiệp vụ đặt/nhận phòng, người lưu trú, no-show
│   ├── DichVuService.cs          # Nghiệp vụ ghi nhận và cộng dồn dịch vụ theo ngày
│   ├── TraPhongService.cs        # Nghiệp vụ đền bù, hóa đơn, thanh toán, trả phòng
│   └── ThongKeService.cs         # Nghiệp vụ tổng hợp doanh thu và dịch vụ
│
└── Forms/
    ├── FrmMain.cs                # Màn hình chính điều hướng chức năng
    ├── FrmDanhMuc.cs             # Quản lý Khu vực, Nhân viên, Loại TN, Dịch vụ, Mức đền bù
    ├── FrmPhongTienNghi.cs       # Quản lý Phòng, Thiết bị tiện nghi, Phiếu lắp đặt
    ├── FrmDatPhong.cs            # Quản lý Khách, Lập phiếu đặt, Nhận phòng, Đăng ký lưu trú
    ├── FrmDichVu.cs              # Ghi nhận phiếu sử dụng dịch vụ theo phòng/ngày
    ├── FrmTraPhong.cs            # Kiểm tra tài sản, Lập phiếu đền bù, Hóa đơn, Thanh toán
    └── FrmThongKe.cs             # Thống kê tổng hợp số liệu và tần suất dịch vụ
⚙️ 3. CÁC QUY TẮC NGHIỆP VỤ ĐÃ CÀI ĐẶT (BUSINESS RULES)Kiểm tra sức chứa & trùng lịch: Khi lập phiếu đặt phòng, hệ thống kiểm tra số người không vượt quá SoNguoiToiDa và khoảng thời gian NgayNhan - NgayTraDuKien không bị chồng lấn với các phiếu đang có trạng thái Đã đặt hoặc Đang ở.Luân chuyển tiện nghi: Ràng buộc UNIQUE(MaTienNghi, NgayLap) trên phiếu lắp đặt đảm bảo trong cùng một ngày, một thiết bị cụ thể chỉ có thể được lắp đặt tại một phòng duy nhất.Cộng dồn dịch vụ trong ngày: Gom nhóm dịch vụ theo UNIQUE(SoPhieuDat, SoPhong, NgaySuDung). Nếu một phòng dùng cùng một dịch vụ nhiều lần trong ngày, hệ thống sẽ tự động cộng dồn số lượng và cập nhật thành tiền.Quản lý đền bù: Kiểm tra tình trạng tiện nghi khi trả phòng; nếu hư hại/mất mát thì đối chiếu biểu phí cấu hình tại QuyDinhDenBu và xuất phiếu đền bù.Thanh toán linh hoạt & Toàn vẹn:Hỗ trợ 4 phương thức thanh toán: Tiền mặt, Chuyển khoản, Thẻ, Ví điện tử.Cho phép trả nhiều lần, hệ thống tự động kiểm tra tổng thanh toán không vượt quá tổng hóa đơn.Chỉ cho phép giải phóng phòng (trạng thái phòng chuyển sang Trống) khi hóa đơn đã được thanh toán đủ (Đã thanh toán).🚀 4. HƯỚNG DẪN CÀI ĐẶT & CHẠY ỨNG DỤNGBước 1: Khởi tạo Cơ sở Dữ liệuMở SQL Server Management Studio (SSMS) và đăng nhập vào SQL Server (Local / SQLEXPRESS).Tạo một truy vấn mới (New Query), mở file script QuanLyKhachSan.sql và nhấn Execute (F5) để tạo toàn bộ cơ sở dữ liệu, các bảng, ràng buộc và dữ liệu khởi tạo.Bước 2: Cấu hình chuỗi kết nối (App.config)Mở file App.config trong project Visual Studio và đảm bảo cấu hình kết nối khớp với máy của bạn:XML<connectionStrings>
  <add name="QuanLyKhachSanDB" 
       connectionString="Server=localhost\SQLEXPRESS;Database=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
(Nếu sử dụng LocalDB, thay đổi Server=localhost\SQLEXPRESS; thành Server=(localdb)\MSSQLLocalDB;).Bước 3: Build & Chạy chương trìnhMở solution QuanLyKhachSan.sln bằng Visual Studio 2022.Kiểm tra mục References: Đảm bảo đã có tham chiếu đến thư viện System.Configuration.Nhấn Ctrl + Shift + B để Build Solution.Nhấn F5 (hoặc nút Start) để khởi chạy giao diện FrmMain.🧪 5. BẢNG KIỂM THỬ NGHIỆP VỤ TIÊU BIỂU (TEST CASES)Mã TCNghiệp vụ kiểm traThao tác thực hiệnKết quả mong đợiTC01Đặt phòng hợp lệĐặt phòng trống, số người $\le$ sức chứaLập phiếu thành công, phòng chuyển sang Đã đặtTC02Vượt quá sức chứaNhập số người > SoNguoiToiDa của phòngHệ thống từ chối và thông báo lỗi vượt sức chứaTC03Trùng lịch đặt phòngĐặt trùng khoảng thời gian với phiếu khácHệ thống từ chối do trùng lịchTC04Trùng lắp đặt thiết bịGán 1 thiết bị cho 2 phòng trong cùng 1 ngàyHệ thống từ chối do vi phạm ràng buộc UniqueTC05Nhận phòngChọn phiếu Đã đặt -> Bấm "Nhận phòng"Chuyển trạng thái phiếu và phòng sang Đang ởTC07Cộng dồn dịch vụGhi cùng một dịch vụ 2 lần trong ngàyHệ thống không tạo dòng mới mà cộng dồn số lượngTC11Thanh toán 1 phầnThanh toán số tiền nhỏ hơn tổng hóa đơnHóa đơn giữ nguyên trạng thái Chưa thanh toánTC12Thanh toán đủThanh toán đủ 100% số tiền hóa đơnHóa đơn tự động cập nhật sang Đã thanh toánTC13Chặn trả phòngTrả phòng khi hóa đơn chưa thanh toán đủHệ thống chặn và từ chối hoàn tất trả phòngTC14Hoàn tất trả phòngTrả phòng khi đã thanh toán đủChuyển phiếu sang Đã trả, phòng trở về Trống
