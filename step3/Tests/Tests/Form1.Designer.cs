namespace Tests
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
            this.moreTestsBtn = new System.Windows.Forms.Button();
            this.complexTestsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.userinput = new System.Windows.Forms.TextBox();
            this.nameinput = new System.Windows.Forms.TextBox();
            this.numericalTestsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(58, 257);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(160, 34);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "Do Tests";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // moreTestsBtn
            // 
            this.moreTestsBtn.Location = new System.Drawing.Point(58, 297);
            this.moreTestsBtn.Name = "moreTestsBtn";
            this.moreTestsBtn.Size = new System.Drawing.Size(160, 34);
            this.moreTestsBtn.TabIndex = 1;
            this.moreTestsBtn.Text = "Do More Tests";
            this.moreTestsBtn.UseVisualStyleBackColor = true;
            this.moreTestsBtn.Click += new System.EventHandler(this.moreTestsBtn_Click);
            // 
            // complexTestsBtn
            // 
            this.complexTestsBtn.Location = new System.Drawing.Point(58, 344);
            this.complexTestsBtn.Name = "complexTestsBtn";
            this.complexTestsBtn.Size = new System.Drawing.Size(160, 34);
            this.complexTestsBtn.TabIndex = 2;
            this.complexTestsBtn.Text = "Complex Tests";
            this.complexTestsBtn.UseVisualStyleBackColor = true;
            this.complexTestsBtn.Click += new System.EventHandler(this.complexTestsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your name:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(58, 39);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(640, 174);
            this.output.TabIndex = 5;
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(511, 235);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(150, 31);
            this.userinput.TabIndex = 6;
            // 
            // nameinput
            // 
            this.nameinput.Location = new System.Drawing.Point(511, 284);
            this.nameinput.Name = "nameinput";
            this.nameinput.Size = new System.Drawing.Size(150, 31);
            this.nameinput.TabIndex = 7;
            // 
            // numericalTestsBtn
            // 
            this.numericalTestsBtn.Location = new System.Drawing.Point(234, 344);
            this.numericalTestsBtn.Name = "numericalTestsBtn";
            this.numericalTestsBtn.Size = new System.Drawing.Size(202, 34);
            this.numericalTestsBtn.TabIndex = 8;
            this.numericalTestsBtn.Text = "Numerical Tests";
            this.numericalTestsBtn.UseVisualStyleBackColor = true;
            this.numericalTestsBtn.Click += new System.EventHandler(this.numericalTestsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericalTestsBtn);
            this.Controls.Add(this.nameinput);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complexTestsBtn);
            this.Controls.Add(this.moreTestsBtn);
            this.Controls.Add(this.testBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button testBtn;
        private Button moreTestsBtn;
        private Button complexTestsBtn;
        private Label label1;
        private Label label2;
        private TextBox output;
        private TextBox userinput;
        private TextBox nameinput;
        private Button numericalTestsBtn;
    }
}