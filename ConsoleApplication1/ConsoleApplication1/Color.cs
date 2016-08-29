using System;

namespace ConsoleApplication1
{
    class Color
    {
        private byte red, green, blue, alpha;

        //Creating constructor for just three colors
        public Color(byte red,byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }
        
        //Creating constructor for all colors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        //Getting colors
        public byte GetRedColor()
        {
            return red;
        }

        public byte GetGreenColor()
        {
            return green;
        }

        public byte GetBlueColor()
        {
            return blue;
        }

        public byte GetAlphaColor()
        {
            return alpha;
        }

        //Setting Colors
        public void SetRedColor(byte red)
        {
            this.red=red;
        }

        public void SetGreenColor(byte green)
        {
            this.green=green;
        }

        public void SetBlueColor(byte blue)
        {
            this.blue=blue;
        }

        public void SetAlphaColor(byte alpha)
        {
            this.alpha=alpha;
        }

        //Getting grayscale value
        public byte GetGrayscaleValue(byte red, byte green, byte blue)
        {
            return (byte)( (red + green + blue) / 3);
        }

      
    }
}
