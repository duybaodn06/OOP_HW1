using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai01
{
    internal class XeNoiThanh : ChuyenXe
    {
        public int SoTuyen { get; set; }
        public int SoKmDiDuoc { get; set; }

        public XeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, decimal doanhThu, int soTuyen, int soKmDiDuoc) : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            SoTuyen = soTuyen;
            SoKmDiDuoc = soKmDiDuoc;
        }

        public override string ToString()
        {
            return base.ToString() + $", So tuyen: {SoTuyen}, So km di duoc: {SoKmDiDuoc}";
        }
    }
}
