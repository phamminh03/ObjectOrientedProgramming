using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _29_PhamVanMinh_KTL2
{
    class DSSP
    {
        List<SanPham> lst = new List<SanPham>();
        internal List<SanPham> Lst
        {
            get { return lst; }
            set { lst = value; }
        }
        public void read(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNode node_ds = read.SelectSingleNode("/congty_a");
            string diachi = node_ds["diachi"].InnerText;
            string masothue = node_ds["masothue"].InnerText;
            Console.WriteLine("Dia chi cong ty A: " + diachi);
            Console.WriteLine("Ma so thue: " + masothue);
            XmlNodeList nodelist = read.SelectNodes("/congty_a/dssanphams/sanpham");
            foreach (XmlNode node in nodelist)
            {
                SanPham sp = null;
                string loaisp = node["loaisp"].InnerText;
                string masp = node["masp"].InnerText;
                string tensp = node["tensp"].InnerText;
                string chatlieu = node["chatlieu"].InnerText;
                int size = int.Parse(node["size"].InnerText);
                string color = node["mausac"].InnerText;
                int namsanxuat = int.Parse(node["namsanxuat"].InnerText);
                double dongia = double.Parse(node["dongia"].InnerText);

                if (loaisp == "Giay thoi trang")
                {
                    double chieucaode = double.Parse(node["chieucaode"].InnerText);
                    string loaimuigiay = node["loaimuigiay"].InnerText;
                    sp = new GiayThoiTrang(masp, tensp, chatlieu, size, color, namsanxuat, dongia, chieucaode, loaimuigiay);
                }
                else if (loaisp == "Giay the thao")
                {
                    string loaigiay = node["loaigiay"].InnerText;
                    sp = new GiayTheThao(masp, tensp, chatlieu, size, color, namsanxuat, dongia, loaigiay);
                }
                else if (loaisp == "Dep Sandal")
                {
                    int soquay = int.Parse(node["soquay"].InnerText);
                    string loaide = node["loaide"].InnerText;
                    sp = new DepSandal(masp, tensp, chatlieu, size, color, namsanxuat, dongia, soquay, loaide);
                }
                else
                {
                    Console.WriteLine("Khong tim thay san pham!");
                }
                lst.Add(sp);
            }
        }
        public void print()
        {
            foreach (SanPham sp in lst)
            {
                sp.output();
            }
        }
        public double Tonggiatri()
        {
            double tong = 0;
            foreach (SanPham sp in lst)
                tong += sp.Thanhtien();
            return tong;
        }
        public double Tongphuphi()
        {
            double tong = 0;
            foreach(SanPham sp in lst)
            {
                if (sp is IPhu)
                {
                    IPhu t = (IPhu)sp;
                    tong += t.Giaphuthu();
                }
            }
            return tong;
        }
    }
}
