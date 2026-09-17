using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai04
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            // Khởi tạo danh sách với kích thước tối đa 10 cuốn
            DanhSachSach quanLy = new DanhSachSach(10);

            // Thêm 3 cuốn sách giáo khoa (true: mới, false: cũ)
            quanLy.them(new SachGiaoKhoa("GK01", new DateTime(2023, 1, 15), 20000, 5, "Giao Duc", true));
            quanLy.them(new SachGiaoKhoa("GK02", new DateTime(2023, 2, 20), 15000, 10, "Kim Dong", false));
            quanLy.them(new SachGiaoKhoa("GK03", new DateTime(2023, 3, 10), 30000, 4, "Giao Duc", true));

            // Thêm 3 cuốn sách tham khảo
            quanLy.them(new SachThamKhao("TK01", new DateTime(2023, 4, 5), 50000, 3, "Tre", 5000));
            quanLy.them(new SachThamKhao("TK02", new DateTime(2023, 5, 12), 45000, 6, "Giao Duc", 8000));
            quanLy.them(new SachThamKhao("TK03", new DateTime(2023, 6, 25), 80000, 2, "Tong Hop", 12000));

            // 1. Xuất danh sách toàn bộ sách
            Console.WriteLine("=== DANH SACH CAC CUON SACH ===");
            Console.WriteLine(quanLy.ToString());

            // 2. Tính tổng thành tiền từng loại
            Console.WriteLine("=== TONG THANH TIEN ===");
            Console.WriteLine($"Tong thanh tien Sach Giao Khoa: {quanLy.tinhTongThanhTienSGK():N0}");
            Console.WriteLine($"Tong thanh tien Sach Tham Khao: {quanLy.tinhTongThanhTienSTK():N0}");

            // 3. Tìm sách giáo khoa theo nhà xuất bản K
            Console.Write("\nNhap ten NXB can tim cho Sach Giao Khoa: ");
            string nxbK = Console.ReadLine()?.Trim() ?? "";

            List<Sach> ketQuaNXB = quanLy.timSachGiaoKhoaTheoNXB(nxbK);
            Console.WriteLine($"\n=== KET QUA TIM KIEM NXB '{nxbK}' ===");
            if (ketQuaNXB.Count > 0)
            {
                foreach (Sach s in ketQuaNXB)
                {
                    Console.WriteLine(s.ToString());
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sach giao khoa nao cua nha xuat ban nay.");
            }

            // 4. Tìm thành tiền cao nhất
            double maxThanhTien = quanLy.timThanhTienCaoNhat();
            Console.WriteLine($"\n=== THANH TIEN CAO NHAT ===");
            Console.WriteLine($"Gia tri thanh tien lon nhat: {maxThanhTien:N0}");
        }
    }
}
