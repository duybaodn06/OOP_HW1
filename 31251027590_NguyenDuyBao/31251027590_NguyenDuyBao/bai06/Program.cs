using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai06
{
    internal class Program
    {
        static void Main6(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo danh sách có sức chứa 50 phần tử
            DanhSachHangHoa qlKho = new DanhSachHangHoa(50);

            // Thêm sẵn dữ liệu mẫu để thử nghiệm ngay mà không mất công nhập tay
            qlKho.ThemHangHoa(new HangDienMay("DM01", "Tu lanh Panasonic", 12000000m, 2, 24, 150));
            qlKho.ThemHangHoa(new HangDienMay("DM02", "May giat LG", 8500000m, 5, 12, 200));
            qlKho.ThemHangHoa(new HangSanhSu("SS01", "Bo chen Bat Trang", 350000m, 60, "Bat Trang", DateTime.Now.AddDays(-15)));
            qlKho.ThemHangHoa(new HangSanhSu("SS02", "Ly thuy tinh", 120000m, 30, "Minh Long", DateTime.Now.AddDays(-5)));
            qlKho.ThemHangHoa(new HangThucPham("TP01", "Sua tuoi tiet trung", 32000m, 10, "Vinamilk", DateTime.Now.AddDays(-60), DateTime.Now.AddDays(-10))); // Đã hết hạn -> Khó bán
            qlKho.ThemHangHoa(new HangThucPham("TP02", "Banh mi sandwich", 25000m, 15, "Kinh Do", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5)));

            int luaChon = -1;
            do
            {
                Console.WriteLine("\n================ QUAN LY KHO HANG ================");
                Console.WriteLine("1. Xem danh sach toan bo hang hoa");
                Console.WriteLine("2. Xem hang hoa theo tung loai");
                Console.WriteLine("3. Them hang hoa moi");
                Console.WriteLine("4. Tim kiem hang hoa theo ma");
                Console.WriteLine("5. Sap xep hang hoa theo ten tang dan");
                Console.WriteLine("6. Sap xep hang hoa theo so luong ton giam dan");
                Console.WriteLine("7. Xem danh sach thuc pham kho ban");
                Console.WriteLine("8. Xoa hang hoa theo ma");
                Console.WriteLine("9. Sua don gia theo ma hang");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("==================================================");
                Console.Write("Nhap lua chon cua ban: ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Vui long nhap so nguyen hop le!");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("\n--- DANH SACH TOAN BO HANG HOA ---");
                        HienThiDanhSach(qlKho.LayThongTinTatCa());
                        break;

                    case 2:
                        Console.WriteLine("\n--- HANG DIEN MAY ---");
                        HienThiDanhSach(qlKho.LayHangDienMay());

                        Console.WriteLine("\n--- HANG SANH SU ---");
                        HienThiDanhSach(qlKho.LayHangSanhSu());

                        Console.WriteLine("\n--- HANG THUC PHAM ---");
                        HienThiDanhSach(qlKho.LayHangThucPham());
                        break;

                    case 3:
                        ThemHangMoi(qlKho);
                        break;

                    case 4:
                        Console.Write("\nNhap ma hang can tim: ");
                        string maTim = Console.ReadLine()?.Trim() ?? "";
                        HangHoa hhTim = qlKho.Tim(maTim);
                        if (hhTim != null)
                        {
                            Console.WriteLine("Tim thay hang hoa:\n" + hhTim);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay ma hang: " + maTim);
                        }
                        break;

                    case 5:
                        qlKho.SapXepTenHangTang();
                        Console.WriteLine("\nDa sap xep danh sach theo ten hang tang dan:");
                        HienThiDanhSach(qlKho.LayThongTinTatCa());
                        break;

                    case 6:
                        qlKho.SapXepTonGiam();
                        Console.WriteLine("\nDa sap xep danh sach theo ton kho giam dan:");
                        HienThiDanhSach(qlKho.LayThongTinTatCa());
                        break;

                    case 7:
                        Console.WriteLine("\n--- DANH SACH THUC PHAM KHO BAN ---");
                        HangThucPham[] tpKhoBan = qlKho.ThucPhamKhoBan();
                        if (tpKhoBan.Length == 0)
                        {
                            Console.WriteLine("Khong co hang thuc pham nao kho ban.");
                        }
                        else
                        {
                            HienThiDanhSach(tpKhoBan);
                        }
                        break;

                    case 8:
                        Console.Write("\nNhap ma hang can xoa: ");
                        string maXoa = Console.ReadLine()?.Trim() ?? "";
                        if (qlKho.XoaHangHoa(maXoa))
                        {
                            Console.WriteLine($"Xoa thanh cong hang hoa co ma '{maXoa}'.");
                        }
                        else
                        {
                            Console.WriteLine($"Khong the xoa (ma hang '{maXoa}' khong ton tai).");
                        }
                        break;

                    case 9:
                        Console.Write("\nNhap ma hang can sua don gia: ");
                        string maSua = Console.ReadLine()?.Trim() ?? "";
                        Console.Write("Nhap don gia moi: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal donGiaMoi) && donGiaMoi >= 0)
                        {
                            if (qlKho.SuaDonGia(maSua, donGiaMoi))
                            {
                                Console.WriteLine("Cap nhat don gia thanh cong!");
                            }
                            else
                            {
                                Console.WriteLine($"Khong tim thay ma hang '{maSua}'.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Don gia khong hop le (phai la so >= 0)!");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong dung, vui long chon lai!");
                        break;
                }

            } while (luaChon != 0);
        }

        // Ham tien ich xuat danh sach
        static void HienThiDanhSach(HangHoa[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("(Trong)");
                return;
            }

            foreach (var item in arr)
            {
                if (item is not null)
                Console.WriteLine(item);
            }
        }

        // Ham nhap them hang hoa truc tiep tu ban phim
        static void ThemHangMoi(DanhSachHangHoa qlKho)
        {
            Console.WriteLine("\nChon loai hang muon them:");
            Console.WriteLine("1. Hang Dien May | 2. Hang Sanh Su | 3. Hang Thuc Pham");
            Console.Write("Loai: ");
            string loai = Console.ReadLine()?.Trim();

            Console.Write("Nhap ma hang: ");
            string ma = Console.ReadLine()?.Trim();
            Console.Write("Nhap ten hang: ");
            string ten = Console.ReadLine()?.Trim();
            Console.Write("Nhap don gia: ");
            decimal.TryParse(Console.ReadLine(), out decimal donGia);
            Console.Write("Nhap so luong ton: ");
            int.TryParse(Console.ReadLine(), out int tonKho);

            HangHoa moi = null;

            if (loai == "1")
            {
                Console.Write("Thoi gian bao hanh (thang): ");
                int.TryParse(Console.ReadLine(), out int bh);
                Console.Write("Cong suat (KW): ");
                int.TryParse(Console.ReadLine(), out int cs);
                moi = new HangDienMay(ma, ten, donGia, tonKho, bh, cs);
            }
            else if (loai == "2")
            {
                Console.Write("Nha san xuat: ");
                string nsx = Console.ReadLine()?.Trim();
                moi = new HangSanhSu(ma, ten, donGia, tonKho, nsx, DateTime.Now);
            }
            else if (loai == "3")
            {
                Console.Write("Nha cung cap: ");
                string ncc = Console.ReadLine()?.Trim();
                Console.Write("So ngay su dung ke tu hom nay: ");
                int.TryParse(Console.ReadLine(), out int han);
                moi = new HangThucPham(ma, ten, donGia, tonKho, ncc, DateTime.Now, DateTime.Now.AddDays(han));
            }

            if (moi != null && qlKho.ThemHangHoa(moi))
            {
                Console.WriteLine(">> Them thanh cong!");
            }
            else
            {
                Console.WriteLine(">> Them that bai (trung ma hang hoac vuot qua suc chua)!");
            }
        }
    }
}
