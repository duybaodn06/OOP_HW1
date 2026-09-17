using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai04
{
    internal class SachGiaoKhoa : Sach
    {
        private bool tinhTrang;

        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, bool tinhTrang) : base (maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }
        public SachGiaoKhoa() : this("N/A", DateTime.Now, 0, 0 , "N/A", false) { }
        public bool getTinhTrang()
        {
            return tinhTrang;
        }
        public void setTinhTrang(bool TinhTrang)
        {
            this.tinhTrang = TinhTrang;
        }
        public override double getThanhTien()
        {
            if (!tinhTrang)
            {
                return (double)(getDonGia() * getSoLuong() * 0.5);
            }
            return (double)(getDonGia() * getSoLuong());
        }
        public override string ToString()
        {
            string TinhTrang = (this.tinhTrang ? "Moi" : "Cu"); 
            return base.ToString() + $"Tinh trang: {TinhTrang}";
        }
    }
}
