# TRƯỜNG ĐẠI HỌC TÀI NGUYÊN VÀ MÔI TRƯỜNG
## KHOA CÔNG NGHỆ THÔNG TIN
### HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN BỆNH NHÂN (BỆNH VIỆN ĐA KHOA QUỐC TẾ)

---

## 1. TỔNG QUAN NGHIỆP VỤ
* **Đăng ký lần đầu:** Bệnh nhân điền phiếu đăng ký (họ tên, ngày sinh, SĐT, địa chỉ, ảnh 3x4) và đóng lệ phí hàng năm (1.500.000 VNĐ) để được cấp Hồ sơ bệnh án (HSBA) dùng trọn đời.
* **Khám bệnh & Kê toa:** Bác sĩ tra cứu mã HSBA xem lịch sử bệnh, đo sinh hiệu (thân nhiệt, huyết áp, nhức đầu...), chỉ định xét nghiệm cận lâm sàng (máu, ECG, X-quang) và kê toa thuốc điều trị (tự động cảnh báo dị ứng thuốc).
* **Khám định kỳ theo quý:** Bệnh nhân có HSBA được đặt hẹn khám sức khỏe 4 quý/năm hoàn toàn **MIỄN PHÍ** qua phòng Chăm sóc khách hàng (CSKH).
* **Xuất viện & Theo dõi thuốc:** Thanh toán viện phí (khám định kỳ miễn tiền khám) và phòng CSKH lưu trữ máy tính diễn biến bệnh, phản ứng phụ của thuốc để theo dõi lâu dài.

---

## 2. CẤU TRÚC DỰ ÁN WINFORMS & CSDL
* **Môi trường:** Visual Studio 2019/2022 (.NET Framework 4.8) + Microsoft SQL Server.
* **Kiến trúc:** Mô hình phân tầng (Models, Forms, DatabaseHelper ADO.NET).
* **Các màn hình giao diện (Forms):**
  * `FrmMain`: Bảng điều khiển trung tâm và thẻ thống kê số liệu.
  * `FrmDangKy_CapHSBA`: Đăng ký bệnh nhân mới, nộp lệ phí năm và cấp mã HSBA.
  * `FrmKhamBenh_KeToa`: Bác sĩ khám bệnh, xem tiền sử, chỉ định XN và kê toa thuốc.
  * `FrmXetNghiem`: Khoa xét nghiệm nhập chỉ số đo lường và kết luận bất thường.
  * `FrmLichHenDinhKy`: Đặt hẹn khám định kỳ quý miễn phí cho người có HSBA.
  * `FrmXuatVien_ThanhToan`: Quyết toán viện phí và CSKH theo dõi phản ứng phụ của thuốc.
* **Cơ sở dữ liệu:** Tệp `Database_Script.sql` tạo 14 bảng chuẩn hóa 3NF (`BENH_NHAN`, `HO_SO_BENH_AN`, `PHIEU_KHAM_BENH`, `TOA_THUOC`, `PHIEU_XET_NGHIEM`, `LICH_HEN_DINH_KY`...).

---

## 3. HƯỚNG DẪN CÀI ĐẶT & CHẠY ỨNG DỤNG
1. **Khởi tạo CSDL:** Mở SQL Server Management Studio (SSMS), mở tệp `Database_Script.sql` và nhấn **F5** để tạo CSDL `QL_BenhAn_QuocTe` cùng dữ liệu mẫu.
2. **Cấu hình:** Mở tệp `QuanLyBenhAn_WinForms.sln` bằng Visual Studio, kiểm tra `Data Source=.` trong `App.config`.
3. **Chạy chương trình:** Nhấn **F5** để khởi chạy. Hệ thống tích hợp sẵn chế độ Mock Data tự động, có thể demo ngay cả khi chưa bật SQL Server.

---
