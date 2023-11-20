using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    abstract public class PhieuDangKi
    {
        public string mssv;
        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        public string tensv;
        public string Tensv
        {
            get { return tensv; }
            set { tensv = value; }
        }
        public DateTime ngayvaohoc;
        public DateTime Ngayvaohoc
        {
            get { return ngayvaohoc; }
            set { ngayvaohoc = value; }
        }
        string sophieu;
        public string Sophieu
        {
            get { return sophieu; }
            set { sophieu = value; }
        }
        public DateTime ngaydangki;
        public DateTime Ngaydangki
        {
            get { return ngaydangki; }
            set { ngaydangki = value; }
        }
        int somon;
        public int Somon
        {
            get { return somon; }
            set
            {
                if (value <= 5)
                    somon = value;
                else
                    Console.WriteLine("So mon khong duoc qua 5!");
            }
        }
        string hedaotao;
        public string Hedaotao
        {
            get { return hedaotao; }
            set
            {
                if (value == "DH")
                    hedaotao = value;
                else if (value == "CD")
                    hedaotao = value;
                else if (value == "TC")
                    hedaotao = value;
                else
                    Console.WriteLine("He dao tao khong hop le!");
            }
        }
        protected static double tienmottinchi = 1000000;
        public abstract int Sotinchicuamotmon();
        public double Tinhhocphi()
        {
            return somon * Sotinchicuamotmon() * tienmottinchi;
        }
        public virtual void output()
        {
            Console.WriteLine("Ma so sinh vien: " + mssv);
            Console.WriteLine("Ho ten sinh vien: " + tensv);
            Console.WriteLine("So phieu: " + sophieu);
            Console.WriteLine("Ngay vao hoc: " + ngayvaohoc.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay dang ki: " + ngaydangki.ToString("dd/MM/yyyy"));
            Console.WriteLine("So mon: " + somon);
            Console.WriteLine("He dao tao: " + hedaotao);
            Console.WriteLine("So tin chi cua mot mon: " + Sotinchicuamotmon());
            Console.WriteLine("Tong hoc phi: " + Tinhhocphi());
            Console.WriteLine("");
        }
    }
}
