using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class KitapDAL
    {

        public static int KitapEkle(KitapEL d)
        {
            OleDbCommand cmd = new OleDbCommand("insert into kitap(Isim,Yazar,Sayfa,Adet,BasımTarihi,KitapTürü) values (@Kitap_Isim,@Kitap_yazar,@Kitap_sayfa,@Kitap_adet,@Kitap_basım_tarihi,@Kitap_türü)", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Kitap_Isim", d.kitap_isim);
            cmd.Parameters.AddWithValue("@Kitap_yazar", d.kitap_yazar);
            cmd.Parameters.AddWithValue("@Kitap_sayfa", d.kitap_sayfa);
            cmd.Parameters.AddWithValue("@Kitap_adet", d.kitap_adet);
            cmd.Parameters.AddWithValue("@Kitap_basım_tarihi", d.kitap_basım_tarihi);
            cmd.Parameters.AddWithValue("@Kitap_türü", d.kitap_türü);
            return cmd.ExecuteNonQuery();
        }
        public static int KitapSil(KitapEL d)
        {
            //kitap sil formundan gelen bilgilerle yeni kitap silme
            OleDbCommand cmd = new OleDbCommand("delete from kitap where Id=@kitap_Id", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Kitap_Id", d.kitap_Id);
            return cmd.ExecuteNonQuery();
        }
        public static int KitapGuncele(KitapEL d)
        {
            //kitap düzenle formundan gelen bilgilerle günceleme
            OleDbCommand cmd = new OleDbCommand("update kitap set Isim =@Kitap_ismi,Yazar=@Kitap_yazar,Sayfa=@Kitap_sayfa,Adet=@Kitap_adet,BasımTarihi=@Kitap_basımtarihi,KitapTürü=@Kitap_türü where Isim=@Kitap_ismi", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Kitap_ismi", d.kitap_isim);
            cmd.Parameters.AddWithValue("@Kitap_yazar", d.kitap_yazar);
            cmd.Parameters.AddWithValue("@Kitap_sayfa", d.kitap_sayfa);
            cmd.Parameters.AddWithValue("@Kitap_adet", d.kitap_adet);
            cmd.Parameters.AddWithValue("@Kitap_basımtarihi", d.kitap_basım_tarihi);
            cmd.Parameters.AddWithValue("@Kitap_türü", d.kitap_türü);
            return cmd.ExecuteNonQuery();
        }
        public static KitapEL kitapTextDoldur(KitapEL g)
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitap where Isim =@kitap_isim", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@kitap_isim", g.kitap_isim);
            OleDbDataReader okuyucu = cmd.ExecuteReader();
            while (okuyucu.Read())
            {
                MessageBox.Show(okuyucu["BasımTarihi"].ToString());
                g.kitap_yazar = okuyucu["Yazar"].ToString();
                g.kitap_sayfa = int.Parse(okuyucu["Sayfa"].ToString());
                g.kitap_adet = int.Parse(okuyucu["Adet"].ToString());
                g.kitap_türü = okuyucu["KitapTürü"].ToString();
                g.kitap_basım_tarihi = okuyucu["BasımTarihi"].ToString();

            }
            okuyucu.Close();
            return g;
        }
        public static List<KitapEL> KitapListele()
        {

            OleDbCommand cmd = new OleDbCommand("select * from kitap ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            List<KitapEL> kitaplar = new List<KitapEL>();
            while (dr.Read())
            {
                // Her doktoru birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                kitaplar.Add(new KitapEL
                {
                    kitap_adet = int.Parse(dr["Adet"].ToString()),
                    kitap_basım_tarihi = dr["BasımTarihi"].ToString(),
                    kitap_Id = int.Parse(dr["Id"].ToString()),
                    kitap_isim = dr["Isim"].ToString(),
                    kitap_sayfa = int.Parse(dr["Sayfa"].ToString()),
                    kitap_türü = dr["KitapTürü"].ToString(),
                    kitap_yazar = dr["Yazar"].ToString(),
                });
            }
            return kitaplar;
        }
        public static List<KitapEmanetEL> KitapDetayListele(KitapEmanetEL g)
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitapemanet Where KitapId = @kitap_Id", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@kitap_Id", g.kitap_Id);
            OleDbDataReader dr = cmd.ExecuteReader();
            List<KitapEmanetEL> ögrenciler = new List<KitapEmanetEL>();
            while (dr.Read())
            {
                // Her doktoru birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                ögrenciler.Add(new KitapEmanetEL
                {
                    id = int.Parse(dr["Id"].ToString()),
                    kitap_Id = int.Parse(dr["KitapId"].ToString()),
                    islemYapanKulaniciId = int.Parse(dr["IslemYapanKullanıcıId"].ToString()),
                    tcNo = dr["TcNo"].ToString(),
                    verilmeZamani = dr["VerilmeZamani"].ToString(),
                    teslimZamani = dr["TeslimZamani"].ToString(),
                });
            }
            return ögrenciler;
        }
        public static int romansay()
        {

            OleDbCommand cmd = new OleDbCommand("select * from kitap where KitapTürü = 'roman'", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac = sayac + int.Parse(dr["Adet"].ToString());
            }
            return sayac;
        }
        public static int tromansay()
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitap where KitapTürü = 'roman'", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac = say(int.Parse(dr["Id"].ToString())) + sayac;
            }
            return sayac;
        }
        public static int say(int kıd)
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitapemanet where KitapId = " + kıd + " ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            bool kontrol;
            while (dr.Read())
            {
                kontrol = bool.Parse(dr["TeslimEdilmeDurumu"].ToString());

                sayac = sayac + 1;
            }
            return sayac;
        }
        public static int öyküsay()
        {

            OleDbCommand cmd = new OleDbCommand("select * from kitap where KitapTürü = 'öykü'", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac = sayac + int.Parse(dr["Adet"].ToString());
            }
            return sayac;
        }
        public static int töyküsay()
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitap where KitapTürü = 'öykü'", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac = say(int.Parse(dr["Id"].ToString())) + sayac;
            }
            return sayac;
        }
        public static int derskitabısay()
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitap where KitapTürü = 'derskitabı'", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac = sayac + int.Parse(dr["Adet"].ToString());
            }
            return sayac;
        }
        public static int tderskitabısay()
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitap where KitapTürü = 'derskitabı'", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            int sayac = 0;
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac = say(int.Parse(dr["Id"].ToString())) + sayac;
            }
            return sayac;
        }
    }
}

