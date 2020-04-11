using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAdaptation
{
  class BlurFilter : MatrixFilter
  {
    public BlurFilter()
    {
      int nX = 3;
      int nY = 3;

      kernel = new float[nX, nY];

      for (int i = 0; i < nX; ++i)
      {
        for (int j = 0; j < nY; ++j)
        {
          kernel[i, j] = 1.0f / (float)(nX * nY);
        }
      }
    }
  }
}
