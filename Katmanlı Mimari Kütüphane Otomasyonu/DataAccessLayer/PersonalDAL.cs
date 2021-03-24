using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class PersonalDAL
    {
        public static int PersonalEkle(PersonalEL d2)
        {
            OleDbCommand cmd = new OleDbCommand("insert into personal (kullanıcıadı,şifre,adı,soyadı) values (@Personal_Kullanıcıadı,@Personal_Şifre,@Personal_Adı,@Personal_Soyadı)", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Personal_Kullanıcıadı", d2.personal_kullanıcıadı);
            cmd.Parameters.AddWithValue("@Personal_Şifre", d2.personal_şifre);
            cmd.Parameters.AddWithValue("@Personal_Adı", d2.personal_adı);
            cmd.Parameters.AddWithValue("@Personal_Soyadı", d2.personal_soyadı);
            return cmd.ExecuteNonQuery();
        }
        public static int PersonalSil(PersonalEL d2)
        {
            OleDbCommand cmd = new OleDbCommand("delete from personal where Id= @Personal_Id", Baglanti.baglantı);
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Personal_Id", d2.personal_ıd);
            return cmd.ExecuteNonQuery();
        }
        public static int PersonalGuncele(PersonalEL d2)
        {
            OleDbCommand cmd = new OleDbCommand("update personal set kullanıcıadı =@personal_kullanıcıadı, adı = @personal_adı, soyadı = @personal_soyadı, şifre = @personal_şifre  where  adı= @personal_adı", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@personal_kullanıcıadı", d2.personal_kullanıcıadı);
            cmd.Parameters.AddWithValue("@personal_adı", d2.personal_adı);
            cmd.Parameters.AddWithValue("@personal_soyadı", d2.personal_soyadı);
            cmd.Parameters.AddWithValue("@personal_şifre", d2.personal_şifre);
            return cmd.ExecuteNonQuery();
        }
        public static PersonalEL personalTextDoldur(PersonalEL g)
        {
            OleDbCommand cmd = new OleDbCommand("select * from personal where adı = @personal_adı", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@personal_adı", g.personal_adı);
            OleDbDataReader okuyucu = cmd.ExecuteReader();
            while (okuyucu.Read())
            {

                g.personal_kullanıcıadı = okuyucu["kullanıcıadı"].ToString();
                g.personal_soyadı = okuyucu["soyadı"].ToString();
                g.personal_şifre = okuyucu["şifre"].ToString();

            }
            okuyucu.Close();
            cmd.Connection.Close();
            return g;
        }
        public static int UygulamaAç(PersonalEL g)
        {
            OleDbCommand cmd = new OleDbCommand("select * from personal where kullanıcıadı= @personal_kullanıcı_adı", Baglanti.baglantı);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@personal_kullanıcı_adı", g.personal_kullanıcıadı);
            OleDbDataReader okuyucu = cmd.ExecuteReader();
            if (okuyucu.Read() == true)
            {
                if (g.personal_kullanıcıadı == okuyucu["kullanıcıadı"].ToString() && g.personal_şifre == okuyucu["şifre"].ToString())
                {
                    cmd.Connection.Close();
                    return 1;
                }
                else
                {
                    cmd.Connection.Close();
                    return -1;
                }
            }

            else
            {
                cmd.Connection.Close();
                return 0;
            }
        }

    }
}
