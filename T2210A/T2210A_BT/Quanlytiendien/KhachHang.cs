using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_BT.Quanlytiendien
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayRaHoaDon { get; set; }
        public string DoiTuongKhachHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public KhachHang(string maKhachHang, string hoTen, DateTime ngayRaHoaDon, string doiTuongKhachHang, int soLuong, decimal donGia)
        {
            MaKhachHang = maKhachHang;
            HoTen = hoTen;
            NgayRaHoaDon = ngayRaHoaDon;
            DoiTuongKhachHang = doiTuongKhachHang;
            SoLuong = soLuong;
            DonGia = donGia;
            TinhThanhTien();
        }

        public void TinhThanhTien()
        {
            if (SoLuong <= 50)
            {
                ThanhTien = SoLuong * DonGia;
            }
            else
            {
                ThanhTien = DonGia * 50 + (SoLuong - 50) * DonGiaMoi;
            }
        }
        private decimal DonGiaMoi
        {
            get
            {
                if (DoiTuongKhachHang == "Sinh hoat")
                {
                    return 1000;
                }
                else if (DoiTuongKhachHang == "Kinh doanh")
                {
                    return 1200;
                }
                else if (DoiTuongKhachHang == "San xuat")
                {
                    return 1500;
                }
                else
                {
                    return 2000;
                }
            }
        }
    }
}








         