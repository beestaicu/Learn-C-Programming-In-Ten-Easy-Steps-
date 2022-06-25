namespace ifelse
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
            this.ifBtn = new System.Windows.Forms.Button();
            this.ifelseBtn = new System.Windows.Forms.Button();
            this.if1Btn = new System.Windows.Forms.Button();
            this.if2Btn = new System.Windows.Forms.Button();
            this.if3Btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ifBtn
            // 
            this.ifBtn.Location = new System.Drawing.Point(170, 152);
            this.ifBtn.Name = "ifBtn";
            this.ifBtn.Size = new System.Drawing.Size(112, 34);
            this.ifBtn.TabIndex = 0;
            this.ifBtn.Text = "if test";
            this.ifBtn.UseVisualStyleBackColor = true;
            this.ifBtn.Click += new System.EventHandler(this.ifBtn_Click);
            // 
            // ifelseBtn
            // 
            this.ifelseBtn.Location = new System.Drawing.Point(170, 192);
            this.ifelseBtn.Name = "ifelseBtn";
            this.ifelseBtn.Size = new System.Drawing.Size(112, 34);
            this.ifelseBtn.TabIndex = 1;
            this.ifelseBtn.Text = "if..else";
            this.ifelseBtn.UseVisualStyleBackColor = true;
            this.ifelseBtn.Click += new System.EventHandler(this.ifelseBtn_Click);
            // 
            // if1Btn
            // 
            this.if1Btn.Location = new System.Drawing.Point(170, 274);
            this.if1Btn.Name = "if1Btn";
            this.if1Btn.Size = new System.Drawing.Size(112, 34);
            this.if1Btn.TabIndex = 2;
            this.if1Btn.Text = "if #1";
            this.if1Btn.UseVisualStyleBackColor = true;
            this.if1Btn.Click += new System.EventHandler(this.if1Btn_Click);
            // 
            // if2Btn
            // 
            this.if2Btn.Location = new System.Drawing.Point(170, 323);
            this.if2Btn.Name = "if2Btn";
            this.if2Btn.Size = new System.Drawing.Size(112, 34);
            this.if2Btn.TabIndex = 3;
            this.if2Btn.Text = "if #2";
            this.if2Btn.UseVisualStyleBackColor = true;
            this.if2Btn.Click += new System.EventHandler(this.if2Btn_Click);
            // 
            // if3Btn
            // 
            this.if3Btn.Location = new System.Drawing.Point(170, 380);
            this.if3Btn.Name = "if3Btn";
            this.if3Btn.Size = new System.Drawing.Size(112, 34);
            this.if3Btn.TabIndex = 4;
            this.if3Btn.Text = "if #3";
            this.if3Btn.UseVisualStyleBackColor = true;
            this.if3Btn.Click += new System.EventHandler(this.if3Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "How much money have you got?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.if3Btn);
            this.Controls.Add(this.if2Btn);
            this.Controls.Add(this.if1Btn);
            this.Controls.Add(this.ifelseBtn);
            this.Controls.Add(this.ifBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ifBtn;
        private Button ifelseBtn;
        private Button if1Btn;
        private Button if2Btn;
        private Button if3Btn;
        private TextBox textBox1;
        private Label label1;
    }
}