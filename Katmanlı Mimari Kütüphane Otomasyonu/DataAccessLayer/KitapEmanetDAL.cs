using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using EntityLayer;
using System.Windows.Forms;
using System.Data;
namespace DataAccessLayer
{
    public class KitapEmanetDAL
    {
        public static int KitapVer(KitapEmanetEL d2)
        {
            int adet = 1;

            OleDbCommand cmd2 = new OleDbCommand("select * from kitap where Id = @Verilenkitap_Id", Baglanti.baglantı);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@Verilenkitap_Id", d2.kitap_Id);

            OleDbDataReader okuyucu = cmd2.ExecuteReader();
            while (okuyucu.Read())
            {
                adet = int.Parse(okuyucu["adet"].ToString());

            }
            okuyucu.Close();
            cmd2.ExecuteNonQuery();
            cmd2.Connection.Close();

            if (adet == 0)
            {
                MessageBox.Show("aradığnız kitap şu anda kütphanemizde bulunmamaktadır");
            }
            else
            {
             
              
                OleDbCommand cmd = new OleDbCommand("insert into kitapemanet (KitapId,TcNo,VerilmeZamani,IslemYapanKullanıcıId) values (@Verilenkitap_Id,@Verilenkitap_tcno,@Verilenkitap_verilme_zamanı,@Verilenkitap_kullanıcı_id)", Baglanti.baglantı);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.AddWithValue("@Verilenkitap_Id", d2.kitap_Id);
                cmd.Parameters.AddWithValue("@Verilenkitap_tcno", d2.tcNo);
                cmd.Parameters.AddWithValue("@Verilenkitap_verilme_zamanı", d2.verilmeZamani);
                cmd.Parameters.AddWithValue("@Verilenkitap_kullanıcı_id", d2.islemYapanKulaniciId);
                


                adet = adet - 1;

                OleDbCommand cmd3 = new OleDbCommand("update kitap set Adet = @adet where Id = @Verilenkitap_Id ", Baglanti.baglantı);
                cmd3.Parameters.AddWithValue("@adet", adet);
                cmd3.Parameters.AddWithValue("@Verilenkitap_Id", d2.kitap_Id);
                cmd3.ExecuteNonQuery();
                cmd.ExecuteNonQuery();


            }
            return 0;
        }
        public static int KitapAl(KitapEmanetEL T)
        {
            bool t = true;
           
            //  Form ekranından gelen bilgilerle ekleme işlemi
            OleDbCommand cmd = new OleDbCommand("update kitapemanet SET TeslimZamani ='"+T.teslimZamani+ "'and TeslimEdilmeDurumu ="+t+" WHERE KitapId =" + T.kitap_Id+"", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
           /* cmd.Parameters.AddWithValue("@KitapId", T.kitap_Id);
            cmd.Parameters.AddWithValue("@TeslimZamanı", T.teslimZamani);*/
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            OleDbCommand cmd4 = new OleDbCommand("update kitapemanet SET TeslimEdilmeDurumu =" + t + " WHERE KitapId =" + T.kitap_Id + "", Baglanti.baglantı);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.ExecuteNonQuery();
            cmd4.Connection.Close();
            int adet = 1;
            OleDbCommand cmd2 = new OleDbCommand("select * from kitap where Id = @Verilenkitap_Kitap_Id", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd2.Parameters.AddWithValue("@Verilenkitap_Kitap_Id", T.kitap_Id);
            OleDbDataReader okuyucu = cmd2.ExecuteReader();
            while (okuyucu.Read())
            {
                adet = int.Parse(okuyucu["adet"].ToString());

            }

            okuyucu.Close();
            cmd2.ExecuteNonQuery();
            cmd2.Connection.Close();

            adet = adet + 1;
            OleDbCommand cmd3 = new OleDbCommand("update kitap set adet ="+adet+" where Id ="+T.kitap_Id+"", Baglanti.baglantı);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
           /* cmd3.Parameters.AddWithValue("@adet", adet);
            cmd3.Parameters.AddWithValue("@Verilenkitap_Id", T.kitap_Id);*/
            cmd3.ExecuteNonQuery();          
            cmd3.Connection.Close();
           
            return 0;
        }
        
        public static List<KitapEmanetEL> VerilenKitapListele()
        {

            OleDbCommand cmd = new OleDbCommand("select * from kitapemanet ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            string tz;
            OleDbDataReader dr = cmd.ExecuteReader();
            List<KitapEmanetEL> vkitaplar = new List<KitapEmanetEL>();
            while (dr.Read())
            {
                if (bool.Parse(dr["TeslimEdilmeDurumu"].ToString())==false)
                {
                    tz =null;
                }
                else
                {
                    tz =dr["TeslimZamani"].ToString();
                }
                
                // Her öğrenciyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                vkitaplar.Add(new KitapEmanetEL
                {
                    id = int.Parse(dr["Id"].ToString()),
                    kitap_Id = int.Parse(dr["KitapId"].ToString()),
                    islemYapanKulaniciId = int.Parse(dr["IslemYapankullanıcıId"].ToString()),
                    tcNo = dr["TcNo"].ToString(),
                    verilmeZamani = dr["VerilmeZamani"].ToString(),
                    teslimZamani = tz,
                   teslimedilmedurumu= bool.Parse(dr["TeslimEdilmeDurumu"].ToString()),

                });
               
            }
            cmd.Connection.Close();
            return vkitaplar;
        }
        public static DateTime teeslimzamanıdöndür (int d )
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitapemanet Where Id =@Id ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@Id", d);
            DateTime teslim = DateTime.Now;
            OleDbDataReader dr = cmd.ExecuteReader();            
            while (dr.Read())
            {
                if (bool.Parse(dr["TeslimEdilmeDurumu"].ToString()) == true)
                    teslim = (DateTime)dr["TeslimZamani"];                

            }
            
            return teslim;
        }
        public static DateTime emanetzamanidöndür(int d)
        {
            OleDbCommand cmd = new OleDbCommand("select * from kitapemanet Where Id =@Id ", Baglanti.baglantı);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@Id", d);
            DateTime teslim = DateTime.Now;
            OleDbDataReader dr = cmd.ExecuteReader();           
            while (dr.Read())
            {
                
                    teslim = (DateTime)dr["VerilmeZamani"];

            }
            
            return teslim;
        }
    }
}
