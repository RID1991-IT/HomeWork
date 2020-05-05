using System;
using System.Collections.Generic;
using System.Text;

namespace Наследование_в_C_Sharpe
{
    public class Sqare:Figure
    {
        double Side { set; get; }

       public Sqare() { }
       public Sqare(int side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            Area = Side * Side;
            return Area;
        }
    }
}
