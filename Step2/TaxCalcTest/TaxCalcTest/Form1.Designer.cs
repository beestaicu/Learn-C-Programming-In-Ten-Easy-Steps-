namespace TaxCalcTest
{
    partial class Form1:Form
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.subTotalTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taxTB = new System.Windows.Forms.TextBox();
            this.grandTotalTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(261, 337);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(210, 64);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.Text = "Calc Tax";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // subTotalTB
            // 
            this.subTotalTB.Location = new System.Drawing.Point(321, 54);
            this.subTotalTB.Name = "subTotalTB";
            this.subTotalTB.Size = new System.Drawing.Size(150, 31);
            this.subTotalTB.TabIndex = 1;
            this.subTotalTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grand Total:";
            // 
            // taxTB
            // 
            this.taxTB.Location = new System.Drawing.Point(321, 139);
            this.taxTB.Name = "taxTB";
            this.taxTB.Size = new System.Drawing.Size(150, 31);
            this.taxTB.TabIndex = 5;
            // 
            // grandTotalTB
            // 
            this.grandTotalTB.Location = new System.Drawing.Point(321, 217);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subTotalTB);
            this.Controls.Add(this.calcBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calcBtn;
        private TextBox subTotalTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox taxTB;
        private TextBox grandTotalTB;
    }
}