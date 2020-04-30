using System;


namespace _28._04.Rabota
{
    public class Pacient
    {
        public Doctor Doctor { private set; get; }
        public string Name { private set; get; }
        public DateTime BeginOfMedical { private set; get; }
        public string Disease { private set; get; }


        public Pacient(Doctor doctor,string name,DateTime beginOfMedical, string disease)
        {
            Doctor = doctor;
            Name = name;
            BeginOfMedical = beginOfMedical;
            Disease = disease;
        }

    }
}
