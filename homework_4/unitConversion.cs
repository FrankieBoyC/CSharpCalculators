using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace homework_4
{
    public partial class unitConversion : Form
    {

        Double Celsius, Fahrenheit, Kelvin;
        Double Kilo, Liter, Milileter, Gram, Centimeter;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "FC";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "K";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "KG";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "GK";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "LM";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "ML";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "KM";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "MK";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "MF";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "FI";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "CM";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (ioperation)
            {
                case "KM":
                    Kilometer = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((1000 * Kilometer).ToString());
                    break;
                case "MK":
                    Meter = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((Meter / 1000).ToString());
                    break;
                case "MF":
                    Inches = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((3 * Inches).ToString());
                    break;
                case "FI":
                    Feet = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((Feet * 12).ToString());
                    break;
                case "KG":
                    Kilo = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((1000 * Kilo).ToString());
                    break;
                case "GK":
                    Gram = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((Gram / 1000).ToString());
                    break;
                case "LM":
                    Liter = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((1000 * Liter).ToString());
                    break;
                case "ML":
                    Milileter = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((Milileter / 1000).ToString());
                    break;
                case "CM":
                    Centimeter = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((Centimeter / 100).ToString());
                    break;
                case "CF":
                    Celsius = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * Celsius) / 5) + 32).ToString());
                    break;
                case "FC":
                    Fahrenheit = Double.Parse(txtConvert.Text);
                    lblConvert.Text = ((((Fahrenheit - 32) * 5) / 9).ToString());
                    break;
                case "K":
                    Kelvin = Double.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9 * Kelvin) / 5) + 32) + 273.15).ToString());
                    break;
                default:
                    break;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "CF";
        }

        Double Kilometer, Meter, Inches, Feet;

        String ioperation;
        public unitConversion()
        {
            InitializeComponent();
        }

        // dont use this
        private void btnConvert_Click(object sender, EventArgs e)
        {
            
        }

        private void unitConversion_Load(object sender, EventArgs e)
        {

        }
    }
}
