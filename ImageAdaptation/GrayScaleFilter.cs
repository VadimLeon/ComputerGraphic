using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageAdaptation
{
  class GrayScaleFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
    {
      Color sourseColor = sourseImage.GetPixel(x, y);
      int intensity = (int)(0.299 * sourseColor.R + 0.587 * sourseColor.G + 0.114 * sourseColor.B);

      return Color.FromArgb(intensity, intensity, intensity);
    }
  }
}
