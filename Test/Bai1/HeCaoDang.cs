using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HeCaoDang:PhieuDangKi
    {
        public override int Sotinchicuamotmon()
        {
            if (ngaydangki.Year - ngayvaohoc.Year <= 1)
                return 2;
            else
                return 3;
        }
        public HeCaoDang(string sophieu, string mssv, string tensv, DateTime ngayvaohoc, DateTime ngaydangki, int somon, string hedaotao)
            : base()
        {
            Sophieu = sophieu;
            Mssv = mssv;
            Tensv = tensv;
            Ngayvaohoc = ngayvaohoc;
            Ngaydangki = ngaydangki;
            Somon = somon;
            Hedaotao = hedaotao;
        }
        public override void output()
        {
            base.output();
        }
    }
}
