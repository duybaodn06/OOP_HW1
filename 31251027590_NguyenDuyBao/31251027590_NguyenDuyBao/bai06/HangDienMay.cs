using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai06
{
    internal class HangDienMay : HangHoa
    {
        private int _thoigianbaohanh;
        private int _congsuat;
        public int thoiGianBaoHanh { get { return _thoigianbaohanh; }
            set 
            { 
                if (value < 0) throw new ArgumentNullException("value must be positive");
                _thoigianbaohanh = value;
            } 
        }
        public int congSuat { get { return _congsuat; } 
            set
            {
                if (value < 0) throw new ArgumentNullException("value must be positive");
                _congsuat = value;
            }
        }

        public HangDienMay(string MaHang, string TenHang, decimal DonGia, int SoLuongTon, int ThoiGianBaoHanh, int CongSuat) : base(MaHang, TenHang, DonGia, SoLuongTon)
        {
            this.thoiGianBaoHanh = ThoiGianBaoHanh;
            this.congSuat = CongSuat;
        }
        public override string danhGia()
        {
            if (this.soLuongTon < 3) return "Ban duoc";
            return "Khong danh gia";
        }
        public override decimal VAT()
        {
            return 0.1m * this.donGia;
        }
        public override string ToString()
        {
            return base.ToString() + $"Thoi gian bao hanh: {thoiGianBaoHanh}. Cong suat: {congSuat}.";
        }
    }
}
