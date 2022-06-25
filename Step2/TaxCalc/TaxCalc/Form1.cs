namespace TaxCalc
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double TAXRATE = 0.2;
            double subtotal = 0.0;
            double tax = 0.0;
            double grandtotal = 0.0;
            int roundTotal = 0;
            subtotal = Double.Parse(subtotalTB.Text);
            tax = subtotal * TAXRATE;
            grandtotal = subtotal + tax;
            taxTB.Text = tax.ToString();
            grandTotalTB.Text = grandtotal.ToString();
            roundTotal = (int)grandtotal;
            //roundTotal = Convert.ToInt32(grandtotal);
            this.Text = roundTotal.ToString();

        }
    }
}