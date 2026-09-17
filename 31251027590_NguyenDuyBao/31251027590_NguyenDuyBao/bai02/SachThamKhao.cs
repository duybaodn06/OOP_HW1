using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai02
{
    internal class SachThamKhao : Sach
    {
        public decimal Thue { get; set; }

        public SachThamKhao(string maSach, DateTime ngayNhap, decimal donGia, byte soLuong, string nhaXuatBan, decimal thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public decimal thanhTien()
        {
            return DonGia * SoLuong + Thue;
        }
        public override string ToString()
        {
            return base.ToString() + $", Thue: {Thue}";
        }
    }
}
