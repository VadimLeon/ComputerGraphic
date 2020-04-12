using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageAdaptation
{
  class BrightAddFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
    {
      Color sourseColor = sourseImage.GetPixel(x, y);
      int k = 20;
      Color resourse = Color.FromArgb(Clamp(sourseColor.R + k, 0, 255),
                                      Clamp(sourseColor.G + k, 0, 255),
                                      Clamp(sourseColor.B + k, 0, 255));
      
      return resourse;
    }
  }
}
