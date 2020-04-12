using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageAdaptation
{
  class SepiaFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
    {
      Color sourseColor = sourseImage.GetPixel(x, y);
      float k = 1.5f;
      int intensity = (int)(0.299 * sourseColor.R + 0.587 * sourseColor.G + 0.114 * sourseColor.B);
      Color resultColor = Color.FromArgb(Clamp((int)(intensity + 2 * k), 0, 255),
                                         Clamp((int)(intensity + 0.5 * k), 0, 255),
                                         Clamp((int)(intensity - k), 0, 255));

      return resultColor;
    }
  }
}
