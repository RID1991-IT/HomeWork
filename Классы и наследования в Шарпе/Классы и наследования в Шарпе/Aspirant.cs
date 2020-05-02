using System;
using System.Collections.Generic;
using System.Text;

namespace Классы_и_наследования_в_Шарпе
{
    class Aspirant:Student
    {
        public string DiplomWork { set; get; }
        public Aspirant() { }
        public Aspirant(string name,int age,SexType sex,string faculty,string diplomWork)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Faculty = faculty;
            DiplomWork = diplomWork;
            
        }
    }
}
