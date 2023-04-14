using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace homework_4
{
    public partial class timeConverter : Form
    {

        String ioperation;
        Double Seconds, Minutes, Hours, Mins;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "MS";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "MH";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "HM";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (ioperation)
            {
                case "SM":
                    Seconds = Double.Parse(txtBxInput.Text);
                    lblResult.Text = (Seconds / 60).ToString();
                    break;
                case "MS":
                    Minutes = Double.Parse(txtBxInput.Text);
                    lblResult.Text = (Minutes * 60).ToString();
                    break;
                case "MH":
                    Mins = Double.Parse(txtBxInput.Text);
                    lblResult.Text = (Mins / 60).ToString();
                    break;
                case "HM":
                    Hours = Double.Parse(txtBxInput.Text);
                    lblResult.Text = (Hours + 60).ToString();
                    break;
                default:
                    break;
            }

        }

        public timeConverter()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "SM";
        }
    }
}
