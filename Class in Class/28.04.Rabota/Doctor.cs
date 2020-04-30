using System;

namespace _28._04.Rabota
{
   public class Doctor
    {
        public string FirstName { private set; get; }
        public string LasttName { private set; get; }
        public DateTime BirthDay { private set; get; }
        public string Specialization { private set; get; }
       
        public Doctor(string firstName,string lastName,DateTime birthDay,string specilization)
        {
            FirstName = firstName;
            LasttName = lastName;
            BirthDay = birthDay;
            Specialization = specilization;
        }

    }
}
