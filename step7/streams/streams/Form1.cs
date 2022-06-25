namespace streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string SOURCEFN = "C:\\Test\\test.txt";

        const int BUFFSIZE = 1024;

        private void WriteStreamBtn_Click(object sender, EventArgs e)
        {
            // Use Stream objects
            // writes bytes
            const string OUTPUTFN = "C:\\Test\\Stream.txt";
            Stream instream = File.OpenRead(SOURCEFN);
            Stream outstream = File.OpenWrite(OUTPUTFN);

            byte[] buffer = new Byte[BUFFSIZE];
            int numbytes;
            int i = 0;
            while ((numbytes = instream.Read(buffer, 0, BUFFSIZE)) > 0)
            {
                outstream.Write(buffer, 0 , numbytes);
            }
            instream.Close();
            outstream.Close();
        }

        private void BuffStreamWriteBtn_Click(object sender, EventArgs e)
        {
            // Use Stream objects and buffers
            // writes bytes
            const string OUTPUTFN = "C:\\Test\\BuffStream.txt";
            Stream instream = File.OpenRead(SOURCEFN);
            Stream outstream = File.OpenWrite(OUTPUTFN);

            BufferedStream buffInput = new BufferedStream(instream);
            BufferedStream buffOutput = new BufferedStream(outstream);

            byte[] buffer = new Byte[BUFFSIZE];
            int numbytes;
            while ((numbytes = buffInput.Read(buffer,0, BUFFSIZE)) > 0)
            {
                buffOutput.Write(buffer, 0 , numbytes);
            }

            buffOutput.Flush(); // no need here because close() flush data
            buffInput.Close();
            buffOutput.Close();
        }

        private void FileStreamBtn_Click(object sender, EventArgs e)
        {
            // use FilewStream object
            // writes Bytes
            const string OUTPUTFN = "C:\\Test\\FileStream.txt";
            FileStream instream = new FileStream(SOURCEFN,
                FileMode.OpenOrCreate, FileAccess.Read);
            FileStream outstream = new FileStream(OUTPUTFN,
                FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer = new Byte[BUFFSIZE];
            int bytesRead;
            while ((bytesRead = instream.Read(buffer, 0, BUFFSIZE)) > 0)
            {
                outstream.Write(buffer, 0 , bytesRead);
            }
            instream.Close();
            outstream.Close();

        }

        private void AppendBtn_Click(object sender, EventArgs e)
        {
            const string OUTPUTFN = "C:\\Test\\FileStream.txt";
            StreamReader sread;
            StreamWriter swrite;
            String aline;
            if (!File.Exists(SOURCEFN))
            {
                MessageBox.Show(SOURCEFN + "does not exist!", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!File.Exists(OUTPUTFN))
            {
                MessageBox.Show(OUTPUTFN + "dose not exist!", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sread = File.OpenText(SOURCEFN);
                swrite = File.AppendText(OUTPUTFN); //!
                while((aline = sread.ReadLine()) != null)
                {
                    swrite.WriteLine(aline);
                }
                sread.Close();
                swrite.Close();
            }
        }

        private void StreamWriterBtn_Click(object sender, EventArgs e)
        {
            // StreamWriter object
            // writes lines of text
            const string OUTPUTFN = "C:\\Test\\StreamWriter.txt";
            StreamReader sread;
            StreamWriter swrite;
            String aline;
            if (!File.Exists(SOURCEFN))
            {
                MessageBox.Show(SOURCEFN + "does not exists!", "File not found.",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                sread = File.OpenText(SOURCEFN);
                swrite = File.CreateText(OUTPUTFN);
                while((aline = sread.ReadLine()) != null)
                {
                    swrite.WriteLine(aline);
                }
                sread.Close();
                swrite.Close();
            }
        }

        private void FileTestBtn_Click(object sender, EventArgs e)
        {
            string testFile = "C:\\Test\\Test.txt";
            string testFileCopy = "C:\\Test\\Test(copy).txt";
            DateTime dtCreated;
            DateTime dtModified;

            if (File.Exists(testFile))
            {
                textBox1.AppendText(testFile + "exists. Copying...\r\n");
                File.Copy(testFile, testFileCopy, true);
            }
            else
            {
                textBox1.AppendText(testFile + "does not exist\n");
            }

            if (File.Exists(testFile))
            {
                dtCreated = File.GetCreationTime(testFile);
                dtModified = File.GetLastWriteTime(testFile);
                textBox1.AppendText(testFile + " was created at: " + dtCreated);
                textBox1.AppendText(testFile + " was modified at: " + dtModified);
            }
        }
    }
}