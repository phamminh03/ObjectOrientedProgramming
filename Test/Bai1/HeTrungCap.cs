using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HeTrungCap:PhieuDangKi
    {
        public override int Sotinchicuamotmon()
        {
            return 2;
        }
        public HeTrungCap(string sophieu, string mssv, string tensv,DateTime ngayvaohoc, DateTime ngaydangki, int somon, string hedaotao)
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
