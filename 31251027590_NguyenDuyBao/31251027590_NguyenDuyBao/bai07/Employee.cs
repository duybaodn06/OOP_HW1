using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai07
{
    internal class Employee : Person
    {
        private float _hesoluong;
        public float heSoLuong
        {
            get { return _hesoluong; }
            set { _hesoluong = value; }
        }
        public Employee(string hoTen, string diachi, float heSoLuong) : base(hoTen,diachi)
        {
            this.heSoLuong = heSoLuong;
        }
        public float TinhLuong()
        {
            return 2530000f * heSoLuong;
        }
        public string DanhGia() { return null; }
        public override string ToString()
        {
            return base.ToString() + $"Tien luong: {this.TinhLuong()}";
        }

    }
}
