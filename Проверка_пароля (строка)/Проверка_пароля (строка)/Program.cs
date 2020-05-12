using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> accounts = new Dictionary<string, string>();//словарь,для перечисления унмкальных первых значений и любых других вторых

            string password;

            Write("Введите логин");
            string login = ReadLine();

            // TO-DO
            // 1. Проверить логин на повторяемость (логин не должен повторять уже имеющийся)
            // 2. Проверить пароль на минимальное кол-во символов и требования к символам

            Write("Введите пароль");
            password = ReadLine();
            while (!PasswordCheck.Check(password))
            {
                WriteLine("Пароль не соответствует требованиям безопасности");
                Write("Повторите ввод пароля");
                password = ReadLine();
            }

            accounts.Add(login, password);

            foreach (var account in accounts)
            {
                WriteLine($"{account.Key} - {account.Value}");
            }
        }
    }
}