using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai04
{
    internal abstract class Sach
    {
        private string maSach { get; set; }
        private DateTime ngayNhap { get; set; }
        private double donGia { get; set; }
        private int soLuong { get; set; }
        private string nhaXuatBan { get; set; }

        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }

        public string getMaSach()
        {
            return maSach;
        }
        public void setMaSach(string MaSach)
        {
            this.maSach = MaSach;
        }
        public DateTime getNgayNhap()
        {
            return ngayNhap;
        }
        public void setNgayNhap(DateTime NgayNhap)
        {
            this.ngayNhap = NgayNhap;
        }
        public double getDonGia()
        {
            return donGia;
        }
        public void setDonGia(double DonGia)
        {
            this.donGia = DonGia;
        }
        public int getSoLuong()
        {
            return soLuong;
        }
        public void setSoLuong(int SoLuong)
        {
            this.soLuong =  SoLuong;
        }
        public string getNhaXuatBan()
        {
            return nhaXuatBan;
        }
        public void setNhaXuatBan(string NhaXuatBan)
        {
            this.nhaXuatBan = NhaXuatBan;
        }
        public abstract double getThanhTien();
        public override string ToString()
        {
            return $"Ma sach: {this.maSach}. Ngay nhap: {this.ngayNhap}. Don gia: {this.donGia}. So luong: {this.soLuong}. Nha xuat ban: {this.nhaXuatBan}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return ((Sach)obj).getMaSach().Equals(this.getMaSach());
        }
        public override int GetHashCode()
        {
            return this.getMaSach().GetHashCode();
        }
    }
}
