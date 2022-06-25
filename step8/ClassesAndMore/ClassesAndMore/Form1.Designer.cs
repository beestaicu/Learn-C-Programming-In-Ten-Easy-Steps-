namespace ClassesAndMore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.suitsComboBox = new System.Windows.Forms.ComboBox();
            this.pictureCardsComboBox = new System.Windows.Forms.ComboBox();
            this.suitsEnumTestBtn = new System.Windows.Forms.Button();
            this.cardEnumTestBtn = new System.Windows.Forms.Button();
            this.test1Btn = new System.Windows.Forms.Button();
            this.structTestBtn = new System.Windows.Forms.Button();
            this.dockTopBtn = new System.Windows.Forms.Button();
            this.docRightBtn = new System.Windows.Forms.Button();
            this.anchorTopRightBtn = new System.Windows.Forms.Button();
            this.anchorBottomLeftBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 307);
            this.textBox1.TabIndex = 0;
            // 
            // suitsComboBox
            // 
            this.suitsComboBox.FormattingEnabled = true;
            this.suitsComboBox.Items.AddRange(new object[] {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"});
            this.suitsComboBox.Location = new System.Drawing.Point(575, 357);
            this.suitsComboBox.Name = "suitsComboBox";
            this.suitsComboBox.Size = new System.Drawing.Size(182, 33);
            this.suitsComboBox.TabIndex = 1;
            this.suitsComboBox.Text = "Spades";
            // 
            // pictureCardsComboBox
            // 
            this.pictureCardsComboBox.FormattingEnabled = true;
            this.pictureCardsComboBox.Items.AddRange(new object[] {
            "Jack",
            "Queen",
            "King"});
            this.pictureCardsComboBox.Location = new System.Drawing.Point(575, 405);
            this.pictureCardsComboBox.Name = "pictureCardsComboBox";
            this.pictureCardsComboBox.Size = new System.Drawing.Size(182, 33);
            this.pictureCardsComboBox.TabIndex = 2;
            this.pictureCardsComboBox.Text = "Jack";
            // 
            // suitsEnumTestBtn
            // 
            this.suitsEnumTestBtn.Location = new System.Drawing.Point(435, 358);
            this.suitsEnumTestBtn.Name = "suitsEnumTestBtn";
            this.suitsEnumTestBtn.Size = new System.Drawing.Size(119, 32);
            this.suitsEnumTestBtn.TabIndex = 3;
            this.suitsEnumTestBtn.Text = "Pick a suit";
            this.suitsEnumTestBtn.UseVisualStyleBackColor = true;
            this.suitsEnumTestBtn.Click += new System.EventHandler(this.suitsEnumTestBtn_Click);
            // 
            // cardEnumTestBtn
            // 
            this.cardEnumTestBtn.Location = new System.Drawing.Point(435, 405);
            this.cardEnumTestBtn.Name = "cardEnumTestBtn";
            this.cardEnumTestBtn.Size = new System.Drawing.Size(119, 34);
            this.cardEnumTestBtn.TabIndex = 4;
            this.cardEnumTestBtn.Text = "Pick a card";
            this.cardEnumTestBtn.UseVisualStyleBackColor = true;
            this.cardEnumTestBtn.Click += new System.EventHandler(this.cardEnumTestBtn_Click);
            // 
            // test1Btn
            // 
            this.test1Btn.Location = new System.Drawing.Point(63, 59);
            this.test1Btn.Name = "test1Btn";
            this.test1Btn.Size = new System.Drawing.Size(112, 37);
            this.test1Btn.TabIndex = 5;
            this.test1Btn.Text = "Test 1";
            this.test1Btn.UseVisualStyleBackColor = true;
            this.test1Btn.Click += new System.EventHandler(this.test1Btn_Click);
            // 
            // structTestBtn
            // 
            this.structTestBtn.Location = new System.Drawing.Point(63, 115);
            this.structTestBtn.Name = "structTestBtn";
            this.structTestBtn.Size = new System.Drawing.Size(112, 34);
            this.structTestBtn.TabIndex = 6;
            this.structTestBtn.Text = "Structs";
            this.structTestBtn.UseVisualStyleBackColor = true;
            this.structTestBtn.Click += new System.EventHandler(this.structTestBtn_Click);
            // 
            // dockTopBtn
            // 
            this.dockTopBtn.Location = new System.Drawing.Point(36, 185);
            this.dockTopBtn.Name = "dockTopBtn";
            this.dockTopBtn.Size = new System.Drawing.Size(163, 34);
            this.dockTopBtn.TabIndex = 7;
            this.dockTopBtn.Text = "Dock Top";
            this.dockTopBtn.UseVisualStyleBackColor = true;
            this.dockTopBtn.Click += new System.EventHandler(this.dockTopBtn_Click);
            // 
            // docRightBtn
            // 
            this.docRightBtn.Location = new System.Drawing.Point(36, 253);
            this.docRightBtn.Name = "docRightBtn";
            this.docRightBtn.Size = new System.Drawing.Size(163, 34);
            this.docRightBtn.TabIndex = 8;
            this.docRightBtn.Text = "Dock Right";
            this.docRightBtn.UseVisualStyleBackColor = true;
            this.docRightBtn.Click += new System.EventHandler(this.docRightBtn_Click);
            // 
            // anchorTopRightBtn
            // 
            this.anchorTopRightBtn.Location = new System.Drawing.Point(36, 321);
            this.anchorTopRightBtn.Name = "anchorTopRightBtn";
            this.anchorTopRightBtn.Size = new System.Drawing.Size(163, 34);
            this.anchorTopRightBtn.TabIndex = 9;
            this.anchorTopRightBtn.Text = "Anchor TopRight";
            this.anchorTopRightBtn.UseVisualStyleBackColor = true;
            this.anchorTopRightBtn.Click += new System.EventHandler(this.anchorTopRightBtn_Click);
            // 
            // anchorBottomLeftBtn
            // 
            this.anchorBottomLeftBtn.Location = new System.Drawing.Point(36, 384);
            this.anchorBottomLeftBtn.Name = "anchorBottomLeftBtn";
            this.anchorBottomLeftBtn.Size = new System.Drawing.Size(163, 34);
            this.anchorBottomLeftBtn.TabIndex = 10;
            this.anchorBottomLeftBtn.Text = "Anchor Bottom";
            this.anchorBottomLeftBtn.UseVisualStyleBackColor = true;
            this.anchorBottomLeftBtn.Click += new System.EventHandler(this.anchorBottomLeftBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anchorBottomLeftBtn);
            this.Controls.Add(this.anchorTopRightBtn);
            this.Controls.Add(this.docRightBtn);
            this.Controls.Add(this.dockTopBtn);
            this.Controls.Add(this.structTestBtn);
            this.Controls.Add(this.test1Btn);
            this.Controls.Add(this.cardEnumTestBtn);
            this.Controls.Add(this.suitsEnumTestBtn);
            this.Controls.Add(this.pictureCardsComboBox);
            this.Controls.Add(this.suitsComboBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ComboBox suitsComboBox;
        private ComboBox pictureCardsComboBox;
        private Button suitsEnumTestBtn;
        private Button cardEnumTestBtn;
        private Button test1Btn;
        private Button structTestBtn;
        private Button dockTopBtn;
        private Button docRightBtn;
        private Button anchorTopRightBtn;
        private Button anchorBottomLeftBtn;
    }
}