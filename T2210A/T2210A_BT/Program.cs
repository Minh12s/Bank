using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2210A_BT.Quanlytiendien;

namespace T2210A_BT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo danh sách khách hàng
            List<KhachHang> khachHangs = new List<KhachHang>();

            // Thêm khách hàng Việt Nam
            khachHangs.Add(new KhachHang("KH001", "Nguyen Van A", DateTime.Now, "Sinh hoat", 100, 1000));
            khachHangs.Add(new KhachHang("KH002", "Tran Thi B", DateTime.Now, "Kinh doanh", 200, 1200));
            khachHangs.Add(new KhachHang("KH003", "Le Quang C", DateTime.Now, "San xuat", 300, 1500));

            // Thêm khách hàng nước ngoài
            khachHangs.Add(new KhachHang("KH004", "John Doe", DateTime.Now, "My", 100, 2000));
            khachHangs.Add(new KhachHang("KH005", "Jane Doe", DateTime.Now, "Canada", 200, 2000));
            khachHangs.Add(new KhachHang("KH006", "Peter Smith", DateTime.Now, "Anh", 300, 2000));

            // In danh sách khách hàng và tổng tiền hóa đơn
            foreach (var khachHang in khachHangs)
            {
                Console.WriteLine("Mã khách hàng: {0}", khachHang.MaKhachHang);
                Console.WriteLine("Ho ten: {0}", khachHang.HoTen);
                Console.WriteLine("Ngay ra hoa đon: {0}", khachHang.NgayRaHoaDon);
                Console.WriteLine("Đoi tuong khach hang: {0}", khachHang.DoiTuongKhachHang);
                Console.WriteLine("So luong: {0}", khachHang.SoLuong);
                Console.WriteLine("Đan gia: {0}", khachHang.DonGia);
                Console.WriteLine("Thanh tien: {0}", khachHang.ThanhTien);
                Console.WriteLine();
            }
        }
    }
}

