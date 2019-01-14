using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class TaxCalc
    {
        public static double getNdc(float sum)
        {
            return sum * 0.18;
        }
    }
}
