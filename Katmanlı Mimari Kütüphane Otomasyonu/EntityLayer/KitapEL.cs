using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class KitapEL
    {
        int Kitap_Id;

        string Kitap_Isim;

        string Kitap_Yazar;

        int Kitap_Sayfa;

        int Kitap_Adet;

        string Kitap_BasımTarihi;

        string Kitap_Türü;

        public int kitap_Id { get => Kitap_Id; set => Kitap_Id = value; }

        public string kitap_isim { get => Kitap_Isim; set => Kitap_Isim = value; }

        public string kitap_yazar { get => Kitap_Yazar; set => Kitap_Yazar = value; }

        public int kitap_sayfa { get => Kitap_Sayfa; set => Kitap_Sayfa = value; }

        public int kitap_adet { get => Kitap_Adet; set => Kitap_Adet = value; }

        public string kitap_basım_tarihi { get => Kitap_BasımTarihi; set => Kitap_BasımTarihi = value; }

        public string kitap_türü { get => Kitap_Türü; set => Kitap_Türü = value; }

    }
}
