using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace VisualizationTomogram
{
  class View
  {
    public int minimum = 0;
    public int windowWidth = 2000;

    public void SetupView(int width, int height)
    {
      GL.ShadeModel(ShadingModel.Smooth);
      GL.MatrixMode(MatrixMode.Projection);
      GL.LoadIdentity();
      GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
      GL.Viewport(0, 0, width, height);
    }

    int clamp(int value, int min, int max)
    {
      return Math.Min(max, Math.Max(min, value));
    }

    Color TransferFunction(short value)
    {
      int min = minimum;
      int max = minimum + windowWidth;
      int newVal = clamp((value - min) * 255 / (max - min), 0, 255);
      return Color.FromArgb(255, newVal, newVal, newVal);
    }

    public void DrawQuads(int layerNumber)
    {
      short value;
      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

      for (int x_coord = 0; x_coord < Bin.X - 1; x_coord++)
      {
        GL.Begin(BeginMode.QuadStrip);

        value = Bin.array[x_coord + layerNumber * Bin.X * Bin.Y];
        GL.Color3(TransferFunction(value));
        GL.Vertex2(x_coord, 0);

        value = Bin.array[(x_coord + 1) + layerNumber * Bin.X * Bin.Y];
        GL.Color3(TransferFunction(value));
        GL.Vertex2(x_coord + 1, 0);

        for (int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
        {
          value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
          GL.Color3(TransferFunction(value));
          GL.Vertex2(x_coord, y_coord);

          value = Bin.array[(x_coord + 1) + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
          GL.Color3(TransferFunction(value));
          GL.Vertex2(x_coord + 1, y_coord);
        }
        GL.End();
      }
    }
  }
}
