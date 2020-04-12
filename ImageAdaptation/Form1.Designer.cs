namespace ImageAdaptation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addBrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gaussianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Location = new System.Drawing.Point(0, 27);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(684, 733);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.menuStrip1.Size = new System.Drawing.Size(684, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // filtersToolStripMenuItem
      // 
      this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.matrixToolStripMenuItem});
      this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
      this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.filtersToolStripMenuItem.Text = "Filters";
      // 
      // pointToolStripMenuItem
      // 
      this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.addBrightToolStripMenuItem});
      this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
      this.pointToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
      this.pointToolStripMenuItem.Text = "Point";
      // 
      // inversionToolStripMenuItem
      // 
      this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
      this.inversionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.inversionToolStripMenuItem.Text = "Inversion";
      this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
      // 
      // grayToolStripMenuItem
      // 
      this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
      this.grayToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.grayToolStripMenuItem.Text = "Gray";
      this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
      // 
      // sepiaToolStripMenuItem
      // 
      this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
      this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.sepiaToolStripMenuItem.Text = "Sepia";
      this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
      // 
      // addBrightToolStripMenuItem
      // 
      this.addBrightToolStripMenuItem.Name = "addBrightToolStripMenuItem";
      this.addBrightToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.addBrightToolStripMenuItem.Text = "Add bright";
      this.addBrightToolStripMenuItem.Click += new System.EventHandler(this.addBrightToolStripMenuItem_Click);
      // 
      // matrixToolStripMenuItem
      // 
      this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianToolStripMenuItem,
            this.gaussianToolStripMenuItem1,
            this.sharpnessToolStripMenuItem});
      this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
      this.matrixToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
      this.matrixToolStripMenuItem.Text = "Matrix";
      // 
      // blurToolStripMenuItem
      // 
      this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
      this.blurToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.blurToolStripMenuItem.Text = "Blur";
      this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
      // 
      // gaussianToolStripMenuItem
      // 
      this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
      this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.gaussianToolStripMenuItem.Text = "Gaussian";
      this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
      // 
      // gaussianToolStripMenuItem1
      // 
      this.gaussianToolStripMenuItem1.Name = "gaussianToolStripMenuItem1";
      this.gaussianToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
      this.gaussianToolStripMenuItem1.Text = "Gaussian";
      this.gaussianToolStripMenuItem1.Click += new System.EventHandler(this.gaussianToolStripMenuItem1_Click);
      // 
      // sharpnessToolStripMenuItem
      // 
      this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
      this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.sharpnessToolStripMenuItem.Text = "Sharpness";
      this.sharpnessToolStripMenuItem.Click += new System.EventHandler(this.sharpnessToolStripMenuItem_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar1.Location = new System.Drawing.Point(94, 0);
      this.progressBar1.MaximumSize = new System.Drawing.Size(900, 23);
      this.progressBar1.MinimumSize = new System.Drawing.Size(50, 23);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(501, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.WorkerSupportsCancellation = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(601, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(82, 24);
      this.button1.TabIndex = 3;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 761);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximumSize = new System.Drawing.Size(1000, 900);
      this.MinimumSize = new System.Drawing.Size(600, 400);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
    }
}

