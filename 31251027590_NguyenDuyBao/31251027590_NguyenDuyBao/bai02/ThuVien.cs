using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai02
{
    internal class ThuVien
    {
        static void Main2(string[] args)
        {
            // Create instances of SachGiaoKhoa and SachThamKhao
            SachGiaoKhoa GK1 = new SachGiaoKhoa("GK001", new DateTime(2023, 1, 1), 10000, 10, "NXB A", "cu");
            SachGiaoKhoa GK2 = new SachGiaoKhoa("GK002", new DateTime(2023, 2, 1), 15000, 5, "NXB B", "moi");
            SachGiaoKhoa GK3 = new SachGiaoKhoa("GK003", new DateTime(2023, 5, 1), 12000, 7, "NXB E", "cu");

            SachThamKhao TK1 = new SachThamKhao("TK001", new DateTime(2023, 3, 1), 20000, 8, "NXB C", 5000);
            SachThamKhao TK2 = new SachThamKhao("TK002", new DateTime(2023, 4, 1), 25000, 12, "NXB D", 10000);
            SachThamKhao TK3 = new SachThamKhao("TK003", new DateTime(2023, 6, 1), 30000, 15, "NXB F", 15000);

            List<Sach> danhSachSach = new List<Sach>() { GK1, GK2, TK1, TK2 };

            decimal tongTienSGK= 0;
            decimal tongTienSTK = 0;
            foreach (Sach sach in danhSachSach)
            {
                if (sach is SachGiaoKhoa)
                {
                    tongTienSGK += ((SachGiaoKhoa)sach).thanhTien();
                }
                else if (sach is SachThamKhao)
                {
                    tongTienSTK += ((SachThamKhao)sach).thanhTien();
                }
            }
            Console.WriteLine($"Tong tien sach giao khoa: {tongTienSGK:0.00}");
            Console.WriteLine($"Tong tien sach tham khao: {tongTienSTK:0.00}");

            Console.Write("Nhap ten nha xuat ban: ");
            string tenNXB = Console.ReadLine();
            Console.WriteLine($"Danh sach cac sach giao khoa cua {tenNXB}:");
            foreach (Sach sach in danhSachSach)
            {
                if (sach is SachGiaoKhoa)
                {
                    Console.WriteLine($"Sach Giao Khoa: {sach.ToString()}");
                }
            }

            decimal maxDonGia = 0;
            Sach sachMaxDonGia = null;
            foreach (Sach sach in danhSachSach)
            {
                if (sach is SachThamKhao && ((SachThamKhao)sach).thanhTien() > maxDonGia)
                {
                    sachMaxDonGia = sach;
                }
                else if (sach is SachGiaoKhoa && ((SachGiaoKhoa)sach).thanhTien() > maxDonGia)
                {
                    sachMaxDonGia = sach;
                }
            }
            if (sachMaxDonGia is SachThamKhao)
            {
                Console.WriteLine($"Sach co thanh tien cao nhat: \n{((SachThamKhao)sachMaxDonGia).ToString()}");
            }
            else
            {
                Console.WriteLine($"Sach co thanh tien cao nhat: \n{((SachGiaoKhoa)sachMaxDonGia).ToString()}");
            }
        } 

    }
}
