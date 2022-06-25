namespace strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Length: " + textBox1.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s2 = "";
            for(int i = 0;i < s.Length; i++)
            {
                //s2 += "[" + i + "]='" + s[i] + "' ";
                s2 += $"[{i}]='{s[i]}' "; // same. but use interpolated string
            }
            textBox2.Text = s2;
        }
    }
}