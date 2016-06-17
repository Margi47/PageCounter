using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    public class Counter
    {
        

        public int CountPages(InputDoc[] doc, MeasurementUnit unit)
        {
            IConvertor conventor=default(IConvertor);
            if (unit == MeasurementUnit.Inches)
            {
                conventor=new InchConvertor();
            }
            else if (unit == MeasurementUnit.Millimetres)
            {
                conventor = new MMConvertor();
            }

            conventor.Convert(doc);

            int count = 0;
            foreach (var page in doc)
            {
                count++;
                while (page.Height > conventor.MaxHeight)
                {
                    page.Height -= conventor.MaxHeight;
                    count++;
                }

                while (page.Width > conventor.MaxWidth)
                {
                    page.Width -= conventor.MaxWidth;
                    count++;
                }
            }
            return count;
        }
    }
}
