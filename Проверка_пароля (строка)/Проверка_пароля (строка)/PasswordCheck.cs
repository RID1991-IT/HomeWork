using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public static class PasswordCheck
    {
        private const int passwordLength = 8;

        private const string symbol1 = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string symbol2 = "qwertyuiopasdfghjklzxcvbnm";
        private const string symbol3 = "!@#$%^&*:;.,-";
        private const string symbol4 = "1234567890";

        public static bool Check(string password)
        {
            password = password.Trim();

            int pass_check1 = password.IndexOfAny(symbol1.ToCharArray());//переводим стринговые переменные в чаровский массив и проверяем есть ли хоть один из представленных символов
            int pass_check2 = password.IndexOfAny(symbol2.ToCharArray());
            int pass_check3 = password.IndexOfAny(symbol3.ToCharArray());
            int pass_check4 = password.IndexOfAny(symbol4.ToCharArray());

            if (password.Length < passwordLength)
            {
                return false;
            }
            else
            {
                if (pass_check1 == -1 || pass_check2 == -1 || pass_check3 == -1 || pass_check4 == -1)//есть indexOFany =-1,значит нет ни одного подходящего сивола
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}