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
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //  yeni bir veilenkitap nesnesi oluşturma
            KitapEmanetEL YVerilenKitap = new KitapEmanetEL()
            {
                tcNo = tcnotextBox.Text,
                kitap_Id = int.Parse(kitaptextBox.Text),
                islemYapanKulaniciId = int.Parse(personaltextBox.Text),
                verilmeZamani = dateTimePicker1.Value.ToString(),

            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            KitapEmanetBL.BLKitapVer(YVerilenKitap);
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
