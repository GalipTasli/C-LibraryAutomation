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
    public partial class PersonalSil : Form
    {
        public PersonalSil()
        {
            InitializeComponent();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            ıdtextBox.Text = null;
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            //yeni bir personal nesnesi oluşturma
            PersonalEL Ypersonel = new PersonalEL()
            {
                personal_ıd = int.Parse(ıdtextBox.Text),
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            PersonalBL.BLPersonalSil(Ypersonel);
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
