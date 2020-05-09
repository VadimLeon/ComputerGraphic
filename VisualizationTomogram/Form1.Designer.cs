namespace VisualizationTomogram
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
      this.glControl1 = new OpenTK.GLControl();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      this.SuspendLayout();
      // 
      // glControl1
      // 
      this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.glControl1.BackColor = System.Drawing.Color.White;
      this.glControl1.Location = new System.Drawing.Point(13, 122);
      this.glControl1.Name = "glControl1";
      this.glControl1.Size = new System.Drawing.Size(834, 451);
      this.glControl1.TabIndex = 0;
      this.glControl1.VSync = false;
      this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(859, 24);
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
      // trackBar1
      // 
      this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar1.AutoSize = false;
      this.trackBar1.Location = new System.Drawing.Point(88, 27);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(659, 25);
      this.trackBar1.TabIndex = 2;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // radioButton1
      // 
      this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(769, 82);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(56, 17);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Quads";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(769, 59);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(61, 17);
      this.radioButton2.TabIndex = 4;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Texture";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(755, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Vizualisation mode";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Number layer";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Minimum FT";
      // 
      // trackBar2
      // 
      this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar2.AutoSize = false;
      this.trackBar2.Location = new System.Drawing.Point(88, 59);
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(659, 25);
      this.trackBar2.TabIndex = 8;
      this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
      // 
      // trackBar3
      // 
      this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar3.AutoSize = false;
      this.trackBar3.Location = new System.Drawing.Point(88, 91);
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Size = new System.Drawing.Size(659, 25);
      this.trackBar3.TabIndex = 9;
      this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 91);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Higth FT";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(859, 585);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.trackBar3);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.glControl1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private OpenTK.GLControl glControl1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.Label label4;
  }
}

