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
    public partial class PersonalEkle : Form
    {
        public PersonalEkle()
        {
            InitializeComponent();
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            adıtextBox.Text = null;
            soyadıtextBox.Text = null;
            kullanıcıadıtextBox.Text = null;
            şifretextBox.Text = null;

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            //  yeni bir personal nesnesi oluşturma
            PersonalEL Ypersonal = new PersonalEL()
            {
                personal_adı = adıtextBox.Text,
                personal_kullanıcıadı = kullanıcıadıtextBox.Text,
                personal_soyadı = soyadıtextBox.Text,
                personal_şifre = şifretextBox.Text,
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            PersonalBL.BLPersonelEkle(Ypersonal);
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
