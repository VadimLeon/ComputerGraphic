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
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveDialog = new SaveFileDialog();
      saveDialog.Filter = "Save files (*.png)|*.png|Save files (*.jpg)|*.jpg|Save files (*.bmp)|*.bmp";
      saveDialog.RestoreDirectory = true;
                
      if (saveDialog.ShowDialog() == DialogResult.OK)
      {
        switch (saveDialog.FilterIndex)
        {
          case 0: image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png); break;
          case 1: image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg); break;
          case 2: image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp); break;
        }
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

    private void blurToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new BlurFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GaussianFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void grayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GrayScaleFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new SepiaFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void addBrightToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new BrightAddFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }
    private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new SobelFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new SharpnessFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }
  }
}
