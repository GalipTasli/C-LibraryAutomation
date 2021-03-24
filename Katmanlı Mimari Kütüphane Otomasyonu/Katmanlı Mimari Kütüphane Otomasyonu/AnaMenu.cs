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
    public partial class AnaMenu : Form
    {
        int Id;
        int KitapId;
        bool BOOLteslim;

        public AnaMenu()
        {
            InitializeComponent();
        }  

        private void ekleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form KitapEkle = new KitapEkle();
            KitapEkle.Show();
            this.Close();
        }

        private void teslimbutton_Click_1(object sender, EventArgs e)
        {
            Form Teslim = new Teslim();
            Teslim.Show();
            this.Close();
        }

        private void Emanetbutton_Click_1(object sender, EventArgs e)
        {
            Form Emanet = new Emanet();
            Emanet.Show();
            this.Close();
        }

        private void personalDüzenleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form PersonalDüzenle = new PersonalDüzenle();
            PersonalDüzenle.Show();
            this.Close();
        }

        private void personalEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form PersonalEkle = new PersonalEkle();
            PersonalEkle.Show();
            this.Close();
        }

        private void personalSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form PersonalSil = new PersonalSil();
            PersonalSil.Show();
            this.Close();
        }

        private void düzenleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form ÖgrenciDüzenle = new OgrenciDüzenle();
            ÖgrenciDüzenle.Show();
            this.Close();
        }

        private void listeleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form ÖgrenciListele = new OgrenciListele();
            ÖgrenciListele.Show();
            this.Close();
        }

        private void silToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form ÖgrenciSil = new OgrenciSil();
            ÖgrenciSil.Show();
            this.Close();
        }

        private void ekleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form ÖgrenciEkle = new OgrenciEkle();
            ÖgrenciEkle.Show();
            this.Close();
        }

        private void düzenleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form KitapDüzenle = new KitapDüzenle();
            KitapDüzenle.Show();
            this.Close();
        }

        private void listeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form KitapListele = new KitapListele();
            KitapListele.Show();
            this.Close();
        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form KitapSil = new KitapSil();
            KitapSil.Show();
            this.Close();
        }

        private void AnaMenu_Load_1(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = KitapEmanetBL.BLVerilenKitapListele();
           
        }
      

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            //burada tablo değerlerine göre tablo üzerinde işlemler yapılıyor
            dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;

            Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            KitapId = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            BOOLteslim = bool.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            //kitapemaneten bir nene üretiiyor
            KitapEmanetEL kitapt = new KitapEmanetEL()
            {
                id = Id,
                kitap_Id = KitapId,
            };
            DateTime now = DateTime.Now;
            DateTime alinmaT = KitapEmanetBL.BLemanettarihdündür(Id);
            DateTime teslimT = KitapEmanetBL.BLteslimtarihdündür(Id);

            if (BOOLteslim == true)
            {
                TimeSpan Sonuc = teslimT - alinmaT;
                if (Sonuc.TotalDays > 8)// Sonuc degerinin 8 ten büyük olması durumu
                {
                    // DataGrid satirini kırmızı renge boyanma işlemi
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;

                }
                if (Sonuc.TotalDays < 8 && Sonuc.TotalDays > 1)//Sonuc 8 ile 1 arası olması durumunda
                {
                    // DataGrid satirini yeşil renge boyanma işlemi
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                }
            }
            else
            {
                TimeSpan Sonuc2 = now - alinmaT;
                if (Sonuc2.TotalDays >= 6 && Sonuc2.TotalDays <= 8)//Sonuc 6 ve 8 arası olması durumunda
                {
                    // DataGrid satirini sari renge boyanma işlemi
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;

                }
                else if (Sonuc2.TotalDays > 8)
                {
                    // DataGrid satirini kırmızı renge boyanma işlemi
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitap_ögrenci_grafiği = new kitap_ögrenci_grafiği();
            kitap_ögrenci_grafiği.Show();
            this.Close();
        }
    }
}
