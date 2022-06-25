using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namespaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            string currdir;
            x = 10;
            textBox1.Text = string.Format("Value of x = {0} \r\n", x);
            currdir = Directory.GetCurrentDirectory();
            textBox1.AppendText("This is the current directory: " + currdir);
        }
    }
}
