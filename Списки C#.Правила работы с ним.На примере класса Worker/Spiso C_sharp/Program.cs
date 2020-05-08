using System;
using System.Collections;

namespace Spiso_C_sharp
{
    public class Worker
    {
        public string name;
        public int age;
        public char sex;
        public int salary;
        public Worker(string name1,int age1,char sex1,int salary1)
        {
            name = name1;
            age = age1;
            sex = sex1;
            salary = salary1;


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();//ининциализация списка
            Worker worker2 = new Worker("number2", 4411, 'w', 54455);
            Worker worker3 = new Worker("number3", 444, 'w', 77555);
            list.Add(new Worker("number1", 44, 'm', 555));//внесение в конструктор
            list.Add(worker2);
            list.Add(worker3);
            Worker pp = (Worker)list[0];//чтоб обратиться к определенному индексу(начинается с нуля)
            foreach (var item in list)//проходим по всему листу,вводим временную переменную temp,для вывода нужных данных.
            {
               Worker temp = (Worker)item;
               Console.WriteLine(temp.name);
               Console.WriteLine(temp.age);
               Console.WriteLine($"Sex is {temp.sex}");
               Console.WriteLine($"Salary is {temp.salary}");
               Console.WriteLine();
            }

            Console.WriteLine(pp.name);
        }
    }
}
