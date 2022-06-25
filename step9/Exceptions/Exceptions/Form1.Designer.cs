namespace Exceptions
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.grandTotBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.Calc2Btn = new System.Windows.Forms.Button();
            this.Calc3Btn = new System.Windows.Forms.Button();
            this.Calc4Btn = new System.Windows.Forms.Button();
            this.Calc5Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(24, 44);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(437, 25);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Welcome to our tax Calculator. Please enter a subtotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "grand total:";
            // 
            // subTotBox
            // 
            this.subTotBox.Location = new System.Drawing.Point(157, 112);
            this.subTotBox.Name = "subTotBox";
            this.subTotBox.Size = new System.Drawing.Size(150, 31);
            this.subTotBox.TabIndex = 4;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(157, 167);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(150, 31);
            this.taxBox.TabIndex = 5;
            // 
            // grandTotBox
            // 
            this.grandTotBox.Location = new System.Drawing.Point(157, 214);
            this.grandTotBox.Name = "grandTotBox";
            this.grandTotBox.Size = new System.Drawing.Size(150, 31);
            this.grandTotBox.TabIndex = 6;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(464, 94);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(112, 34);
            this.CalcBtn.TabIndex = 7;
            this.CalcBtn.Text = "Calc";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Calc2Btn
            // 
            this.Calc2Btn.Location = new System.Drawing.Point(464, 146);
            this.Calc2Btn.Name = "Calc2Btn";
            this.Calc2Btn.Size = new System.Drawing.Size(112, 34);
            this.Calc2Btn.TabIndex = 8;
            this.Calc2Btn.Text = "Calc2";
            this.Calc2Btn.UseVisualStyleBackColor = true;
            this.Calc2Btn.Click += new System.EventHandler(this.Calc2Btn_Click);
            // 
            // Calc3Btn
            // 
            this.Calc3Btn.Location = new System.Drawing.Point(464, 205);
            this.Calc3Btn.Name = "Calc3Btn";
            this.Calc3Btn.Size = new System.Drawing.Size(112, 34);
            this.Calc3Btn.TabIndex = 9;
            this.Calc3Btn.Text = "Calc3";
            this.Calc3Btn.UseVisualStyleBackColor = true;
            this.Calc3Btn.Click += new System.EventHandler(this.Calc3Btn_Click);
            // 
            // Calc4Btn
            // 
            this.Calc4Btn.Location = new System.Drawing.Point(464, 263);
            this.Calc4Btn.Name = "Calc4Btn";
            this.Calc4Btn.Size = new System.Drawing.Size(112, 34);
            this.Calc4Btn.TabIndex = 10;
            this.Calc4Btn.Text = "Calc4";
            this.Calc4Btn.UseVisualStyleBackColor = true;
            this.Calc4Btn.Click += new System.EventHandler(this.Calc4Btn_Click);
            // 
            // Calc5Btn
            // 
            this.Calc5Btn.Location = new System.Drawing.Point(464, 317);
            this.Calc5Btn.Name = "Calc5Btn";
            this.Calc5Btn.Size = new System.Drawing.Size(112, 34);
            this.Calc5Btn.TabIndex = 11;
            this.Calc5Btn.Text = "Calc5";
            this.Calc5Btn.UseVisualStyleBackColor = true;
            this.Calc5Btn.Click += new System.EventHandler(this.Calc5Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calc5Btn);
            this.Controls.Add(this.Calc4Btn);
            this.Controls.Add(this.Calc3Btn);
            this.Controls.Add(this.Calc2Btn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.grandTotBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.subTotBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label statusLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox subTotBox;
        private TextBox taxBox;
        private TextBox grandTotBox;
        private Button CalcBtn;
        private Button Calc2Btn;
        private Button Calc3Btn;
        private Button Calc4Btn;
        private Button Calc5Btn;
    }
}