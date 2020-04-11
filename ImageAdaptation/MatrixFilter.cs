using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageAdaptation
{
  class MatrixFilter : Filters
  {
    protected float[,] kernel = null;
    protected MatrixFilter() { }
    public MatrixFilter(float[,] kernel)
    {
      this.kernel = kernel;
    }

    protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
    {
      int radiusX = (int)(kernel.GetLength(0) / 2);
      int radiusY = (int)(kernel.GetLength(1) / 2);
      float resultR = 0.0f;
      float resultG = 0.0f;
      float resultB = 0.0f;

      for (int lenY = -radiusY; lenY <= radiusY; ++lenY)
      {
        for (int lenX = -radiusX; lenX <= radiusX; ++lenX)
        {
          int idX = clamp(x + lenX, 0, sourseImage.Width - 1);
          int idY = clamp(y + lenY, 0, sourseImage.Height - 1);
          Color neighborColor = sourseImage.GetPixel(idX, idY);

          resultR += neighborColor.R + kernel[lenX + radiusX, lenY + radiusY];
          resultG += neighborColor.G + kernel[lenX + radiusX, lenY + radiusY];
          resultB += neighborColor.B + kernel[lenX + radiusX, lenY + radiusY];
        }
      }

      return Color.FromArgb(clamp((int)resultR, 0, 255),
                            clamp((int)resultG, 0, 255),
                            clamp((int)resultB, 0, 255));
    }
  }
}
