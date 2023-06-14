using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW_kolokwium
{
    public partial class Form1 : Form
    {
        public string plec = "";
        public double pal = 0;
        public double ppm = 0;
        List<bmi> bmi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (woman.Checked)
            {
                ppm = (double.Parse(waga.Text) * 10) + (6.25 * double.Parse(wzrost.Text)) - (5 * double.Parse(wiek.Text)) -161;
                plec = "k";
                if (lista.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if (lista.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (lista.SelectedIndex == 2)
                {
                    pal = 1.5;
                }
                else if (lista.SelectedIndex == 3)
                {
                    pal = 1.6;
                }
                else if (lista.SelectedIndex == 4)
                {
                    pal = 1.9;
                }
                else if (lista.SelectedIndex == 5)
                {
                    pal = 2.2;
                }
            }
            else
            {
                ppm = (double.Parse(waga.Text) * 10) + (6.25 * double.Parse(wzrost.Text)) - (5 * double.Parse(wiek.Text)) + 5;
                plec = "m";
                if (lista.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if (lista.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (lista.SelectedIndex == 2)
                {
                    pal = 1.6;
                }
                else if (lista.SelectedIndex == 3)
                {
                    pal = 1.7;
                }
                else if (lista.SelectedIndex == 4)
                {
                    pal = 2.1;
                }
                else if (lista.SelectedIndex == 5)
                {
                    pal = 2.4;
                }
            }
            
            bmi bmi_2 = new bmi()
            {
                Wiek = double.Parse(wiek.Text),
                Waga = double.Parse(waga.Text),
                Wzrost = double.Parse(wzrost.Text),
                Plec = plec,
                Bmi = double.Parse(waga.Text) / Math.Pow(double.Parse(wzrost.Text) / 100, 2),
                Ppm = ppm,
                Cpm = pal * ppm,
                Aktywnosc = lista.SelectedItem.ToString(),
            };
            MessageBox.Show(bmi_2.wyswietlBMI());
        }

        private void waga_ValueChanged(object sender, EventArgs e)
        {
            waga.Maximum = 700;
        }

        private void wiek_ValueChanged(object sender, EventArgs e)
        {
            wiek.Minimum = 18;
            wiek.Maximum = 99;
        }

        private void wzrost_ValueChanged(object sender, EventArgs e)
        {
            wzrost.Maximum = 300;
        }
    }
}
