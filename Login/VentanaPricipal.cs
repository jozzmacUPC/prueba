using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Windows.Forms.DataVisualization.Charting;
namespace Login
{
    public partial class VentanaPricipal : Form
    {
        public VentanaPricipal()
        {
            InitializeComponent();
        }

        private void VentanaPricipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCuerpo_Paint(object sender, PaintEventArgs e)
        {
            List<CDGrafica> datosSeries = new List<CDGrafica>
            {
                new CDGrafica
            {
                mes = "JAN",
                Serie1 = 29.9m,
                Serie2 = 144.0m
            },
                new CDGrafica
            {
                mes = "FEB",
                Serie1 = 71.5m,
                Serie2 = 176.0m
            },
                new CDGrafica
            {
                mes = "MAR",
                Serie1 = 106.4m,
                Serie2 = 135.6m
            },
                new CDGrafica
            {
                mes = "APR",
                Serie1 = 129.2m,
                Serie2 = 148.5m
            },
                new CDGrafica
            {
                mes = "MAY",
                Serie1 = 144.0m,
                Serie2 = 216.4m
            },
                new CDGrafica
            {
                mes = "JUN",
                Serie1 = 176.0m,
                Serie2 = 194.1m
            },
            };
            Chart tabla = new Chart();

            tabla.Dock = DockStyle.Fill;
            tabla.ChartAreas.Add(new ChartArea());

            tabla.DataBindTable(datosSeries, "mes");
            tabla.Series[0].ChartType = SeriesChartType.Line;
            tabla.Series[1].ChartType = SeriesChartType.Line;
            Controls.Add(tabla);

            //chart1.Series.Clear();
            //chart1.DataBindTable(datosSeries, "mes");
            //chart1.Series[0].ChartType = SeriesChartType.Line;
            //chart1.Series[1].ChartType = SeriesChartType.Line;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
