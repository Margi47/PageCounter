using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public abstract class IConvertor
    {
        public abstract double MaxSquare { get; set; }
        public abstract double Inaccuracy { get; set; }

        public double[] Convert(InputDoc[] doc)
        {
            var result = new List<double>();
            foreach (var page in doc)
            {
                double square = ((page.PixelsWidth / page.WidthResolution) * (page.PixelsHeight / page.HeightResolution));
                result.Add(square);
            }
            return result.ToArray();
        }
    }
}
