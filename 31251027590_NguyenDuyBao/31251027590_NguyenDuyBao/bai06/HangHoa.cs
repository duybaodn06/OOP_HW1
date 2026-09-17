using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai06
{
    internal abstract class HangHoa
    {
        private string _mahang;
        private string _tenhang;
        private decimal _dongia;
        private int _soluongton;
        public string maHang { 
            get 
            {
                return _mahang;
            }
            init
            {
                if (value is null)
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                else _mahang = value;
            }
        }
        public string tenHang { get { return _tenhang; } 
            set
            {
                if (value is null) _tenhang = "xxx";
                _tenhang = value;
            }
        }
        public decimal donGia { get { return _dongia; }
            set 
            {
                if (value < 0) throw new ArgumentNullException("value cannot be negative");
                _dongia = value;
            }
        }
        public int soLuongTon { get { return _soluongton; } 
            set 
            {
                if (value < 0) throw new ArgumentNullException("value cannot be negative");
                _soluongton = value;
            } 
        }

        public HangHoa(string MaHang, string TenHang, decimal DonGia, int SoLuongTon)
        {
            this.maHang = MaHang;
            this.tenHang = TenHang;
            this.donGia = DonGia;
            this.soLuongTon = SoLuongTon;
        }
        public abstract string danhGia();
        public abstract decimal VAT();

        public override bool Equals(object? obj)
        {
            if (obj is not HangHoa) return false;
            return this.maHang.Equals(((HangHoa)obj)._mahang);
        }
        public override int GetHashCode()
        {
            return this.maHang.GetHashCode();
        }
        public override string ToString()
        {
            return $"Ma hang: {maHang}. Ten hang: {tenHang}. Don gia: {donGia}. So luong ton: {soLuongTon}. ";
        }
    }
}
