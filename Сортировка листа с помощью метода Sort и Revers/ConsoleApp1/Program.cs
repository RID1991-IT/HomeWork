using System;
using System.Collections;

namespace Spiso_C_sharp
{
  
    class Program
    {
        public static void Output(ArrayList list)
        {
            foreach (var item in list)
            {
                int temp = (int)item;
                Console.Write($" {temp} ");
            }
        }

        public static void Sort(ArrayList list)//сортировка массива от 0 до 5 по возрастанию от 5 до 9 по убыванию
        {
            list.Sort(0, 5,null);//пишем что сортируем(list)индекс(0)количество которое меняем(5),метод ICompare(null)
            list.Sort(5, 5,null);
            list.Reverse(5,5);//метод переворачивает елементы 
        }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();//ининциализация списка
            ArrayList list2 = new ArrayList();//ининциализация списка

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(0,10));
            }
            Output(list);
            Console.WriteLine();
            Sort(list);
            Output(list);


        }
    }
}