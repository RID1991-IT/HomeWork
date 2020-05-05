using System;
using static System.Console;
namespace Наследование_в_C_Sharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            Sqare sqare = new Sqare(25);

            sqare.GetArea();
            Console.WriteLine(sqare.Area);

            Circle circle = new Circle(10);
            circle.GetArea();
            Console.WriteLine(circle.Area);
        }
    }
}
