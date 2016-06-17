using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public class MMConvertor : IConvertor
    {
        public double MaxWidth { get; set; }
        public double MaxHeight { get; set; }

        public MMConvertor()
        {
            MaxWidth = 210;
            MaxHeight = 297;
        }

        public void Convert(InputDoc[] doc)
        {
            foreach (var page in doc)
            {
                page.Width = page.PixelsWidth / page.WidthResolution;
                page.Height = page.PixelsHeight / page.HeightResolution;
            }
        }
    }
}
