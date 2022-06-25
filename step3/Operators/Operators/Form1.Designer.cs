namespace Operators
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
            this.testOpsBtn = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testOpsBtn
            // 
            this.testOpsBtn.Location = new System.Drawing.Point(166, 372);
            this.testOpsBtn.Name = "testOpsBtn";
            this.testOpsBtn.Size = new System.Drawing.Size(353, 49);
            this.testOpsBtn.TabIndex = 0;
            this.testOpsBtn.Text = "Test Operators";
            this.testOpsBtn.UseVisualStyleBackColor = true;
            this.testOpsBtn.Click += new System.EventHandler(this.testOpsBtn_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(57, 35);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(650, 319);
            this.tb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.testOpsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button testOpsBtn;
        private TextBox tb;
    }
}