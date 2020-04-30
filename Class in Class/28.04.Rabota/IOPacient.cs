using System;
using static System.Console;

namespace _28._04.Rabota
{
    public class IOPacient
    {
       
        public static void InputPacient(out Pacient pacient,Doctor doctor)
        {

            WriteLine($"Пациент");
            Write("Введите Имя ");
            var Name = ReadLine();
            Write("Болезнь ");
            var Disease = ReadLine();
            Write("Введите начало лечения");
            WriteLine("Введите год -");
            var year = Convert.ToInt32(ReadLine());
            Write("Введите месяц -");
            var month = Convert.ToInt32(ReadLine());
            Write("Введите день -");
            var day = Convert.ToInt32(ReadLine());
            DateTime date = new DateTime(year, month, day);
            pacient = new Pacient(doctor,Name,date,Disease);
            Clear();


        }

       public  static void OutputPacient(Pacient pacient)
        {
            WriteLine("+Пациент+");
            WriteLine($"Название -{pacient.Name }");
            WriteLine($"Дата начала лечения - {pacient.BeginOfMedical.ToLongDateString()}");
            WriteLine($"Заболевание - {pacient.Disease}");
            WriteLine();
            WriteLine($"+Лечащий врач+");
            IODoctor.OutputDoctor(pacient.Doctor);
            ReadKey();
            Clear();



        }

    }
}
