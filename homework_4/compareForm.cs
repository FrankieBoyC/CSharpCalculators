using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_4
{
    public partial class compareForm : Form
    {
        public compareForm()
        {
            InitializeComponent();
        }
        public compareForm(string passedValue)
        {
            InitializeComponent();
            txtBxCalc.Text = passedValue;
        }

        private void bttnCompare_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtBxCalc.Text);
            string s1 = txtBxInput.Text;
            double num2 = Double.Parse(s1);
            double large = Math.Max(num1, num2);
            lblResult.Text = large.ToString();
        }
    }
}
