using System;
using System.Collections.Generic;
using System.Text;

namespace Наследование_в_C_Sharpe
{
    public class Figure
    {
       protected const double PI = 3.14;
       public double Area { set; get; }
       public virtual double GetArea() { return 0; }//виртуальная функция в классах показывет что в других классах должна быть ткая функция

    }
}
