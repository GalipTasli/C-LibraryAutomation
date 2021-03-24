using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BusinessLayer;

namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    public partial class kitap_ögrenci_grafiği : Form
    {
        public kitap_ögrenci_grafiği()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
        private void kitap_ögrenci_grafiği_Load(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl2);
            // Size the control to fill the form with a margin
            SetSize();
        }
         private void SetSize()
        {
            zedGraphControl2.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl2.Size = new Size(ClientRectangle.Width - 20,
                                    ClientRectangle.Height - 20);
        }
       

        // Build the Chart
        private void CreateGraph(ZedGraphControl zg1)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zg1.GraphPane;

            // Set the Titles
            myPane.Title.Text = "kitap grafiği";
            myPane.XAxis.Title.Text = "Label";
            myPane.YAxis.Title.Text = "My Y Axis";
            int roman1 = KitapBL.BLromansasy();
            int roman2 = KitapBL.BLtromansay();
            int roman3 = roman1 + roman2;
            int öykü1 = KitapBL.BLöyküasay();
            int öykü2 = KitapBL.BLtöyküsay();
            int öykü3 = öykü1 + öykü2;
            int ders1 = KitapBL.BLderskitabısay();
            int ders2 = KitapBL.BLtderskitabısay();
            int dres3 = ders1 + ders2;
            // Make up some random data points
            string[] labels = { "roman", "öykü", "derskitabı" };
            double[] y = { roman1, öykü1, ders1 };
            double[] y2 = { roman2, öykü2, ders2 };
            double[] y3 = { roman3, öykü3, dres3 };
           
            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = myPane.AddBar("Teslim edilen kitap sayısı ", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = myPane.AddBar("Teslim edilmeyen kitap sayısı", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White,
                                                        Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            myBar = myPane.AddBar("Toplam Kitap sayısı", null, y3, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White,
                                                        Color.Green);

           

        
            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            myPane.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zg1.AxisChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AnaMenu = new AnaMenu();
            AnaMenu.Show();
            this.Close();
        }
    }
}
