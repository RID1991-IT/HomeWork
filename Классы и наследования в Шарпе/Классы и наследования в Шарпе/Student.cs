using System;
using System.Collections.Generic;
using System.Text;

namespace Классы_и_наследования_в_Шарпе
{
    public enum SexType{Male, Gemale, Other};//перечисление
    public abstract class Student//не может быть экземпляром класса так как abstract
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public SexType Sex{set;get;}
        public string Faculty { set; get; }

    }
}
