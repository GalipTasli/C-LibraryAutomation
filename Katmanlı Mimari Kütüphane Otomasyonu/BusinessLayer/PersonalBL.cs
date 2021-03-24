using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLayer
{
    public class PersonalBL
    {
        public static int BLPersonelEkle(PersonalEL d2)
        {
            return PersonalDAL.PersonalEkle(d2);
        }
        public static int BLPersonalSil(PersonalEL d2)
        {
            return PersonalDAL.PersonalSil(d2);
        }
        public static int BLPersonelGuncele(PersonalEL d2)
        {
            return PersonalDAL.PersonalGuncele(d2);
        }
        public static PersonalEL BLTextDoldur(PersonalEL d2)
        {
            return PersonalDAL.personalTextDoldur(d2);
        }
        public static int BLUygulamaAÇ(PersonalEL d2)
        {
            return PersonalDAL.UygulamaAç(d2);
        }

    }
}
