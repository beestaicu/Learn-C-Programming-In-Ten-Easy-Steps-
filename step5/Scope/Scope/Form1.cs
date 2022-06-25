namespace Scope
{
  

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B b = new B();
            textBox1.AppendText("b.x= " + b.x + "\r\n");
            textBox1.AppendText("b.Gety= " + b.Gety() + "\r\n");
            textBox1.AppendText("b,Getz= " + b.Getz() + "\r\n");
        }
    }

    public class A
    {
        public int x;
        private int y;
        protected int z;

        public A()
        {
            x = 100;
            y = 200;
            z = 300;
        }

        public int Gety()
        {
            return y;
        }
    }

    public class B : A
    {
        public int Getz()
        {
            return z;
        }
    }
}