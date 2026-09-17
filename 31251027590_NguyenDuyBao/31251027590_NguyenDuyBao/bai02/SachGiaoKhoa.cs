using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai02
{
    internal class SachGiaoKhoa : Sach
    {
        private string? _tinhtrang;
        public string TinhTrang
        {
            get
            {
                if (_tinhtrang == null)
                {
                    return "Chua xac dinh";
                }
                return _tinhtrang;
            }
            set
            {
                if (value == "moi" || value == "cu")
                {
                    _tinhtrang = value;
                }
                else
                {
                    throw new ArgumentException("Tinh trang phai la 'moi' hoac 'cu'.");
                }
            }
        }
        public SachGiaoKhoa(string maSach, DateTime ngayNhap, decimal donGia, byte soLuong, string nhaXuatBan, string tinhtrang) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhtrang;
        }

        public decimal thanhTien()
        {
            if (_tinhtrang == "cu")
            {
                return DonGia * SoLuong * 0.5m;
            }
            return DonGia * SoLuong;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tinh trang: {TinhTrang}";
        }
    }
}
