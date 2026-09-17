using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai07
{
    internal class Customer : Person
    {
        private string _tencongty;
        private float _trigiahoadon;
        private string _danhgia;
        public string tenCongTy
        {
            get {  return _tencongty; }
            set { _tencongty = value; }
        }
        public float triGiaHoaDon
        {
            get { return _trigiahoadon; }
            set { _trigiahoadon = value; }
        }
        public string danhGia
        {
            get { return _danhgia; }
            set { _danhgia = value; }
        }
        public Customer(string hoTen, string diachi, string tenCongTy, float triGiaHoaDon, string danhGia) : base (hoTen,diachi)
        {
            this.tenCongTy = tenCongTy;
            this.triGiaHoaDon = triGiaHoaDon;
            this.danhGia = danhGia;
        }
        public override string ToString()
        {
            return base.ToString() + $"Ten cong ty: {this.tenCongTy}. Tri gia hoa don: {this.triGiaHoaDon}. Danh gia: {this.danhGia}";
        }
    }
}
