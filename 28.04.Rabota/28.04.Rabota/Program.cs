using System;
using static System.Console;
namespace _28._04.Rabota
{
    class Program
    {

        static void Main(string[] args)
        {
            
            IODoctor.InputDoctor(out Doctor doctor);
            IODoctor.OutputDoctor(doctor);
            IOPacient.InputPacient(out Pacient pacient,doctor);
            IOPacient.OutputPacient(pacient);

        }
    }
}
