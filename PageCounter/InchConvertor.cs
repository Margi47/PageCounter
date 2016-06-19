using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public class InchConvertor : IConvertor
    {
        public override double MaxSquare { get; set; }

        public override double Inaccuracy { get; set; }

        public InchConvertor()
        {
            MaxSquare = 97.11;
            Inaccuracy = 4;
        }

    }
}
