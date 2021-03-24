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
    public partial class PersonalDüzenle : Form
    {
        public PersonalDüzenle()
        {
            InitializeComponent();
        }

        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            adıtextBox.Text = null;
            soyadıtextBox.Text = null;
            kullanıcıadıtextBox.Text = null;
            şifretextBox.Text = null;

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            //personelel de yeni bir nesne oluşturuyoruz
            PersonalEL Ypersonal = new PersonalEL()
            {
                personal_adı = adıtextBox.Text,
                personal_kullanıcıadı = kullanıcıadıtextBox.Text,
                personal_soyadı = soyadıtextBox.Text,
                personal_şifre = şifretextBox.Text,
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            PersonalBL.BLPersonelGuncele(Ypersonal);
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }

        private void adıtextBox_TextChanged(object sender, EventArgs e)
        {
            PersonalEL Ypersonal = new PersonalEL()
            {
                personal_adı = adıtextBox.Text,
            };
            PersonalEL gpersonal = new PersonalEL();
            gpersonal = PersonalBL.BLTextDoldur(Ypersonal);
            soyadıtextBox.Text = gpersonal.personal_soyadı;
            kullanıcıadıtextBox.Text = gpersonal.personal_kullanıcıadı;
            şifretextBox.Text = gpersonal.personal_şifre;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
