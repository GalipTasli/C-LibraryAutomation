using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            türütextBox.Text = null;
            isimtextBox.Text = null;
            sayfatextBox.Text = null;
            yazartextbox.Text = null;
            adettextBox.Text = null;

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            //  yeni bir kitap nesnesi oluşturma
            KitapEL ykitap = new KitapEL()
            {
                kitap_adet = int.Parse(adettextBox.Text),
                kitap_basım_tarihi = dateTimePicker1.Value.ToString(),
                kitap_isim = isimtextBox.Text,
                kitap_sayfa = int.Parse(sayfatextBox.Text),
                kitap_türü = türütextBox.Text,
                kitap_yazar = yazartextbox.Text,

            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            KitapBL.BLKitapEkle(ykitap);
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
