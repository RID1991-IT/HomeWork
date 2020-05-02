using System;
using static System.Console;

namespace Классы_и_наследования_в_Шарпе
{
    class Program
    {
        static void Show(Aspirant aspirant)
        {
            WriteLine($"{ aspirant.Name} { aspirant.Age} { aspirant.Sex} {aspirant.Faculty} {aspirant.DiplomWork}");

        }

        static void Main(string[] args)
        {


            Aspirant aspirant = new Aspirant()
            {
                Name = "Pasha",
                Age = 342,
                Sex = SexType.Male,
                Faculty = "Abra Kadabra",
                DiplomWork="Kadabra "
               
            };
            Show(aspirant);

        }
    }


    
}
