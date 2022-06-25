using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CountChars()
        {
            string s = richTextBox1.Text;
            int charcount = 0;

            while (charcount < s.Length)
            {
                charcount++;
            }
            //this.Text = "Number of words: " + charcount;
            MessageBox.Show("Number of chars: " + charcount.ToString()
                );
        }


        private void MenuItem2_Click(object sender, EventArgs e)
        {
            openFile1.DefaultExt = "rtf";
            openFile1.Filter = "RTF Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                if ( openFile1.FilterIndex == 1) // only when 1 is open the file
                {
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
                 
                }
                else
                {
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);

                }
            }
        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {
            saveFile1.DefaultExt = "rtf";
            saveFile1.Filter = "RTF Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";

            if(saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                saveFile1.AddExtension = true;
                if(Path.GetExtension(saveFile1.FileName) == "")
                {
                    saveFile1.FileName = saveFile1.FileName + ".xxx";
                }
                if (saveFile1.FilterIndex == 1)
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItem8_Click(object sender, EventArgs e)
        {
            CountChars();
        }

    }
}