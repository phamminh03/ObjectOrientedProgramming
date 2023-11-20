using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _29_PhamVanMinh_Tuan4
{
    class DSNV
    {
        List<NhanVien> lst=new List<NhanVien>();
        public List<NhanVien> ListNV
        {
            get { return lst; }
            set { lst = value; }
        }
        public void readDSNV(string pathfile)
        {
            XmlDocument read = new XmlDocument();
            read.Load(pathfile);
            XmlNodeList nodelist = read.SelectNodes("/dsnv/nhanvien");
            foreach (XmlNode node in nodelist)
            {
                NhanVien nv;
                int loai = int.Parse(node["loai"].InnerText);
                string manv = node["ma"].InnerText;
                string ten = node["ten"].InnerText;
                int namsinh = int.Parse(node["namsinh"].InnerText);
                string gioitinh = node["gioitinh"].InnerText;
                double hsl = double.Parse(node["hsl"].InnerText);
                int nvl = int.Parse(node["nvl"].InnerText);
                if (loai == 1)
                {
                    int snn = int.Parse(node["snn"].InnerText);
                    nv = new NhanVienSX(manv, ten, namsinh, gioitinh, hsl, nvl, snn);
                }
                else if (loai == 2)
                {
                    double doanhthu = double.Parse(node["doanhthu"].InnerText);
                    double doanhthuTT = double.Parse(node["doanhthuTT"].InnerText);
                    nv = new NhanVienKD(manv, ten, namsinh, gioitinh, hsl, nvl, doanhthu, doanhthuTT);
                }
                else
                {
                    string chucvu = node["chucvu"].InnerText;
                    double hesoPhuCapChucVu = double.Parse(node["hspccv"].InnerText);
                    nv = new CanBo(manv, ten, namsinh, gioitinh, hsl, nvl, chucvu, hesoPhuCapChucVu);
                }
                lst.Add(nv);
            }
        }
        public void printDSNV()
        {
            foreach (NhanVien nv in lst)
            {
                nv.output();
                Console.WriteLine("");
            }
        }
    }
}
