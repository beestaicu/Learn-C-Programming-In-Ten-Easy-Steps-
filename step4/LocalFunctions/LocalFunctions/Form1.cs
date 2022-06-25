namespace LocalFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ShowSalary(string aName, int earnings)
        {
            string msg;
            double bonus;
            
            double addBonus()
            {
                return earnings + (earnings * 0.05);
            }
            bonus = addBonus();
            msg = aName + " has a salary of " + bonus + "\r\n";
            return msg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(ShowSalary("Fred", 20000));
            textBox1.AppendText(ShowSalary("Mary", 30000));
        }
    }
}