using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    public class PersonExtended:PersonNameAndAddress
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate{ get; set; }
        public int Age { get; set; }
        public PersonExtended(string name, string address, DateTime birthdate, int age) : base(name, address)
        {
            Birthdate = birthdate;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine($"Name  - {Name}\nAddress - {Address}\nBirthdate - {Birthdate}\nAge - {Age} ");
        }
    }
}
