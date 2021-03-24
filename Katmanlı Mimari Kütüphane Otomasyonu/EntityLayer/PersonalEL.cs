using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PersonalEL
    {
        int Personal_Id;

        string Personal_KullanıcıAdı;

        string Personal_Şifre;

        string Personal_Adı;

        string Personal_Soyadı;

        public int personal_ıd { get => Personal_Id; set => Personal_Id = value; }

        public string personal_kullanıcıadı { get => Personal_KullanıcıAdı; set => Personal_KullanıcıAdı = value; }

        public string personal_şifre { get => Personal_Şifre; set => Personal_Şifre = value; }

        public string personal_adı { get => Personal_Adı; set => Personal_Adı = value; }

        public string personal_soyadı { get => Personal_Soyadı; set => Personal_Soyadı = value; }

    }
}
