using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;


namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    public partial class KitapDüzenle : Form
    {
        public KitapDüzenle()
        {
            InitializeComponent();
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            adettextBox.Text = null;
            isimtextBox.Text = null;
            yazartextbox.Text = null;
            sayfatextBox.Text = null;
            türütextBox.Text = null;

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            // yeni bir kitap nesnesi oluşturma
            KitapEL Ykitap = new KitapEL()
            {
                kitap_adet = int.Parse(adettextBox.Text),
                kitap_basım_tarihi = dateTimePicker1.Value.ToString(),
                kitap_isim = isimtextBox.Text,
                kitap_sayfa = int.Parse(sayfatextBox.Text),
                kitap_türü = türütextBox.Text,
                kitap_yazar = yazartextbox.Text,
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            KitapBL.BLKitapGuncele(Ykitap);
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();
        }

        private void isimtextBox_TextChanged(object sender, EventArgs e)
        {
            KitapEL Ykitap = new KitapEL()
            {
                kitap_isim = isimtextBox.Text,
            };
            KitapEL Gkitap = new KitapEL();
            Gkitap = KitapBL.BLTextDoldur(Ykitap);
            if (Gkitap.kitap_yazar != null)
            {
                yazartextbox.Text = Gkitap.kitap_yazar;
                sayfatextBox.Text = Gkitap.kitap_sayfa.ToString();
                adettextBox.Text = Gkitap.kitap_adet.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(Gkitap.kitap_basım_tarihi);
                türütextBox.Text = Gkitap.kitap_türü;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
