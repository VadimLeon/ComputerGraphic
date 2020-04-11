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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.button1 = new System.Windows.Forms.Button();
      this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
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
      this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.inversionToolStripMenuItem});
      this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
      this.pointToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.pointToolStripMenuItem.Text = "Point";
      // 
      // inversionToolStripMenuItem
      // 
      this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
      this.inversionToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.inversionToolStripMenuItem.Text = "Inversion";
      this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
      // 
      // matrixToolStripMenuItem
      // 
      this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianToolStripMenuItem});
      this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
      this.matrixToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.matrixToolStripMenuItem.Text = "Matrix";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(94, 0);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(502, 23);
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
      this.button1.Location = new System.Drawing.Point(602, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(82, 24);
      this.button1.TabIndex = 3;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // blurToolStripMenuItem
      // 
      this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
      this.blurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.blurToolStripMenuItem.Text = "Blur";
      this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
      // 
      // gaussianToolStripMenuItem
      // 
      this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
      this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.gaussianToolStripMenuItem.Text = "Gaussian";
      this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
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
      this.MainMenuStrip = this.menuStrip1;
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
    }
}

