using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public class InputDoc
    {
        public int PixelsWidth { get; private set; }
        public int PixelsHeight { get; private set; }
        public int WidthResolution { get; private set; }
        public int HeightResolution { get; private set; }

        public double Width { get; set; }
        public double Height { get; set; }

        public InputDoc(int pixelsWidth, int pixelsHeight, int widthResolution, int heightResolution)
        {
            PixelsWidth = pixelsWidth;
            PixelsHeight = pixelsHeight;
            WidthResolution = widthResolution;
            HeightResolution = heightResolution;
        }

    }

}
