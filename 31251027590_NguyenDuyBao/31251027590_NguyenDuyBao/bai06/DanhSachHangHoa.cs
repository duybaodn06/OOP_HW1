using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai06
{
    internal class DanhSachHangHoa
    {
        private HangHoa[] danhSach;
        private int n;

        public DanhSachHangHoa(int n)
        {
            this.n = 0;
            danhSach = new HangHoa[n];
        }
        public bool ThemHangHoa(HangHoa hangHoa)
        {
            if (n >= danhSach.Length || Tim(hangHoa.maHang) != null)
            {
                return false;
            }
            danhSach[n] = hangHoa;
            n++;
            return true;
        } 
        public HangHoa[] LayThongTinTatCa()
        {
            return danhSach;
        }
        public HangHoa LayThongTinHang(int n)
        {
            if (n < 0 || n >= danhSach.Length) return null;
            return danhSach[n];
        }
        public HangDienMay[] LayHangDienMay()
        {
            List<HangDienMay> list = new List<HangDienMay>();
            for (int i = 0; i < this.n; i++)
            {
                if (danhSach[i] is HangDienMay dm) list.Add(dm);
            }
            return list.ToArray();
        }

        public HangSanhSu[] LayHangSanhSu()
        {
            List<HangSanhSu> list = new List<HangSanhSu>();
            for (int i = 0; i < this.n; i++)
            {
                if (danhSach[i] is HangSanhSu ss) list.Add(ss);
            }
            return list.ToArray();
        }

        public HangThucPham[] LayHangThucPham()
        {
            List<HangThucPham> list = new List<HangThucPham>();
            for (int i = 0; i < this.n; i++)
            {
                if (danhSach[i] is HangThucPham tp) list.Add(tp);
            }
            return list.ToArray();
        }
        public HangHoa Tim(string x)
        {
            for (int i = 0; i < this.n; i++)
            {
                if (danhSach[i].maHang == x) return danhSach[i];
            }
            return null;
        }
        public void SapXepTenHangTang()
        {
            for (int i = 0; i < this.n - 1; i++)
            {
                for (int j = 0; j < this.n - i - 1; j++)
                {
                    if (string.Compare(danhSach[j].tenHang,danhSach[j+1].tenHang) > 0 ? true : false)
                    {
                        (danhSach[j], danhSach[j + 1]) = (danhSach[j + 1], danhSach[j]);
                    }
                }
            }
        }
        public void SapXepTonGiam()
        {
            for (int i = 0; i < this.n - 1; i++)
            {
                for (int j = 0; j < this.n - i - 1; j++)
                {
                    if (danhSach[j].soLuongTon < danhSach[j + 1].soLuongTon)
                    {
                        (danhSach[j], danhSach[j + 1]) = (danhSach[j + 1], danhSach[j]);
                    }
                }
            }
        }
        public HangThucPham[] ThucPhamKhoBan()
        {
            HangThucPham[] temp = new HangThucPham[this.n];
            int i = 0;
            for (int j = 0; j < this.n; j++)
            {
                if (danhSach[j] is HangThucPham htp && htp.danhGia() == "Kho ban")
                {
                    temp[i++] = htp;
                }
            }
            HangThucPham[] temp1 = new HangThucPham[i];
            for (int j = 0; j < i; j++)
            {
                temp1[j] = temp[j];
            }
            return temp1;
        }
        public bool XoaHangHoa(string MaHang)
        {
            for (int i = 0; i < this.n; i++)
            {
                if (danhSach[i].maHang == MaHang)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        danhSach[j] = danhSach[j + 1];
                    }
                    danhSach[this.n - 1] = null;
                    this.n--;
                    return true;
                }
            }
            return false;
        }
        public bool SuaDonGia(string MaHang, decimal DonGia)
        {
            for (int i = 0; i < this.n; i++)
            {
                if (danhSach[i].maHang == MaHang)
                {
                    danhSach[i].donGia = DonGia;
                    return true;
                }
            }
            return false;
        }
    }
}
