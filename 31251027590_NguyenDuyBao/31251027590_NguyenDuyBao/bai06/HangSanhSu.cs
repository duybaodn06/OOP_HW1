using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai06
{
    internal class HangSanhSu : HangHoa
    {
        private DateTime _ngaynhapkho;
        public string nhaSanXuat {  get; set; }
        public DateTime ngayNhapKho { get { return _ngaynhapkho; } 
            set
            {
                if (value > DateTime.Now) throw new ArgumentNullException("Must be before this now");
                try
                {
                    this._ngaynhapkho = value;
                }catch(Exception ex)
                {
                    this._ngaynhapkho = DateTime.Now;
                    //Console.WriteLine(ex.Message);
                }

            }
        }
        public HangSanhSu(string MaHang, string TenHang, decimal DonGia, int SoLuongTon, string nhaSanXuat, DateTime ngayNhapKho) : base(MaHang, TenHang, DonGia, SoLuongTon)
        {
            this.nhaSanXuat = nhaSanXuat;
            this.ngayNhapKho = ngayNhapKho;
        }
        public override string danhGia()
        {
            if (this.soLuongTon > 50 && ((DateTime.Now - this.ngayNhapKho).TotalDays > 10)) return "Ban cham";
            return "Khong danh gia";
        }
        public override decimal VAT()
        {
            return 0.1m * this.donGia;
        }
        public override string ToString()
        {
            return base.ToString() + $"Nha san xuat: {nhaSanXuat}. Ngay nhap kho: {ngayNhapKho}";
        }
    }
}
