using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_baslat_Click(object sender, EventArgs e)
        {
            Algoritma a = new Algoritma((int)nm_populasyon.Value,(double)nm_carprazlama.Value, 
                (double)nm_mutasyon.Value, (double)nm_seckinlik.Value, (int)nm_jenerasyon.Value);

            a.Calistir();

            List<Kromozom> list = a.en_iyi_sonuclar;

            chart1.Series.Clear();
            chart1.Series.Add("F(x)");
            foreach (var kromozom in list)
            {
                chart1.Series["F(x)"].Points.AddY(kromozom.fx);
            }

            double max = list.Max(x => x.fx);
            double min = list.Min(x => x.fx);

            chart1.ChartAreas[0].AxisY.Maximum = max * 1.2;
            chart1.ChartAreas[0].AxisY.Minimum = min - (max-min)/4;
            chart1.ChartAreas[0].AxisX.Maximum = a.jenerasyon_sayisi;
            chart1.Series["F(x)"].Color = Color.Blue;
            chart1.Series["F(x)"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Kromozom minFxKromozom = list.OrderBy(k => k.fx).First();
            double minX = minFxKromozom.x;
            double minY = minFxKromozom.y;
            double minFx = minFxKromozom.fx;

            lbl_x.Text = minX.ToString();
            lbl_y.Text = minY.ToString();
            lbl_fx.Text = minFx.ToString();
        }
    }
}
