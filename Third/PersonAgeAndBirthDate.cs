using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class PersonAgeAndBirthDate :PersonIdentification
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

        public PersonAgeAndBirthDate(int id, long unicCode, DateTime birthDate, int age) : base(id, unicCode)
        {
            Age = age;
            BirthDate = birthDate;
        }
        public void Info()
        {
            Console.WriteLine($"Id  - {Id}\nUniCode - {UnicCode}\nBirthdate - {BirthDate}\nAge - {Age} ");
        }
    }
}
