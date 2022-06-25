namespace editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem2,
            this.MenuItem6,
            this.MenuItem3,
            this.MenuItem5});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(54, 29);
            this.MenuItem1.Text = "File";
            // 
            // MenuItem2
            // 
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(158, 34);
            this.MenuItem2.Text = "Open";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem6
            // 
            this.MenuItem6.Name = "MenuItem6";
            this.MenuItem6.Size = new System.Drawing.Size(158, 34);
            this.MenuItem6.Text = "Save";
            this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(158, 34);
            this.MenuItem3.Text = "New";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // MenuItem5
            // 
            this.MenuItem5.Name = "MenuItem5";
            this.MenuItem5.Size = new System.Drawing.Size(158, 34);
            this.MenuItem5.Text = "Exit";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // MenuItem7
            // 
            this.MenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem8});
            this.MenuItem7.Name = "MenuItem7";
            this.MenuItem7.Size = new System.Drawing.Size(69, 29);
            this.MenuItem7.Text = "Tools";
            // 
            // MenuItem8
            // 
            this.MenuItem8.Name = "MenuItem8";
            this.MenuItem8.Size = new System.Drawing.Size(270, 34);
            this.MenuItem8.Text = "Char count";
            this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
            // 
            // openFile1
            // 
            this.openFile1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(764, 392);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem1;
        private ToolStripMenuItem MenuItem2;
        private ToolStripMenuItem MenuItem6;
        private ToolStripMenuItem MenuItem3;
        private ToolStripMenuItem MenuItem5;
        private ToolStripMenuItem MenuItem7;
        private ToolStripMenuItem MenuItem8;
        private OpenFileDialog openFile1;
        private SaveFileDialog saveFile1;
        private RichTextBox richTextBox1;
    }
}