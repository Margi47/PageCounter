using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            InputDoc[] doc = new InputDoc[] { new InputDoc(20000, 40000, 12, 20), new InputDoc(20000, 40000, 12, 20) };
            
            Console.WriteLine(counter.CountPages(doc, MeasurementUnit.Millimetres));
            Console.ReadKey();
        }
    }
}
