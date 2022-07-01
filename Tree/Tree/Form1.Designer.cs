namespace Tree
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TestMI = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tv = new System.Windows.Forms.TreeView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ExpandAllBtn = new System.Windows.Forms.Button();
            this.CollapseAllBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HotTrackCB = new System.Windows.Forms.CheckBox();
            this.LabelEditCB = new System.Windows.Forms.CheckBox();
            this.CheckBoxesCB = new System.Windows.Forms.CheckBox();
            this.RootLinesCB = new System.Windows.Forms.CheckBox();
            this.LinesCB = new System.Windows.Forms.CheckBox();
            this.PlusMinusCB = new System.Windows.Forms.CheckBox();
            this.ApplyOptsBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMI,
            this.OpenMI,
            this.SaveMI,
            this.toolStripMenuItem1,
            this.TestMI,
            this.IndexMI,
            this.toolStripMenuItem2,
            this.ExitMI});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(54, 29);
            this.MenuItem.Text = "File";
            // 
            // NewMI
            // 
            this.NewMI.Name = "NewMI";
            this.NewMI.Size = new System.Drawing.Size(270, 34);
            this.NewMI.Text = "New";
            this.NewMI.Click += new System.EventHandler(this.NewMI_Click);
            // 
            // OpenMI
            // 
            this.OpenMI.Name = "OpenMI";
            this.OpenMI.Size = new System.Drawing.Size(193, 34);
            this.OpenMI.Text = "Open";
            // 
            // SaveMI
            // 
            this.SaveMI.Name = "SaveMI";
            this.SaveMI.Size = new System.Drawing.Size(193, 34);
            this.SaveMI.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // TestMI
            // 
            this.TestMI.Name = "TestMI";
            this.TestMI.Size = new System.Drawing.Size(270, 34);
            this.TestMI.Text = "Test";
            this.TestMI.Click += new System.EventHandler(this.TestMI_Click);
            // 
            // IndexMI
            // 
            this.IndexMI.Name = "IndexMI";
            this.IndexMI.Size = new System.Drawing.Size(270, 34);
            this.IndexMI.Text = "Index Tree";
            this.IndexMI.Click += new System.EventHandler(this.IndexMI_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
            // 
            // ExitMI
            // 
            this.ExitMI.Name = "ExitMI";
            this.ExitMI.Size = new System.Drawing.Size(193, 34);
            this.ExitMI.Text = "Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(24, 36);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(776, 237);
            this.tv.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(24, 299);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 34);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(24, 348);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(112, 34);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ExpandAllBtn
            // 
            this.ExpandAllBtn.Location = new System.Drawing.Point(167, 299);
            this.ExpandAllBtn.Name = "ExpandAllBtn";
            this.ExpandAllBtn.Size = new System.Drawing.Size(112, 34);
            this.ExpandAllBtn.TabIndex = 5;
            this.ExpandAllBtn.Text = "Expand All";
            this.ExpandAllBtn.UseVisualStyleBackColor = true;
            this.ExpandAllBtn.Click += new System.EventHandler(this.ExpandAllBtn_Click);
            // 
            // CollapseAllBtn
            // 
            this.CollapseAllBtn.Location = new System.Drawing.Point(167, 348);
            this.CollapseAllBtn.Name = "CollapseAllBtn";
            this.CollapseAllBtn.Size = new System.Drawing.Size(112, 34);
            this.CollapseAllBtn.TabIndex = 6;
            this.CollapseAllBtn.Text = "Collapse All";
            this.CollapseAllBtn.UseVisualStyleBackColor = true;
            this.CollapseAllBtn.Click += new System.EventHandler(this.CollapseAllBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HotTrackCB);
            this.groupBox1.Controls.Add(this.LabelEditCB);
            this.groupBox1.Controls.Add(this.CheckBoxesCB);
            this.groupBox1.Controls.Add(this.RootLinesCB);
            this.groupBox1.Controls.Add(this.LinesCB);
            this.groupBox1.Controls.Add(this.PlusMinusCB);
            this.groupBox1.Location = new System.Drawing.Point(298, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options...";
            // 
            // HotTrackCB
            // 
            this.HotTrackCB.AutoSize = true;
            this.HotTrackCB.Location = new System.Drawing.Point(249, 112);
            this.HotTrackCB.Name = "HotTrackCB";
            this.HotTrackCB.Size = new System.Drawing.Size(108, 29);
            this.HotTrackCB.TabIndex = 5;
            this.HotTrackCB.Text = "hot track";
            this.HotTrackCB.UseVisualStyleBackColor = true;
            // 
            // LabelEditCB
            // 
            this.LabelEditCB.AutoSize = true;
            this.LabelEditCB.Location = new System.Drawing.Point(249, 77);
            this.LabelEditCB.Name = "LabelEditCB";
            this.LabelEditCB.Size = new System.Drawing.Size(118, 29);
            this.LabelEditCB.TabIndex = 4;
            this.LabelEditCB.Text = "edit labels";
            this.LabelEditCB.UseVisualStyleBackColor = true;
            // 
            // CheckBoxesCB
            // 
            this.CheckBoxesCB.AutoSize = true;
            this.CheckBoxesCB.Location = new System.Drawing.Point(249, 42);
            this.CheckBoxesCB.Name = "CheckBoxesCB";
            this.CheckBoxesCB.Size = new System.Drawing.Size(181, 29);
            this.CheckBoxesCB.TabIndex = 3;
            this.CheckBoxesCB.Text = "show check boxes";
            this.CheckBoxesCB.UseVisualStyleBackColor = true;
            // 
            // RootLinesCB
            // 
            this.RootLinesCB.AutoSize = true;
            this.RootLinesCB.Location = new System.Drawing.Point(6, 112);
            this.RootLinesCB.Name = "RootLinesCB";
            this.RootLinesCB.Size = new System.Drawing.Size(159, 29);
            this.RootLinesCB.TabIndex = 2;
            this.RootLinesCB.Text = "show root lines";
            this.RootLinesCB.UseVisualStyleBackColor = true;
            // 
            // LinesCB
            // 
            this.LinesCB.AutoSize = true;
            this.LinesCB.Location = new System.Drawing.Point(6, 77);
            this.LinesCB.Name = "LinesCB";
            this.LinesCB.Size = new System.Drawing.Size(120, 29);
            this.LinesCB.TabIndex = 1;
            this.LinesCB.Text = "show lines";
            this.LinesCB.UseVisualStyleBackColor = true;
            // 
            // PlusMinusCB
            // 
            this.PlusMinusCB.AutoSize = true;
            this.PlusMinusCB.Location = new System.Drawing.Point(6, 42);
            this.PlusMinusCB.Name = "PlusMinusCB";
            this.PlusMinusCB.Size = new System.Drawing.Size(206, 29);
            this.PlusMinusCB.TabIndex = 0;
            this.PlusMinusCB.Text = "show plus and minus";
            this.PlusMinusCB.UseVisualStyleBackColor = true;
            // 
            // ApplyOptsBtn
            // 
            this.ApplyOptsBtn.Location = new System.Drawing.Point(106, 404);
            this.ApplyOptsBtn.Name = "ApplyOptsBtn";
            this.ApplyOptsBtn.Size = new System.Drawing.Size(112, 34);
            this.ApplyOptsBtn.TabIndex = 6;
            this.ApplyOptsBtn.Text = "Apply";
            this.ApplyOptsBtn.UseVisualStyleBackColor = true;
            this.ApplyOptsBtn.Click += new System.EventHandler(this.ApplyOptsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyOptsBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CollapseAllBtn);
            this.Controls.Add(this.ExpandAllBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem;
        private ToolStripMenuItem NewMI;
        private ToolStripMenuItem OpenMI;
        private ToolStripMenuItem SaveMI;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem TestMI;
        private ToolStripMenuItem IndexMI;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem ExitMI;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TreeView tv;
        private Button AddBtn;
        private Button DelBtn;
        private Button ExpandAllBtn;
        private Button CollapseAllBtn;
        private GroupBox groupBox1;
        private CheckBox HotTrackCB;
        private CheckBox LabelEditCB;
        private CheckBox CheckBoxesCB;
        private CheckBox RootLinesCB;
        private CheckBox LinesCB;
        private CheckBox PlusMinusCB;
        private Button ApplyOptsBtn;
    }
}