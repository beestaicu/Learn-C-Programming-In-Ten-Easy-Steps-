namespace TaxCalcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double subtotal = 0.0;
            double tax = 0.0;
            double grandtotal = 0.0;
            subtotal = 12.5;
            tax = 2.5;
            grandtotal = 15.0;
            subTotalTB.Text = subtotal.ToString();
            taxTB.Text = tax.ToString();
            grandTotalTB.Text = grandtotal.ToString();
        }
    }
}