# BÀI LAB 3 - HỆ THỐNG QUẢN LÝ KHÁCH SẠN

Ứng dụng Windows Forms quản lý quy trình nghiệp vụ khách sạn theo mô hình phân lớp (Multi-layer Architecture).

---

## 1. CÔNG NGHỆ SỬ DỤNG
- **Ngôn ngữ:** C# (.NET Framework 4.7.2)
- **Giao diện:** Windows Forms (Visual Studio 2022)
- **Cơ sở dữ liệu:** Microsoft SQL Server (LocalDB / SQLEXPRESS)
- **Truy xuất dữ liệu:** ADO.NET, Parameterized Query, Transaction

---

## 2. CẤU TRÚC THƯ MỤC DỰ ÁN
- **Data/Db.cs**: Kết nối CSDL và các hàm tiện ích (`Query`, `Execute`, `Scalar`).
- **Services/**: Xử lý logic và nghiệp vụ:
  - `Models.cs`: Các lớp đối tượng hỗ trợ (`KetQuaXuLy`, `PhongDatItem`, `DenBuItem`).
  - `DanhMucService.cs`: Nghiệp vụ Khu vực, Nhân viên, Tiện nghi, Dịch vụ, Đền bù.
  - `PhongTienNghiService.cs`: Nghiệp vụ quản lý Phòng, Tiện nghi, Lắp đặt.
  - `DatPhongService.cs`: Nghiệp vụ Khách hàng, Đặt phòng, Nhận phòng, No-show.
  - `DichVuService.cs`: Nghiệp vụ ghi nhận và cộng dồn dịch vụ theo ngày.
  - `TraPhongService.cs`: Nghiệp vụ Phiếu đền bù, Hóa đơn, Thanh toán, Trả phòng.
  - `ThongKeService.cs`: Thống kê tổng hợp số liệu và dịch vụ.
- **Forms/**: Giao diện người dùng:
  - `FrmMain`: Màn hình điều hướng chính.
  - `FrmDanhMuc`: Quản lý danh mục dữ liệu nền.
  - `FrmPhongTienNghi`: Quản lý phòng, thiết bị và phiếu lắp đặt.
  - `FrmDatPhong`: Quản lý thông tin đặt phòng, người lưu trú.
  - `FrmDichVu`: Ghi nhận sử dụng dịch vụ.
  - `FrmTraPhong`: Kiểm tra tài sản, hóa đơn, thanh toán và hoàn tất trả phòng.
  - `FrmThongKe`: Báo cáo thống kê doanh thu và dịch vụ.
- **App.config**: Lưu trữ chuỗi kết nối `QuanLyKhachSanDB`.

---

## 3. CÁC QUY TẮC NGHIỆP VỤ ĐÃ CÀI ĐẶT
1. **Kiểm tra sức chứa & trùng lịch:** Đặt phòng kiểm tra số người không vượt quá sức chứa tối đa và không trùng khoảng ngày với các phiếu đang hoạt động.
2. **Quản lý tiện nghi:** Một thiết bị chỉ được lắp đặt cho một phòng duy nhất trong một ngày (`UNIQUE(MaTienNghi, NgayLap)`).
3. **Cộng dồn dịch vụ:** Khách dùng cùng một dịch vụ nhiều lần trong ngày sẽ được tự động cộng dồn số lượng vào cùng một phiếu.
4. **Đền bù hư hại:** Kiểm tra tình trạng tiện nghi khi trả phòng, lập phiếu đền bù theo biểu phí quy định nếu có hư hại/mất mát.
5. **Thanh toán & Trả phòng:** Hỗ trợ 4 hình thức (Tiền mặt, Chuyển khoản, Thẻ, Ví điện tử). Hóa đơn phải thanh toán đủ 100% mới cho phép hoàn tất trả phòng và chuyển trạng thái phòng sang "Trống".

---

## 4. HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY
1. **Tạo CSDL:** Mở SQL Server Management Studio (SSMS), mở file `Database/QuanLyKhachSan.sql` và bấm **Execute (F5)**.
2. **Cấu hình chuỗi kết nối:** Mở file `App.config` trong Visual Studio, kiểm tra mục `connectionStrings` trỏ đúng về SQL Server của máy:
   ```xml
   <connectionStrings>
     <add name="QuanLyKhachSanDB" 
          connectionString="Server=localhost\SQLEXPRESS;Database=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True;" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
