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
    public partial class KitapSil : Form
    {
        public KitapSil()
        {
            InitializeComponent();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            //yeni bir kitap nesnesi oluşturma
            KitapEL Ykitap = new KitapEL()
            {
                kitap_Id = int.Parse(kitapıdtextBox.Text),
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            KitapBL.BLKitapSil(Ykitap);
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();


        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            kitapıdtextBox.Text = null;
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KitapBL.BLKitapListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
