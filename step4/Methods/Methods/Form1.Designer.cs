namespace Methods
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
            this.testBtn = new System.Windows.Forms.Button();
            this.paramTestBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(105, 330);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(180, 34);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "Run Method Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // paramTestBtn
            // 
            this.paramTestBtn.Location = new System.Drawing.Point(415, 330);
            this.paramTestBtn.Name = "paramTestBtn";
            this.paramTestBtn.Size = new System.Drawing.Size(248, 34);
            this.paramTestBtn.TabIndex = 1;
            this.paramTestBtn.Text = "Value, Ref and Out";
            this.paramTestBtn.UseVisualStyleBackColor = true;
            this.paramTestBtn.Click += new System.EventHandler(this.paramTestBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(558, 259);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.paramTestBtn);
            this.Controls.Add(this.testBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button testBtn;
        private Button paramTestBtn;
        private TextBox textBox1;
    }
}