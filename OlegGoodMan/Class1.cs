using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGoodMan
{
    public class Class1
    {
        public Double Sum(double? a, int b, decimal c) {

          Double  a1 = Convert.ToDouble(a);
            Double b1 = Convert.ToDouble(b);
            Double c1 = Convert.ToDouble(c);

            return a1*b1*c1;

        }
    }
}
