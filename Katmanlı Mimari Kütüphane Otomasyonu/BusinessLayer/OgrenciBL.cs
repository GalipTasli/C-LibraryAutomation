using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class OgrenciBL
    {
        
        public static int BLÖgerenciSil(OgrenciEL d2)
        {
            return OgrenciDAL.ÖgrenciSil(d2);
        }
        public static int BLCezaHesapla()
        {
            return OgrenciDAL.CezaHesapla();
        }
        public static int BLÖgrenciGuncele(OgrenciEL d2)
        {
            return OgrenciDAL.ÖgrenciGüncele(d2);
        }
        public static OgrenciEL BLTextDoldur(OgrenciEL d2)
        {
            return OgrenciDAL.ÖgrenciTextDoldur(d2);
        }
        public static int BLÖgrenciEkle(OgrenciEL d2)
        {
            return OgrenciDAL.ÖgrenciEkle(d2);
        }
        public static List<OgrenciEL> BLÖgrenciListele()
        {
            return OgrenciDAL.ÖgrenciListele();
        }
        public static List<KitapEmanetEL> BLÖgrenciDetayListele(KitapEmanetEL d2)
        {
            return OgrenciDAL.ögrenciDetayListele(d2);

        }
    }
   
}
