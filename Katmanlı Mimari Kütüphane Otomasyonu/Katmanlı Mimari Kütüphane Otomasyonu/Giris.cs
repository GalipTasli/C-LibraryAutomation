using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using EntityLayer;
using BusinessLayer;

namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void girişbutton_Click(object sender, EventArgs e)
        {
            //textbox ta girilen bilgiler kontrol ediliyor
            if (kullanıcıadıtextBox.Text == "" && şifretextBox.Text == "")
            {
                MessageBox.Show("lütfen bilgilerinizi giriniz");
            }
            else if (kullanıcıadıtextBox.Text == "")
            {
                MessageBox.Show("lütfen kullanıcıadı bilginizi giriniz");
            }
            else if (şifretextBox.Text == "")
            {
                MessageBox.Show("lütfen şifre bilginizi giriniz");
            }
            else
            {
                //yeni personel nesnesi oluşturma
                PersonalEL Ypersonel = new PersonalEL()
                {//texboxtaki bilgiler el katmanı sayesinde dal katmanına gönderiliyor
                    personal_kullanıcıadı = kullanıcıadıtextBox.Text,
                    personal_şifre = şifretextBox.Text,
                };
                if (PersonalBL.BLUygulamaAÇ(Ypersonel) == 1)
                {//anamenuye yönlendirilyorsunuz
                    Form AnaMenu = new AnaMenu();
                    AnaMenu.Show();
                    this.Hide();
                }
                else if (PersonalBL.BLUygulamaAÇ(Ypersonel) == -1)
                {
                    MessageBox.Show("Lütfen kullanıcı adı veya şifreyi kontrol ediniz.");
                }
                else
                {
                    MessageBox.Show("bağlantı hatası oluştu lütfen uygulamayı tekrar çalıştırınız");
                }

            }
        }

        private void çıkışbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

    }
}

