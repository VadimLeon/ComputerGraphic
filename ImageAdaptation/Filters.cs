﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Threading;

namespace ImageAdaptation
{
  abstract class Filters
  {
    public Bitmap processImage(Bitmap soursImage, BackgroundWorker worker)
    {
      Bitmap resurseImage = new Bitmap(soursImage.Width, soursImage.Height);

      for (int i = 0; i < soursImage.Width; ++i)
      {
        worker.ReportProgress((int)((float)i / (float)resurseImage.Width * (float)100));
        if (worker.CancellationPending) return null;

        for (int j = 0; j < soursImage.Height; ++j)
        {
          resurseImage.SetPixel(i, j, calculateNewPixelColor(soursImage, i, j));
        }
      }

      return resurseImage;
    }

    protected abstract Color calculateNewPixelColor(Bitmap sourseImage, int x, int y);

    public int Clamp(int value, int min, int max)
    {
      if (value < min) return min;
      if (value > max) return max;

      return value;
    }
  }
}
