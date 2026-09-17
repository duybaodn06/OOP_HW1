using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai03
{
    internal class GiaoDichTienTe : GiaoDich
    {
        public decimal TyGia { get; set; }
        private string _loaitiente;
        public string Loaitiente { get { return _loaitiente; } 
            set 
            {
                if (value == "USD" || value == "EUR" || value == "VND")
                {
                    _loaitiente = value;
                }
                else
                {
                    throw new ArgumentException("Loai tien te khong hop le.");
                }
            }
        }
        public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaoDich, decimal donGia, int soLuong, decimal tyGia, string loaiTienTe)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            TyGia = tyGia;
            Loaitiente = loaiTienTe;
        }
        public override string ToString()
        {
            return base.ToString() + $", Ty gia: {TyGia}, Loai tien te: {Loaitiente}";
        }
        public decimal ThanhTien()
        {
            if (_loaitiente == "VND")
            {
                return DonGia * SoLuong;
            }
            else
            {
                return DonGia * SoLuong * TyGia;
            }
        }
    }
}
