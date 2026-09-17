using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai04
{
    internal class DanhSachSach
    {
        private Sach[] list;
        private int count;

        public DanhSachSach(int n)
        {
            this.list = new Sach[n];
            this.count = 0;
        }
        public bool them(Sach sach)
        {
            if (sach is not Sach || this.list.Contains(sach) || list.Length <= count ) return false;
            else
            {
                this.list[count++] = sach;
                return true;
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < this.count; i++)
            {
                str += list[i].getMaSach();
            }
            return $"Danh sach sach: {str}";
        }
        public double tinhTongThanhTienSGK()
        {
            double t = 0;
            foreach (Sach x in this.list)
            {
                if (x is SachGiaoKhoa) t += x.getThanhTien();
            }
            return t;
        }
        public double tinhTongThanhTienSTK()
        {
            double t = 0;
            foreach (Sach x in this.list)
            {
                if (x is SachThamKhao) t += x.getThanhTien();
            }
            return t;
        }
        public List<Sach> timSachGiaoKhoaTheoNXB(string NXB)
        {
            List<Sach> t = new List<Sach>();
            foreach (Sach x in this.list)
            {
                if (x.getNhaXuatBan() == NXB && x is SachGiaoKhoa) t.Add(x);
            }
            return t;
        }
        public double timThanhTienCaoNhat()
        {
            double t = this.list[0].getThanhTien();
            foreach (Sach x in this.list)
            {
                if (x.getThanhTien() >  t) t = x.getThanhTien();
            }
            return t;
        }
    }
}
