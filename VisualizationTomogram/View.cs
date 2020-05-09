using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;

namespace VisualizationTomogram
{
  class View
  {
    public int minimum = 0;
    public int windowWidth = 2000;

    Bitmap textureImage;
    int    VBOtexture;

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
    public void Load2DTexture()
    {
      GL.BindTexture(TextureTarget.Texture2D, VBOtexture);

      BitmapData data = textureImage.LockBits(
        new System.Drawing.Rectangle(0, 0, textureImage.Width, textureImage.Height),
        ImageLockMode.ReadOnly,
        System.Drawing.Imaging.PixelFormat.Format32bppArgb);

      GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                    data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                    PixelType.UnsignedByte, data.Scan0);

      textureImage.UnlockBits(data);

      GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

      GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

      ErrorCode Er = GL.GetError();
      string str = Er.ToString();
    }

    public void generateTextureImage(int layerNumber)
    {
      // функция преобразует томограмму в изображение 
      textureImage = new Bitmap(Bin.X, Bin.Y);
      for (int i = 0; i < Bin.X; ++i)
        for (int j = 0; j < Bin.Y; ++j)
        {
          // получаем номер пикселя (i, j) в исходдном массиве данных 
          int pixelNumber = i + j * Bin.X + layerNumber * Bin.X * Bin.Y;

          // преобразовываем значени плотности в цвет и устанавливаем этот цвет в текущий пиксель
          textureImage.SetPixel(i, j, TransferFunction(Bin.array[pixelNumber]));
        }
    }

    public void DrawTexture()
    {
      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

      // включаем 2D текстурирование
      GL.Enable(EnableCap.Texture2D);

      // выбираем указанную текстуру VBOtexture как активную
      GL.BindTexture(TextureTarget.Texture2D, VBOtexture);

      // рисуем один прямоугольник с наложенной текстурой 
      GL.Begin(BeginMode.Quads);
      GL.Color3(Color.White);

      // задаем 4 угла прямоугольника и накладываем на него текстуру
      GL.TexCoord2(0f, 0f);
      GL.Vertex2(0, 0);
      GL.TexCoord2(0f, 1f);
      GL.Vertex2(0, Bin.Y);
      GL.TexCoord2(1f, 1f);
      GL.Vertex2(Bin.X, Bin.Y);
      GL.TexCoord2(1f, 0f);
      GL.Vertex2(Bin.X, 0);

      GL.End();

      // выключаем 2D текстурирование
      GL.Disable(EnableCap.Texture2D);
    }
  }
}
