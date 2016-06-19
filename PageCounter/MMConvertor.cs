using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public class MMConvertor : IConvertor
    {
        public override double MaxSquare { get; set; }

        public override double Inaccuracy { get; set; }

        public MMConvertor()
        {
            MaxSquare = 62370;
            Inaccuracy = 2535;
        }
        
    }
}
