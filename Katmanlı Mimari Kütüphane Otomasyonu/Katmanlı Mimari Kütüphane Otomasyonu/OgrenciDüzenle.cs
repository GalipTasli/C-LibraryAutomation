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
    public partial class OgrenciDüzenle : Form
    {
        public OgrenciDüzenle()
        {
            InitializeComponent();
        }
        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            telnotextBox.Text = null;
            tcnotextBox.Text = null;
            adrestextBox.Text = null;
            adıtextBox.Text = null;
            soyadıtextBox.Text = null;

        }
        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            //yeni bir öğrenci nesnesi oluşturma
            OgrenciEL Yögrenci = new OgrenciEL()
            {
                ögrenci_telefon = telnotextBox.Text,
                ögrenci_adres = adrestextBox.Text,
                ögrenci_adı = adıtextBox.Text,
                ögrenci_soyadı = soyadıtextBox.Text,
                ögrenci_tc_no = tcnotextBox.Text,
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            OgrenciBL.BLÖgrenciGuncele(Yögrenci);

            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    
        private void tcnotextBox_TextChanged(object sender, EventArgs e)
        {
            if (tcnotextBox.Text.Length == 11)
            {
                OgrenciEL YÖgrenci = new OgrenciEL()
                {
                    ögrenci_tc_no = tcnotextBox.Text,
                };
                OgrenciEL gögrenci = new OgrenciEL();
                gögrenci = OgrenciBL.BLTextDoldur(YÖgrenci);


                adıtextBox.Text = gögrenci.ögrenci_adı;
                telnotextBox.Text = gögrenci.ögrenci_telefon;
                soyadıtextBox.Text = gögrenci.ögrenci_soyadı;
                adrestextBox.Text = gögrenci.ögrenci_adres;

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
