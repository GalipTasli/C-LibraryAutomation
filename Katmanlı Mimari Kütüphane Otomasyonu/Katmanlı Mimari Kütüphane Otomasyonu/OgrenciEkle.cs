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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            //  yeni bir ögrenci nesnesi oluşturma
            OgrenciEL yögrenci = new OgrenciEL()
            {
                ögrenci_adres = adrestextBox.Text,
                ögrenci_adı = adıtextBox.Text,
                ögrenci_soyadı = soyadıtextBox.Text,
                ögrenci_tc_no = tcnotextBox.Text,
                ögrenci_telefon = telnotextBox.Text,
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            OgrenciBL.BLÖgrenciEkle(yögrenci);

            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();


        }

        private void Temizlebutton_Click(object sender, EventArgs e)
        {

            telnotextBox.Text = null;
            tcnotextBox.Text = null;
            adrestextBox.Text = null;
            adıtextBox.Text = null;
            soyadıtextBox.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
