using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
   public static class KitapEmanetBL
    {
        public static int BLKitapVer(KitapEmanetEL d2)
        {
            return KitapEmanetDAL.KitapVer(d2);
        }
        
        public static List<KitapEmanetEL> BLVerilenKitapListele()
        {
            return KitapEmanetDAL.VerilenKitapListele();
        }
        public static int BLKitapAl(KitapEmanetEL d2)
        {
           return KitapEmanetDAL.KitapAl(d2);
        }
        public static DateTime BLteslimtarihdündür(int d)
        {
            return KitapEmanetDAL.teeslimzamanıdöndür(d);
        }
        public static DateTime BLemanettarihdündür(int d)
        {
            return KitapEmanetDAL.emanetzamanidöndür(d);
        }
    }

}

