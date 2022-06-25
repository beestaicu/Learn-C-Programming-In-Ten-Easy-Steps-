using System.Collections;

namespace Dir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dirBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            // Drives
            try
            {
                string[] drives = Directory.GetLogicalDrives();
                foreach (string drive in drives)
                {
                    richTextBox1.AppendText(drive + "\n");
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText(ex.Message + "\n");
            }

            // Current Directory
            string currdir = Directory.GetCurrentDirectory();
            richTextBox1.AppendText("GetCurrentDirectory() = " + currdir + "\n");

            // Root (top-level) directory
            string dirroot = Directory.GetDirectoryRoot(currdir);
            richTextBox1.AppendText("GetDirectoryRoot() = " + dirroot + "\n");

            // SubDirectories
            string[] subdirs = Directory.GetDirectories(dirroot);
            foreach(string sd in subdirs)
            {
                richTextBox1.AppendText(sd + "\n");
            }

            // Program Files DIr
            string pfdir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            richTextBox1.AppendText("Program Files Dir = " + pfdir + "\n");

            // System Dir
            string sysdir = Environment.SystemDirectory;
            richTextBox1.AppendText("System Dir = " + sysdir + "\n");
        }

        private void sysdirBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string[] files = Directory.GetFiles(Environment.SystemDirectory);
            richTextBox1.AppendText("Files in System Directory");
            foreach (string fn in files)
            {
                richTextBox1.AppendText(fn + "\n");
            }
        }

        private void envBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Cookies Directory = " + Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + "\n");
            richTextBox1.AppendText("StartMenu Directory = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\n");
            richTextBox1.AppendText("Machine Name = " + Environment.MachineName + "\n");
            richTextBox1.AppendText("User Name = " + Environment.UserName + "\n");
            richTextBox1.AppendText("CLR Version = " + Environment.Version + "\n"); // what is that??

            // subDirectories
            richTextBox1.AppendText("Files in Program Files folder:\n");
            string[] subdirs = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            foreach (string sd in subdirs)
            {
                richTextBox1.AppendText(sd + "\n");
            }

            // OS
            OperatingSystem osver = Environment.OSVersion;
            richTextBox1.AppendText("OS Version = " + osver + "\n");
            richTextBox1.AppendText("OS Platform and Version = " + osver.Platform + ":" + osver.Version + "\n");

            // Get all environment variables
            IDictionary envvars = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in envvars)
            {
                richTextBox1.AppendText(de.Key + " = " + de.Value + "\n");
            }

            // Get a specific variable
            string homedrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
            if (homedrive == null) homedrive = "Error: Environment Variable not found.";
            richTextBox1.AppendText("HOMEFRIVE = [" + homedrive + "]\n");

            // Dealing with non existent variable
            string gribbit = Environment.GetEnvironmentVariable("GRIBBIT");
            if (gribbit == null) gribbit = "Error: Environment Variable not found.";
            richTextBox1.AppendText("GRIBBIT=[" + gribbit + "]\n");

        }

        private void sysinfBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Boot Mode = " + SystemInformation.BootMode + "\n");
            richTextBox1.AppendText("Icon Size = " + SystemInformation.IconSize + "\n");
            richTextBox1.AppendText("Small Icon Size = " + SystemInformation.SmallIconSize + "\n");
            richTextBox1.AppendText("Menu Font = " + SystemInformation.MenuFont + "\n");
            richTextBox1.AppendText("Network = " + SystemInformation.Network + "\n");
            richTextBox1.AppendText("Working Area = " + SystemInformation.WorkingArea + "\n");

        }

        private void pathBtn_Click(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath;
            richTextBox1.Clear();
            richTextBox1.AppendText("Application.ExecutablePath=" + path + "\n");
            richTextBox1.AppendText("Path.GetDirectoryName= " + Path.GetDirectoryName(path) + "\n");
            richTextBox1.AppendText("Path.GetExtension=" + Path.GetExtension(path) + "\n");
            richTextBox1.AppendText("Path.GetFileName =" + Path.GetFileNameWithoutExtension(path) + "\n");
            richTextBox1.AppendText("Path.GetPathRoot=" + Path.GetPathRoot(path) + "\n");
        }
    }
}