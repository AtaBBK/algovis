namespace AlgorithmVisualization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.drawNodeBtn = new System.Windows.Forms.ToolStripButton();
            this.selectColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAlgorithm = new System.Windows.Forms.ToolStripComboBox();
            this.drawKpointBtn = new System.Windows.Forms.ToolStripButton();
            this.drawSelectedNBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startBtn = new System.Windows.Forms.ToolStripButton();
            this.resetBtn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logTxtBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawNodeBtn,
            this.selectColorBtn,
            this.toolStripSeparator1,
            this.selectAlgorithm,
            this.drawKpointBtn,
            this.drawSelectedNBtn,
            this.toolStripSeparator2,
            this.startBtn,
            this.resetBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // drawNodeBtn
            // 
            this.drawNodeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawNodeBtn.Image = global::AlgorithmVisualization.Properties.Resources.circle;
            this.drawNodeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawNodeBtn.Name = "drawNodeBtn";
            this.drawNodeBtn.Size = new System.Drawing.Size(23, 22);
            this.drawNodeBtn.Text = "Draw Node";
            this.drawNodeBtn.Click += new System.EventHandler(this.drawNodeBtn_Click);
            // 
            // selectColorBtn
            // 
            this.selectColorBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectColorBtn.Name = "selectColorBtn";
            this.selectColorBtn.Size = new System.Drawing.Size(23, 22);
            this.selectColorBtn.Text = "Select Color";
            this.selectColorBtn.Click += new System.EventHandler(this.selectColorBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // selectAlgorithm
            // 
            this.selectAlgorithm.Name = "selectAlgorithm";
            this.selectAlgorithm.Size = new System.Drawing.Size(121, 25);
            this.selectAlgorithm.SelectedIndexChanged += new System.EventHandler(this.selectAlgorithm_SelectedIndexChanged);
            // 
            // drawKpointBtn
            // 
            this.drawKpointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawKpointBtn.Image = global::AlgorithmVisualization.Properties.Resources.typography;
            this.drawKpointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawKpointBtn.Name = "drawKpointBtn";
            this.drawKpointBtn.Size = new System.Drawing.Size(23, 22);
            this.drawKpointBtn.Text = "Draw K Point";
            this.drawKpointBtn.Click += new System.EventHandler(this.drawKpointBtn_Click);
            // 
            // drawSelectedNBtn
            // 
            this.drawSelectedNBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSelectedNBtn.Image = global::AlgorithmVisualization.Properties.Resources.typography_1;
            this.drawSelectedNBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSelectedNBtn.Name = "drawSelectedNBtn";
            this.drawSelectedNBtn.Size = new System.Drawing.Size(23, 22);
            this.drawSelectedNBtn.Text = "Starting Node Select";
            this.drawSelectedNBtn.Click += new System.EventHandler(this.drawSelectedNBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // startBtn
            // 
            this.startBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startBtn.Image = global::AlgorithmVisualization.Properties.Resources.arrow;
            this.startBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(23, 22);
            this.startBtn.Text = "Start Algorithm";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetBtn.Image = global::AlgorithmVisualization.Properties.Resources.arrows;
            this.resetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(23, 22);
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 131);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logTxtBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // logTxtBox
            // 
            this.logTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTxtBox.Location = new System.Drawing.Point(3, 16);
            this.logTxtBox.Name = "logTxtBox";
            this.logTxtBox.ReadOnly = true;
            this.logTxtBox.Size = new System.Drawing.Size(776, 112);
            this.logTxtBox.TabIndex = 0;
            this.logTxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton drawNodeBtn;
        private System.Windows.Forms.ToolStripButton selectColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox selectAlgorithm;
        private System.Windows.Forms.ToolStripButton drawKpointBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton startBtn;
        private System.Windows.Forms.ToolStripButton resetBtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox logTxtBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton drawSelectedNBtn;
    }
}

