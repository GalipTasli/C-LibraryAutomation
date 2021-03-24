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
    public class OgrenciDAL
    {
        public static int ÖgrenciEkle(OgrenciEL g)
        {
            int ceza=0;
            //  Form ekranından gelen bilgilerle ekleme işlemi
            OleDbCommand cmd = new OleDbCommand("insert into ogrenci(TcNo,Adı,Soyadı,Telefon,Adres) values (@Ögrenci_Tc_No,@Ögrenci_Adı,@Ögrenci_Soyadı,@Ögrenci_Telefon,@Ögrenci_Adres)", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Ögrenci_Tc_No", g.ögrenci_tc_no);
            cmd.Parameters.AddWithValue("@Ögrenci_Adı", g.ögrenci_adı);
            cmd.Parameters.AddWithValue("@Ögrenci_Soyadı", g.ögrenci_soyadı);
            cmd.Parameters.AddWithValue("@Ögrenci_Telefon", g.ögrenci_telefon);
            cmd.Parameters.AddWithValue("@Ögrenci_Adres", g.ögrenci_adres);
            cmd.Parameters.AddWithValue("@ceza", ceza);
            return cmd.ExecuteNonQuery();
        }
        public static int ÖgrenciSil(OgrenciEL g)
        {
            //  Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From ogrenci Where TcNo  = @Ögrenci_Tc_No ", Baglanti.baglantı);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@Ögrenci_Tc_No", g.ögrenci_tc_no);
            int ret;
            ret = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return ret; // Komutları işle.
        }
        public static int ÖgrenciGüncele(OgrenciEL g)
        {
            //  Form ekranından gelen bilgilerle günceleme işlemi
            OleDbCommand cmd = new OleDbCommand("update ogrenci set TcNo=@Ögrenci_Tc_No, Adı=@Ögrenci_Adı , Soyadı= @Ögrenci_Soyadı, Telefon =@Ögrenci_Telefon, Adres= @Ögrenci_Adres where TcNo= @Ögrenci_Tc_No ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@Ögrenci_Tc_No", g.ögrenci_tc_no);
            cmd.Parameters.AddWithValue("@Ögrenci_Adı", g.ögrenci_adı);
            cmd.Parameters.AddWithValue("@Ögrenci_Soyadı", g.ögrenci_soyadı);
            cmd.Parameters.AddWithValue("@Ögrenci_Telefon", g.ögrenci_telefon);
            cmd.Parameters.AddWithValue("@Ögrenci_Adres", g.ögrenci_adres);
            return cmd.ExecuteNonQuery();
        }
        public static OgrenciEL ÖgrenciTextDoldur(OgrenciEL g)
        {
            OleDbCommand cmd = new OleDbCommand("select * from ogrenci where TcNo = @Ögrenci_Tc_No", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@Ögrenci_Tc_No", g.ögrenci_tc_no);
            OleDbDataReader okuyucu = cmd.ExecuteReader();

            while (okuyucu.Read())
            {

                g.ögrenci_adı = okuyucu["Adı"].ToString();
                g.ögrenci_telefon = okuyucu["Telefon"].ToString();
                g.ögrenci_soyadı = okuyucu["Soyadı"].ToString();
                g.ögrenci_adres = okuyucu["Adres"].ToString();
            }
            okuyucu.Close();

            return g;
        }
        public static List<OgrenciEL> ÖgrenciListele()
        {

            OleDbCommand cmd = new OleDbCommand("select * from ogrenci ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            List<OgrenciEL> öğrenciler = new List<OgrenciEL>();
            while (dr.Read())
            {
                // Her öğrenciyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                öğrenciler.Add(new OgrenciEL
                {
                    ögrenci_tc_no = dr["TcNo"].ToString(),
                    ögrenci_adı = dr["Adı"].ToString(),
                    ögrenci_soyadı = dr["Soyadı"].ToString(),
                    ögrenci_telefon = dr["Telefon"].ToString(),
                    ögrenci_adres = dr["Adres"].ToString(),
                    ögrenci_ceza = int.Parse(dr["Ceza"].ToString()),

                });
            }
            return öğrenciler;
        }
        public static List<KitapEmanetEL> ögrenciDetayListele(KitapEmanetEL g)
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitapemanet Where TcNo = @tcno", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@tcno", g.tcNo);
            OleDbDataReader dr = cmd.ExecuteReader();
            List<KitapEmanetEL> ögrenciler = new List<KitapEmanetEL>();
            while (dr.Read())
            {
                if (bool.Parse(dr["teslimedilmedurumu"].ToString()) == true)
                {
                    ögrenciler.Add(new KitapEmanetEL
                    {

                        id = int.Parse(dr["Id"].ToString()),
                        kitap_Id = int.Parse(dr["KitapId"].ToString()),
                        islemYapanKulaniciId = int.Parse(dr["IslemYapanKullanıcıId"].ToString()),
                        tcNo = dr["TcNo"].ToString(),
                        verilmeZamani = dr["VerilmeZamani"].ToString(),
                        teslimedilmedurumu = bool.Parse(dr["teslimedilmedurumu"].ToString()),
                        teslimZamani= dr["teslimZamani"].ToString(),

                    });
                }
                else
                {
                    ögrenciler.Add(new KitapEmanetEL
                    {

                        id = int.Parse(dr["Id"].ToString()),
                        kitap_Id = int.Parse(dr["KitapId"].ToString()),
                        islemYapanKulaniciId = int.Parse(dr["IslemYapanKullanıcıId"].ToString()),
                        tcNo = dr["TcNo"].ToString(),
                        verilmeZamani = dr["VerilmeZamani"].ToString(),
                        teslimedilmedurumu = bool.Parse(dr["teslimedilmedurumu"].ToString()),

                    });
                }
            }
            return ögrenciler;
        }
        public static int CezaHesapla()
        {   
            OleDbCommand cmd1 = new OleDbCommand("select * from kitapemanet", Baglanti.baglantı);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            OleDbDataReader okuyucu = cmd1.ExecuteReader();
            double ceza;
            string geçici;
           
            while (okuyucu.Read())
            {
                string tz = okuyucu["TeslimZamani"].ToString();
                DateTime vz = (DateTime)okuyucu["VerilmeZamani"];
                string tc = okuyucu["TcNo"].ToString();
                bool durum = bool.Parse(okuyucu["TeslimEdilmeDurumu"].ToString());
                
                if (durum== true )
                {

                    if (vz.AddDays(8) < Convert.ToDateTime(tz))
                    {
                        geçici = (vz - Convert.ToDateTime(tz)).TotalDays.ToString();
                        ceza = double.Parse(geçici) + 8;
                        CezaOluştur(ceza, tc);
                    }
                    else
                    {
                        ceza = 0;
                        CezaOluştur(ceza, tc);
                    }
                }
                else
                {
                    tz = DateTime.Today.ToShortDateString();
                   
                    
                    if (vz.AddDays(8) < Convert.ToDateTime(tz))
                    {
                        geçici = (vz - Convert.ToDateTime(tz)).TotalDays.ToString();
                        ceza = double.Parse(geçici) + 8;
                        CezaOluştur(ceza, tc);
                    }
                    else
                    {
                        ceza = 0;
                        CezaOluştur(ceza, tc);
                    }

                }
            }
            okuyucu.Close();
            cmd1.Connection.Close();
            return 0;
        }
        public static void CezaOluştur(double ceza, string tc)//oluştur yap
        {
           
            OleDbCommand cmd2 = new OleDbCommand("select * from ogrenci", Baglanti.baglantı);
        
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            double dceza;
            //int c;
            while (dr2.Read())
            {
                if(tc==dr2["TcNo"].ToString())
                {
                    dceza = double.Parse(dr2["Ceza"].ToString()) + ceza;
                    CezaKaydet(dceza, tc);
                }
               
            }
            dr2.Close();
            

        }
        public static void CezaKaydet(double ceza, string tc)
        {
         
            OleDbCommand cmd = new OleDbCommand("update ogrenci set Ceza=@ceza where TcNo=@tc", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
           
            
            cmd.Parameters.AddWithValue("@ceza", ceza.ToString());
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.ExecuteNonQuery();
        }

    }
}
