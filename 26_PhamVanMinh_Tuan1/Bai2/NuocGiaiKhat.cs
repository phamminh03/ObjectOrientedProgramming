using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class NuocGiaiKhat
    {
        string tenhang;
        public string TenHang
        {
            get { return tenhang; }
            set { tenhang = value; }
        }

        string donvitinh;
        public string DonViTinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }

        int soluong;
        public int SoLuong
        {
            get { return soluong; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Du lieu sai!");
                    soluong = 0;
                }
                else
                    soluong = value;

            }
        }

        float dongia;

        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

    }
}
