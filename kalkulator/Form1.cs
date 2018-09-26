using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class kalkulator : Form
    {
        public kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnHitung_click(object sender, EventArgs e)
        {
            int a = int.Parse(nilai1.Text);
            var b = Convert.ToInt32(nilai2.Text);
            Double hasil;
            switch (cmboperasi.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    lsthasil.Text = Convert.ToString(hasil);
                    break;
                case 1:
                    hasil = a - b;
                    lsthasil.Text = Convert.ToString(hasil);
                    break;
                case 2:
                    hasil = a * b;
                    lsthasil.Text = Convert.ToString(hasil);
                    break;
                case 3:
                    hasil = a / b;
                    lsthasil.Text = Convert.ToString(hasil);
                    break;
            }
        }
    }
}