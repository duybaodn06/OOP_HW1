using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai01
{
    internal class XeNgoaiThanh : ChuyenXe
    {
        public string NoiDen { get; set; }
        public int SoNgayDiDuoc { get; set; }
        
        public XeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, decimal doanhThu, string noiDen, int soNgayDiDuoc) : base( maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            NoiDen = noiDen;
            SoNgayDiDuoc = soNgayDiDuoc;
        }

        public override string ToString()
        {
            return base.ToString() + $", Noi den: {NoiDen}, So ngay di duoc: {SoNgayDiDuoc}";
        }

    }
}
