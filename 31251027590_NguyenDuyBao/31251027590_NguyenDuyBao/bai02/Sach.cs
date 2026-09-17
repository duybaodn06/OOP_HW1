using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai02
{
    internal class Sach
    {
        public string MaSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal DonGia { get; set; }
        public byte SoLuong { get; set; }
        public string NhaXuatBan { get; set; }

        public Sach(string maSach, DateTime ngayNhap, decimal donGia, byte soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }

        public override string ToString()
        {
            return $"Ma sach: {MaSach}, Ngay nhap: {NgayNhap.ToShortDateString()}, Don gia: {DonGia}, So luong: {SoLuong}, Nha xuat ban: {NhaXuatBan}";
        }   
    }
}
