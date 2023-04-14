namespace homework_4
{
    public partial class Form1 : Form
    {

        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void bttn8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//this is button zero
        {
            if ((txtResult.Text == "0") || (operation_pressed))
                txtResult.Clear();

            Button b = (Button)sender;
            txtResult.Text = txtResult.Text + b.Text;
        }
        
        private void operationButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtResult.Text);
            operation_pressed = true;
        }

        private void bttnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "+":
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "X":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;

        }



        private void compareFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            compareForm f2 = new compareForm(txtResult.Text);
            f2.Show();
            f2.ShowDialog();
        }

        private void compareFrmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            compareForm f2 = new compareForm(txtResult.Text);
            f2.ShowDialog();
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void unitConversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            unitConversion f3 = new unitConversion();
            f3.ShowDialog();
        }

        private void timeConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            timeConverter f4 = new timeConverter();
            f4.ShowDialog();
        }
    }
}