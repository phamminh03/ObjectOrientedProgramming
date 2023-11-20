using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    class PDK
    {
        List<PhieuDangKi> ds = new List<PhieuDangKi>();
        internal List<PhieuDangKi> Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public void inputPDK(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodelist = read.SelectNodes("/dsphieudk/phieudk");
            foreach (XmlNode node in nodelist)
            {
                PhieuDangKi pdk;
                string sophieu = node["so"].InnerText;
                XmlNode svnode = node.SelectSingleNode("sv");
                string mssv = svnode["mssv"].InnerText;
                string tensv = svnode["tensv"].InnerText;
                DateTime ngayvaohoc = DateTime.ParseExact(node["ngayvh"].InnerText, "dd/MM/yyyy", null);
                DateTime ngaydangki = DateTime.ParseExact(node["ngaydk"].InnerText, "dd/MM/yyyy", null);
                int somon = int.Parse(node["somon"].InnerText);
                string hedaotao = node["hedt"].InnerText;
                if (hedaotao == "DH")
                    pdk = new HeDaiHoc(sophieu, mssv, tensv, ngayvaohoc, ngaydangki, somon, hedaotao);
                else if (hedaotao == "CD")
                    pdk = new HeCaoDang(sophieu, mssv, tensv, ngayvaohoc, ngaydangki, somon, hedaotao);
                else
                    pdk = new HeTrungCap(sophieu, mssv, tensv, ngayvaohoc, ngaydangki, somon, hedaotao);
                ds.Add(pdk);
            }
        }
        public void print()
        {
            foreach (PhieuDangKi pdk in ds)
            {
                Console.WriteLine("");
                pdk.output();
            }
        }
    }
}
