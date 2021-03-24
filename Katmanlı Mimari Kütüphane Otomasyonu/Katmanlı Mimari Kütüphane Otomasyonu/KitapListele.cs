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
    public partial class KitapListele : Form
    {
        public KitapListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEmanetEL ykitap = new KitapEmanetEL()
            {
                kitap_Id = int.Parse(textBox1.Text),
            };
            dataGridView2.DataSource = KitapBL.BLKitapDetayListele(ykitap);
         

        }

        private void KitapListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KitapBL.BLKitapListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();
        }
    }
}
