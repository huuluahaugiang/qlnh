using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class MonAn
    {
        string _MaMonAn;
        string _TenMonAn;
        string _DVT;
        long _DonGia;

        public string MaMonAn { get => _MaMonAn; set => _MaMonAn = value; }
        public string TenMonAn { get => _TenMonAn; set => _TenMonAn = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
        public long DonGia { get => _DonGia; set => _DonGia = value; }

        public MonAn(string maMonAn, string tenMonAn, string dVT, long donGia)
        {
            _MaMonAn = maMonAn;
            _TenMonAn = tenMonAn;
            _DVT = dVT;
            _DonGia = donGia;
        }
        public MonAn()
        {
            _MaMonAn = null;
            _TenMonAn = null;
            _DVT = null;
            _DonGia = 0;
        }

    }
    public class HoaDon
    {

    }
}
