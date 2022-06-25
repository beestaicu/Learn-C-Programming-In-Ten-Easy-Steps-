namespace Dir
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dirBtn = new System.Windows.Forms.Button();
            this.sysdirBtn = new System.Windows.Forms.Button();
            this.envBtn = new System.Windows.Forms.Button();
            this.sysinfBtn = new System.Windows.Forms.Button();
            this.pathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(737, 251);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dirBtn
            // 
            this.dirBtn.Location = new System.Drawing.Point(51, 305);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(250, 34);
            this.dirBtn.TabIndex = 1;
            this.dirBtn.Text = "Directory Test";
            this.dirBtn.UseVisualStyleBackColor = true;
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // sysdirBtn
            // 
            this.sysdirBtn.Location = new System.Drawing.Point(51, 359);
            this.sysdirBtn.Name = "sysdirBtn";
            this.sysdirBtn.Size = new System.Drawing.Size(250, 42);
            this.sysdirBtn.TabIndex = 2;
            this.sysdirBtn.Text = "File in System Dir";
            this.sysdirBtn.UseVisualStyleBackColor = true;
            this.sysdirBtn.Click += new System.EventHandler(this.sysdirBtn_Click);
            // 
            // envBtn
            // 
            this.envBtn.Location = new System.Drawing.Point(51, 421);
            this.envBtn.Name = "envBtn";
            this.envBtn.Size = new System.Drawing.Size(250, 39);
            this.envBtn.TabIndex = 3;
            this.envBtn.Text = "Environment Test";
            this.envBtn.UseVisualStyleBackColor = true;
            this.envBtn.Click += new System.EventHandler(this.envBtn_Click);
            // 
            // sysinfBtn
            // 
            this.sysinfBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sysinfBtn.Location = new System.Drawing.Point(51, 482);
            this.sysinfBtn.Name = "sysinfBtn";
            this.sysinfBtn.Size = new System.Drawing.Size(250, 41);
            this.sysinfBtn.TabIndex = 4;
            this.sysinfBtn.Text = "System Information";
            this.sysinfBtn.UseVisualStyleBackColor = false;
            this.sysinfBtn.Click += new System.EventHandler(this.sysinfBtn_Click);
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(51, 544);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(250, 34);
            this.pathBtn.TabIndex = 5;
            this.pathBtn.Text = "Path Test";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.sysinfBtn);
            this.Controls.Add(this.envBtn);
            this.Controls.Add(this.sysdirBtn);
            this.Controls.Add(this.dirBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button dirBtn;
        private Button sysdirBtn;
        private Button envBtn;
        private Button sysinfBtn;
        private Button pathBtn;
    }
}