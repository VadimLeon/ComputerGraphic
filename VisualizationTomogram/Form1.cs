using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace VisualizationTomogram
{
  public partial class Form1 : Form
  {
    Bin imageTomogramm = new Bin();
    View view = new View();

    bool loaded      = false;
    bool needReload  = false;
    int currentLayer = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openDialog = new OpenFileDialog();
      openDialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";

      if (openDialog.ShowDialog() == DialogResult.OK)
      {
        imageTomogramm.readBIN(openDialog.FileName);
        view.SetupView(glControl1.Width, glControl1.Height);
        trackBar1.Maximum = Bin.Z - 1;
        loaded = true;
        glControl1.Invalidate();
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void glControl1_Paint(object sender, PaintEventArgs e)
    {
      if (loaded)
      {
        if (radioButton1.Checked) { view.DrawQuads(currentLayer); }
        else
        {
          if (needReload)
          {
            view.generateTextureImage(currentLayer);
            view.Load2DTexture();
            needReload = false;
          }
          view.DrawTexture();
        }
        glControl1.SwapBuffers();
      }
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      currentLayer = trackBar1.Value;
      needReload = true;
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
      view.minimum = trackBar2.Value;
      needReload = true;
    }

    private void trackBar3_Scroll(object sender, EventArgs e)
    {
      view.windowWidth = trackBar3.Value;
      needReload = true;
    }
  }
}
