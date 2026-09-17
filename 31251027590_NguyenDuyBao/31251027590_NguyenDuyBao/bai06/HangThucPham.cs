using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai06
{
    internal class HangThucPham : HangHoa
    {
        // backing fields
        private DateTime _ngaysanxuat;
        private DateTime _ngayhethan;

        //get set for fields
        public string nhaCungCap { get; set; }
        public DateTime ngaySanXuat { get { return _ngaysanxuat; } 
            set 
            {
                if (value <= DateTime.Now) _ngaysanxuat = value;
                else _ngaysanxuat = DateTime.Now;
            }  
        }
        public DateTime ngayHetHan { get { return _ngayhethan; }
            set
            {
                if (value >= _ngaysanxuat) _ngayhethan = value;
                else _ngayhethan = _ngaysanxuat;
            }
        }
        public HangThucPham(string MaHang, string TenHang, decimal DonGia, int SoLuongTon, string NCC, DateTime ngaySanXuat, DateTime ngayHetHan) : base ( MaHang, TenHang, DonGia, SoLuongTon)
        {
            this.nhaCungCap = NCC;
            this.ngaySanXuat = ngaySanXuat;
            this.ngayHetHan = ngayHetHan ;
        }
        public override string danhGia()
        {
            if (this.soLuongTon > 0 && this.ngayHetHan < DateTime.Now) return "Kho ban";
            return "Khong danh gia";
        }
        public override decimal VAT()
        {
            return 0.05m * this.donGia;
        }
        public override string ToString()
        {
            return base.ToString() + $"Nha cung cap: {nhaCungCap}. Ngay san xuat: {ngaySanXuat}. Ngay het han: {ngayHetHan}";
        }
    }
}
