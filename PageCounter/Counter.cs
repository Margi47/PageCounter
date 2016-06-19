using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public class Counter
    {
        public IConvertor SelectConventor(MeasurementUnit unit)
        {
            IConvertor conventor = default(IConvertor);
            if (unit == MeasurementUnit.Inches)
            {
                conventor=new InchConvertor();
            }
            else if (unit == MeasurementUnit.Millimetres)
            {
                conventor = new MMConvertor();
            }
            return conventor;
        }

        public int CountPages(InputDoc[] doc, MeasurementUnit unit)
        {
            IConvertor conventor=SelectConventor(unit);
            double[] square = conventor.Convert(doc);

            int count = 0;
            for (int i=0; i<square.Length; i++)
            {
                count++;
                while ( square[i] > conventor.MaxSquare+conventor.Inaccuracy)
                {
                    square[i] -= conventor.MaxSquare;
                    count++;
                }
            }
            return count;
        }
    }
}
