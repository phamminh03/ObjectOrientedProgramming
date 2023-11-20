using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4.cs
{
    class NhanVien
    {
        string msnv;
        public string Msnv
        {
            get { return msnv; }
            set { msnv = value; }
        }
        string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        double hsl;
        public double HeSoLuong
        {
            get { return hsl; }
            set { hsl = value; }
        }
        public NhanVien()
        {
            msnv = "NV001";
            hsl = 2.34;
        }
        public static int lcb = 1150;
        public double thunhap()
        {
            return hsl * lcb;
        }
    }
}
