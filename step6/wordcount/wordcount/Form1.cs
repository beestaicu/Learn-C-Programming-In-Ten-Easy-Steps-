namespace wordcount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] DELIMS = new char[10] { ' ', '.', ',', '?', '!', '-','_', '+', '*', '/' };
        int charcount = 0;

        private bool IsDelimiter(char c)
        {
            bool delimfound = false;
            foreach (char mychar in DELIMS)
            {
                if (mychar == c)
                {
                    delimfound = true;
                }
            }
            return delimfound;
        }

           private void FindDelims()
        {
            string s = richTextBox1.Text;
            int delimcount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (IsDelimiter(s[i]))
                {
                    delimcount++;
                }
            }
            MessageBox.Show("delimcount=" + delimcount,
                "Statistics",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool ScrollThroughWord(string s)
        {
            bool wordfound = false;
            while ((charcount < s.Length) && !(IsDelimiter(s[charcount])))
            {
                charcount++;
                wordfound = true;
            }
            return wordfound;
        }

        private void ScrollThroughDelims(string s)
        {
            while((charcount < s.Length) && (IsDelimiter(s[charcount])))
            {
                charcount++;
            }
        }

        private void CountWordsAndCharactors()
        {
            string s = richTextBox1.Text;
            charcount = 0;
            int wordcount = 0;
            while( charcount < s.Length)
            {
                ScrollThroughDelims(s);
                if (ScrollThroughWord(s))
                {
                    wordcount++;
                }
            }
            this.Text = "Number of words: " + wordcount + " Characters: " + charcount;
        }

    


        private void button1_Click(object sender, EventArgs e)
        {
            FindDelims();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CountWordsAndCharactors();
        }

    }
}