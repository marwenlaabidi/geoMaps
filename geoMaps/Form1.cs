using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geoMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {

            fun();
        }

        LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();

        private void fun()
        {

            Dictionary<string, double> map1 = new Dictionary<string, double>();
            Random random = new Random();
            geoMap.HeatMap.Clear();
            map1.Add(UppercaseFirst(textBox1.Text), random.Next(0, 100));
            geoMap.Source = $"{Application.StartupPath}\\World2.xml";
            geoMap.HeatMap = map1;
            geoMap.EnableZoomingAndPanning = true;
            geoMap.Dock = DockStyle.Fill;
            this.Controls.Add(geoMap);

        }
        private string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fun();
            }
        }
    }
}
