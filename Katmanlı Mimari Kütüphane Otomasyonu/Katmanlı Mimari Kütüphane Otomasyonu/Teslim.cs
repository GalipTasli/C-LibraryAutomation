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
    public partial class Teslim : Form
    {
        public Teslim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i;
            i = dateTimePicker1.Value.ToString();
            //  yeni bir veilenkitap nesnesi oluşturma
            KitapEmanetEL yteslimEL = new KitapEmanetEL()
            {
                tcNo = tcnotextBox2.Text,
                kitap_Id = int.Parse(IdtextBox1.Text),
                teslimZamani = i,

             };
             // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
             KitapEmanetBL.BLKitapAl(yteslimEL);
            OgrenciBL.BLCezaHesapla();
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
