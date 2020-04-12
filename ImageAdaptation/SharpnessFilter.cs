﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAdaptation
{
  class SharpnessFilter : MatrixFilter
  {
    public SharpnessFilter()
    {
      kernel = new float[3, 3];

      kernel[0, 0] =  0.0f;
      kernel[0, 1] = -1.0f;
      kernel[0, 2] =  0.0f;
      kernel[1, 0] = -1.0f;
      kernel[1, 1] =  5.0f;
      kernel[1, 2] = -1.0f;
      kernel[2, 0] =  0.0f;
      kernel[2, 1] = -1.0f;
      kernel[2, 2] =  0.0f;
    }
  }
}
