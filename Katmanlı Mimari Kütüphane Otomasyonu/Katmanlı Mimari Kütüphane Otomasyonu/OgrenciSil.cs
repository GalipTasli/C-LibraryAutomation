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
    public partial class OgrenciSil : Form
    {
        public OgrenciSil()
        {
            InitializeComponent();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            //yeni bir Ögrenci nesnesi oluşturma
            OgrenciEL Yögrenci = new OgrenciEL()
            {
                ögrenci_tc_no = tctextBox.Text,
            };
            // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
            OgrenciBL.BLÖgerenciSil(Yögrenci);
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            tctextBox.Text = null;
        }

        private void OgrenciSil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OgrenciBL.BLÖgrenciListele();//öğrencibl deki bütün kayıtları datagrid ile ekrana yazdırıyoruz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();

        }
    }
}
