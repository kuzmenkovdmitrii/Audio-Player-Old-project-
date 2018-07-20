using System.Drawing;

namespace AudioPlayer
{
    public class CustomColor
    {
        public static readonly Color defaultcolor = Color.FromArgb(222, 140, 51);
        public static Color maincolor = Color.FromArgb(222, 140, 51);

        public static Image FillShape(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (bmp.GetPixel(j, i) != Color.FromArgb(0,0,0,0))
                    {
                        bmp.SetPixel(j, i, maincolor);
                    }
                }
            }
            return bmp;
        }
        
        public static Color GetMainColor()
        {
            return maincolor;
        }

        public static void SetMainColor(Color clr)
        {
            maincolor = clr;
        }

        public static Color GetDefaultColor()
        {
            return defaultcolor;
        }

        public static Bitmap ColoredObject(Image img, Color clr)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (bmp.GetPixel(j, i) != Color.FromArgb(0, 0, 0, 0))
                    {
                        bmp.SetPixel(j, i, clr);
                    }
                }
            }
            return bmp;
        }

        public static void ColoredImage(Image img, Color clr)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (bmp.GetPixel(j, i) != Color.FromArgb(0, 0, 0, 0))
                    {
                        bmp.SetPixel(j, i, clr);
                    }
                }
            }
            img = bmp;
        }
    }
}
