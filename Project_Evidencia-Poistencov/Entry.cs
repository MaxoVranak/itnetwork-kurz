using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Evidencia_Poistencov
{
    class Entry
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public Entry(string name, string surname, string phoneNumber, int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}\t{Surname}\t{Age}\t{PhoneNumber}";
        }
    }
}
