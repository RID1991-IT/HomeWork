using System;
using static System.Console;


namespace _28._04.Rabota
{
    class IODoctor
    {
        public static void InputDoctor(out Doctor doctor)
        {
            WriteLine(" - Доктор - ");
            Write("Введите Имя ");
            var FirstName = ReadLine();
            Write("Введите Фамилию ");
            var LasttName = ReadLine();
            Write("Введите специальность доктора - ");
            var Specialization = ReadLine();
            WriteLine("Введите дату рождения");
            Write("Введите год -");
            var year = Convert.ToInt32(ReadLine());
            Write("Введите месяц -");
            var month = Convert.ToInt32(ReadLine());
            Write("Введите день -");
            var day = Convert.ToInt32(ReadLine());
            DateTime date = new DateTime(year, month, day);//вбиваем в функцию год,месяц,день (при желании можно было бы добавить и время)
            doctor = new Doctor(FirstName, LasttName, date, Specialization);//кортеж для создания класс доктор
            Clear();
        }
        public static void OutputDoctor(Doctor doctor)
        {
            WriteLine(" - Доктор - ");
            WriteLine($" Фамилия - {doctor.LasttName}");
            WriteLine($" Имя- {doctor.FirstName}");
            WriteLine($"-Год рождения-");
            WriteLine(doctor.BirthDay.ToLongDateString());//вывод только года,месяца и дня в развернутом виде
            WriteLine($"Специализация - {doctor.Specialization}");
            ReadKey();//функция замораживает консоль пока не нажмешь на любую кнопку
            Clear();//очищение экрана консоли
        }




    }
}
