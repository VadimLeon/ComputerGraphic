using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAdaptation
{
  public partial class Form1 : Form
  {
    Bitmap image;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = "Image Adaptation";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openDialog = new OpenFileDialog();
      openDialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";

      if (openDialog.ShowDialog() == DialogResult.OK)
      {
        image = new Bitmap(openDialog.FileName);

        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }
    }

    private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      InvertFilter filter = new InvertFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      Bitmap mainImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
      if (backgroundWorker1.CancellationPending != true) image = mainImage;
   }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar1.Value = e.ProgressPercentage;
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!e.Cancelled)
      {
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }

      progressBar1.Value = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      backgroundWorker1.CancelAsync();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
