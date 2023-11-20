using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4.cs
{
    class CBLanhDao:NhanVien
    {
        string msnv;
        string ten;
        double hsl;
        string chucvu;
        int thamnien;
        public CBLanhDao(string msnv)
            : base()
        {
            if (msnv.StartsWith("NV") && msnv!= null)
            {
                this.Msnv = msnv;
            }
            else
            {
                msnv = "NV001";
            }
        }
        //Khoi tao khong tham so
        public CBLanhDao()
        {
            this.msnv = "NV009";
            this.ten = "Dieu Hien";
            this.hsl = 4.67;
            this.chucvu = "Giam Doc";
            this.thamnien = 10;
        }
        public double hsld()
        {
            if(chucvu == "Giam Doc")
                return 7.0;
            else if (chucvu == "Truong Phong")
                return 6.0;
            else if (chucvu == "Pho Phong")
                return 4.5;
            else return 1.0;
        }
        public double phucaplanhdao()
        {
            return 1500 * hsld();
        }

    }
}
