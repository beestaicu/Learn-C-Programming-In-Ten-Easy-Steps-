namespace TaxCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.subtotalTB = new System.Windows.Forms.TextBox();
            this.taxTB = new System.Windows.Forms.TextBox();
            this.grandTotalTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(358, 352);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(112, 34);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "button1";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // subtotalTB
            // 
            this.subtotalTB.Location = new System.Drawing.Point(358, 84);
            this.subtotalTB.Name = "subtotalTB";
            this.subtotalTB.Size = new System.Drawing.Size(150, 31);
            this.subtotalTB.TabIndex = 4;
            // 
            // taxTB
            // 
            this.taxTB.Location = new System.Drawing.Point(358, 155);
            this.taxTB.Name = "taxTB";
            this.taxTB.Size = new System.Drawing.Size(150, 31);
            this.taxTB.TabIndex = 5;
            // 
            // grandTotalTB
            // 
            this.grandTotalTB.Location = new System.Drawing.Point(358, 225);
            this.grandTotalTB.Name = "grandTotalTB";
            this.grandTotalTB.Size = new System.Drawing.Size(150, 31);
            this.grandTotalTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grandTotalTB);
            this.Controls.Add(this.taxTB);
            this.Controls.Add(this.subtotalTB);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button calcBtn;
        private TextBox subtotalTB;
        private TextBox taxTB;
        private TextBox grandTotalTB;
    }
}