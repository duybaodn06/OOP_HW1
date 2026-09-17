using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai03
{
    internal class QuanLyGiaoDich
    {
        static void Main3(string[] args)
        {   
            GiaoDichVang GDV1 = new GiaoDichVang("GDV001", new DateTime(2023, 1, 1), 1000000000, 2, "SJC");
            GiaoDichVang GDV2 = new GiaoDichVang("GDV002", new DateTime(2023, 1, 2), 12000000, 1, "PNJ");
            GiaoDichVang GDV3 = new GiaoDichVang("GDV003", new DateTime(2023, 1, 3), 110000000000, 3, "SJC");

            GiaoDichTienTe GDT1 = new GiaoDichTienTe("GDT001", new DateTime(2023, 1, 1), 23000000000, 100, 1.1m, "USD");
            GiaoDichTienTe GDT2 = new GiaoDichTienTe("GDT002", new DateTime(2023, 1, 2), 2400000, 200, 1.2m, "EUR");
            GiaoDichTienTe GDT3 = new GiaoDichTienTe("GDT003", new DateTime(2023, 1, 3), 22000000000000, 150, 1.3m, "VND");

            List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>() { GDV1, GDV2, GDV3, GDT1, GDT2, GDT3 };

            int soLuongGiaoDichVang = 0;
            int soLuongGiaoDichTienTe = 0;
            foreach (GiaoDich x in danhSachGiaoDich)
            {
                if (x is GiaoDichVang)
                {
                    soLuongGiaoDichVang += ((GiaoDichVang)x).SoLuong;
                }
                else if (x is GiaoDichTienTe)
                {
                    soLuongGiaoDichTienTe += ((GiaoDichTienTe)x).SoLuong;
                }
            }
            Console.WriteLine($"So luong giao dich vang: {soLuongGiaoDichVang}");
            Console.WriteLine($"So luong giao dich tien te: {soLuongGiaoDichTienTe}");

            int soGiaoDichTienTe = 0;
            decimal tongTienGiaoDichTienTe = 0.0m;
            foreach (GiaoDich x in danhSachGiaoDich)
            {
                if (x is GiaoDichTienTe)
                {
                    soGiaoDichTienTe++;
                    tongTienGiaoDichTienTe += ((GiaoDichTienTe)x).ThanhTien();
                }
            }
            
            Console.WriteLine($"Trung binh thanh tien giao dich tien te: {(soGiaoDichTienTe > 0 ? tongTienGiaoDichTienTe / soGiaoDichTienTe : 0):C}");
            Console.WriteLine("Danh sach giao dich co don gia > 1 ty:");
            foreach (GiaoDich x in danhSachGiaoDich)
            {
                if (x.DonGia > 1000000000)
                {
                    Console.WriteLine(x.ToString());
                }
            }

        }
    }
}
