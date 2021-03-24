using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class OgrenciEL
    {
        string Ögrenci_Tc_No;

        string Ögrenci_Adı;

        string Ögrenci_Soyadı;

        string Ögrenci_telefon;

        string Ögrenci_Adres;

        decimal Ögrenci_Ceza;

        public string ögrenci_tc_no { get => Ögrenci_Tc_No; set => Ögrenci_Tc_No = value; }

        public string ögrenci_adı { get => Ögrenci_Adı; set => Ögrenci_Adı = value; }

        public string ögrenci_soyadı { get => Ögrenci_Soyadı; set => Ögrenci_Soyadı = value; }

        public string ögrenci_telefon { get => Ögrenci_telefon; set => Ögrenci_telefon = value; }

        public string ögrenci_adres { get => Ögrenci_Adres; set => Ögrenci_Adres = value; }

        public decimal ögrenci_ceza { get => Ögrenci_Ceza; set => Ögrenci_Ceza = value; }


    }
}
