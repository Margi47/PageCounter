using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public interface IConvertor
    {
        double MaxWidth { get; set; }
        double MaxHeight { get; set; }
        void Convert(InputDoc[] doc);
    }
}
