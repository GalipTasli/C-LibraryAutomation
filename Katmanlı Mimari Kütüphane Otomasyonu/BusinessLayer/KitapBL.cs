using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class KitapBL
    {
        public static int BLKitapEkle(KitapEL d1)
        {
            return KitapDAL.KitapEkle(d1);
        }

        public static List<KitapEL> BLKitapListele()
        {
            return KitapDAL.KitapListele();
        }
        public static List<KitapEmanetEL> BLKitapDetayListele(KitapEmanetEL d2)
        {
            return KitapDAL.KitapDetayListele(d2);

        }
        public static int BLKitapGuncele(KitapEL d1)
        {
            return KitapDAL.KitapGuncele(d1);
        }
        public static KitapEL BLTextDoldur(KitapEL d2)
        {
            return KitapDAL.kitapTextDoldur(d2);
        }
        public static int BLKitapSil(KitapEL d1)
        {
            return KitapDAL.KitapSil(d1);
        }
        public static int BLromansasy()
        {
            return KitapDAL.romansay();
        }
        public static int BLtromansay()
        {
            return KitapDAL.tromansay();
        }
        public static int BLöyküasay()
        {
            return KitapDAL.öyküsay();
        }
        public static int BLtöyküsay()
        {
            return KitapDAL.töyküsay();
        }
        public static int BLderskitabısay()
        {
            return KitapDAL.derskitabısay();
        }
        public static int BLtderskitabısay()
        {
            return KitapDAL.tderskitabısay();
        }
    }
}
