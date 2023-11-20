using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Tuan5
{
    class DSBDS
    {
        List<BatDongSan> ds = new List<BatDongSan>();
        public List<BatDongSan> Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        
        public void inputDSBDS(string file)
        {
              // Cach 1
        //    XmlDocument read = new XmlDocument();
        //    read.Load(file);
        //    XmlNodeList nodelist = read.SelectNodes("/BDSs/BDS");
        //    foreach(XmlNode node in nodelist)
        //    {
        //        BatDongSan bds;
        //        int loai = int.Parse(node["Loai"].InnerText);
        //        string ma = node["Ma"].InnerText;
        //        double chieudai = double.Parse(node["Dai"].InnerText);
        //        double chieurong = double.Parse(node["Rong"].InnerText);
        //        if (loai == 1)
        //        {
        //            int solau = int.Parse(node["Solau"].InnerText);
        //            bds = new NhaO(chieudai, chieurong, solau);
        //        }
        //        else if (loai == 2)
        //        {
        //            bds = new DatTrong(chieudai, chieurong);
        //        }
        //        else if (loai == 3)
        //        {
        //            bds = new BietThu(chieudai, chieurong);
        //        }
        //        else
        //        {
        //            int sosao = int.Parse(node["Sosao"].InnerText);
        //            bds = new KhachSan(chieudai, chieurong, sosao);
        //        }

                // Cach 2
                XDocument doc = XDocument.Load(file);

                IEnumerable<XElement> bdsElements = doc.Descendants("BDS");
                foreach (XElement bdsElement in bdsElements)
                {
                    BatDongSan bds;
                    int loai = int.Parse(bdsElement.Attribute("Loai").Value);
                    string ma = bdsElement.Element("Ma").Value;
                    double chieudai = double.Parse(bdsElement.Element("Dai").Value);
                    double chieurong = double.Parse(bdsElement.Element("Rong").Value);
        
                    if (loai == 1)
                    {
                        int solau = int.Parse(bdsElement.Element("Solau").Value);
                        bds = new NhaO(chieudai, chieurong, solau);
                    }
                    else if (loai == 2)
                    {
                        bds = new DatTrong(chieudai, chieurong);
                    }
                    else if (loai == 3)
                    {
                        bds = new BietThu(chieudai, chieurong);
                    }
                    else
                    {
                        int sosao = int.Parse(bdsElement.Element("Sosao").Value);
                        bds = new KhachSan(chieudai, chieurong, sosao);
                    }
                    ////////////
                    ds.Add(bds);
            }
        }
        public void outputDSBDS()
        {
            foreach (BatDongSan bds in ds)
            {
                bds.output();
                Console.WriteLine("");
            }
            Console.WriteLine("Tong gia tri: " + TongGiaTri());
            Console.WriteLine("Tong thue: " + TongThue());
            Console.WriteLine("Tong thue theo loai 3: " + TongThueTheoLoai(3));
            Console.WriteLine("Tong thue theo loai 4: " + TongThueTheoLoai(4));
        }
        public double TongGiaTri()
        {
            double tonggiatri = 0;
            foreach (BatDongSan bds in ds)
                tonggiatri += bds.GiaBan();
            return tonggiatri;
        }
        public double TongThue()
        {
            double tongthue = 0;
            foreach(BatDongSan bds in ds)
                if (bds is IPhi)
                {
                    IPhi t = (IPhi)bds;
                    tongthue += t.PhiKinhDoanh();
                }
            return tongthue;
        }
        public double TongThueTheoLoai(int loai)
        {
            double tongthueKS = 0;
            double tongthueBT = 0;
            foreach (BatDongSan bds in ds)
            {
                if (bds is IPhi)
                {
                    if (bds is BietThu && loai == 3)
                    {
                        IPhi t = (IPhi)bds;
                        return tongthueBT += t.PhiKinhDoanh();
                    }
                    else if (bds is KhachSan && loai == 4)
                    {
                        IPhi t = (IPhi)bds;
                        return tongthueKS += t.PhiKinhDoanh();
                    }
                }
            }
            return -1;
        }
    }
}
