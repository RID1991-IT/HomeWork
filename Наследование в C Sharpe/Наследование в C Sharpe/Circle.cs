using System;
using System.Collections.Generic;
using System.Text;

namespace Наследование_в_C_Sharpe
{
    class Circle:Figure
    {
        double Radius { set; get; }

        public Circle() { }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            Area = 2 * PI * (Radius * Radius);
            return Area;

        }
    }
}
