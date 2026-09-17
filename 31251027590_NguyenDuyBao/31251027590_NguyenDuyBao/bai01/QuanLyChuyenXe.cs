using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai01
{
    internal class QuanLyChuyenXe
    {
        static void Main1(string[] args)
        {
            XeNgoaiThanh NGT1 = new XeNgoaiThanh("CX001","Nguyen Van A", "29A-12345", 1000000, "Da Nang", 5);
            XeNgoaiThanh NGT2 = new XeNgoaiThanh("CX002","Nguyen Van B", "29A-54321", 2000000, "Hue", 3);
            
            XeNoiThanh NT1 = new XeNoiThanh("CX003","Nguyen Van C", "29A-67890", 1500000, 1, 100);
            XeNoiThanh NT2 = new XeNoiThanh("CX004","Nguyen Van D", "29A-09876", 2500000, 2, 200);

            List<ChuyenXe> danhSachChuyenxe = new List<ChuyenXe>();
            danhSachChuyenxe.Add(NGT1);
            danhSachChuyenxe.Add(NGT2);
            danhSachChuyenxe.Add(NT1);
            danhSachChuyenxe.Add(NT2);

            decimal TongDoanhThuNoiThanh = 0;
            decimal TongDoanhThuNgoaiThanh = 0;
            decimal TongDoanhThu = 0;

            foreach (ChuyenXe cx in danhSachChuyenxe)
            {
                if (cx is XeNoiThanh)
                {
                    TongDoanhThuNoiThanh += (decimal)cx.DoanhThu;
                }
                else if (cx is XeNgoaiThanh)
                {
                    TongDoanhThuNgoaiThanh += (decimal)cx.DoanhThu;
                }
                TongDoanhThu += (decimal)cx.DoanhThu;
            }

            Console.WriteLine($"Tong doanh thu: {TongDoanhThu}");
            Console.WriteLine($"Tong doanh thu noi thanh: {TongDoanhThuNoiThanh}");
            Console.WriteLine($"Tong doanh thu ngoai thanh: {TongDoanhThuNgoaiThanh}");
        }
    }
}
