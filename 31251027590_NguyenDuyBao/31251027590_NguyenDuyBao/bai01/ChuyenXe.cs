using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai01
{
    internal class ChuyenXe
    {
        public string MaSoChuyen { get; set; }
        public string HoTenTaiXe { get; set; }
        public string SoXe { get; set; }
        public decimal DoanhThu { get; set; }

        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, decimal doanhThu)
        {
            MaSoChuyen = maSoChuyen;
            HoTenTaiXe = hoTenTaiXe;
            SoXe = soXe;
            DoanhThu = doanhThu;
        }

        public override string ToString()
        {
            return $"Ma so chuyen: {MaSoChuyen}, Ho ten tai xe: {HoTenTaiXe}, So xe: {SoXe}, Doanh thu: {DoanhThu}";
        }
    }
}
