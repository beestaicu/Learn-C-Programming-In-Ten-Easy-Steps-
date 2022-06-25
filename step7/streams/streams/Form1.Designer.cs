namespace streams
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
            this.WriteStreamBtn = new System.Windows.Forms.Button();
            this.BuffStreamWriteBtn = new System.Windows.Forms.Button();
            this.FileStreamBtn = new System.Windows.Forms.Button();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.StreamWriterBtn = new System.Windows.Forms.Button();
            this.FileTestBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WriteStreamBtn
            // 
            this.WriteStreamBtn.Location = new System.Drawing.Point(45, 41);
            this.WriteStreamBtn.Name = "WriteStreamBtn";
            this.WriteStreamBtn.Size = new System.Drawing.Size(238, 34);
            this.WriteStreamBtn.TabIndex = 0;
            this.WriteStreamBtn.Text = "Write Stream";
            this.WriteStreamBtn.UseVisualStyleBackColor = true;
            this.WriteStreamBtn.Click += new System.EventHandler(this.WriteStreamBtn_Click);
            // 
            // BuffStreamWriteBtn
            // 
            this.BuffStreamWriteBtn.Location = new System.Drawing.Point(45, 97);
            this.BuffStreamWriteBtn.Name = "BuffStreamWriteBtn";
            this.BuffStreamWriteBtn.Size = new System.Drawing.Size(238, 34);
            this.BuffStreamWriteBtn.TabIndex = 1;
            this.BuffStreamWriteBtn.Text = "Write Buffered Stream";
            this.BuffStreamWriteBtn.UseVisualStyleBackColor = true;
            this.BuffStreamWriteBtn.Click += new System.EventHandler(this.BuffStreamWriteBtn_Click);
            // 
            // FileStreamBtn
            // 
            this.FileStreamBtn.Location = new System.Drawing.Point(45, 147);
            this.FileStreamBtn.Name = "FileStreamBtn";
            this.FileStreamBtn.Size = new System.Drawing.Size(238, 34);
            this.FileStreamBtn.TabIndex = 2;
            this.FileStreamBtn.Text = "Write FileStream";
            this.FileStreamBtn.UseVisualStyleBackColor = true;
            this.FileStreamBtn.Click += new System.EventHandler(this.FileStreamBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(45, 202);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(238, 34);
            this.AppendBtn.TabIndex = 3;
            this.AppendBtn.Text = "Append Text";
            this.AppendBtn.UseVisualStyleBackColor = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // StreamWriterBtn
            // 
            this.StreamWriterBtn.Location = new System.Drawing.Point(45, 252);
            this.StreamWriterBtn.Name = "StreamWriterBtn";
            this.StreamWriterBtn.Size = new System.Drawing.Size(238, 34);
            this.StreamWriterBtn.TabIndex = 4;
            this.StreamWriterBtn.Text = "StreamWriter";
            this.StreamWriterBtn.UseVisualStyleBackColor = true;
            this.StreamWriterBtn.Click += new System.EventHandler(this.StreamWriterBtn_Click);
            // 
            // FileTestBtn
            // 
            this.FileTestBtn.Location = new System.Drawing.Point(45, 306);
            this.FileTestBtn.Name = "FileTestBtn";
            this.FileTestBtn.Size = new System.Drawing.Size(238, 34);
            this.FileTestBtn.TabIndex = 5;
            this.FileTestBtn.Text = "File Test";
            this.FileTestBtn.UseVisualStyleBackColor = true;
            this.FileTestBtn.Click += new System.EventHandler(this.FileTestBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 299);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FileTestBtn);
            this.Controls.Add(this.StreamWriterBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.FileStreamBtn);
            this.Controls.Add(this.BuffStreamWriteBtn);
            this.Controls.Add(this.WriteStreamBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button WriteStreamBtn;
        private Button BuffStreamWriteBtn;
        private Button FileStreamBtn;
        private Button AppendBtn;
        private Button StreamWriterBtn;
        private Button FileTestBtn;
        private TextBox textBox1;
    }
}