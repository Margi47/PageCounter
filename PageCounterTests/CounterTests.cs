﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PageCounter;

namespace PageCounterTests
{
    public class CounterTests
    {
        InputDoc[] docs = new InputDoc[] { new InputDoc(2000, 4000, 10, 10), new InputDoc(2000, 4000, 10, 10) };

        [Fact]
        public void counter_should_return_correct_number_inMM()
        {
            Counter counter = new Counter();

            int result=counter.CountPages(docs, MeasurementUnit.Millimetres);

            Assert.True(result == 4);
        }

        [Fact]
        public void counter_should_return_correct_number_inInches()
        {
            Counter counter = new Counter();

            int result = counter.CountPages(docs, MeasurementUnit.Inches);

            Assert.True(result == 118);
        }
    }
}
