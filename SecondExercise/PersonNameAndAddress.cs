using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    public class PersonNameAndAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public PersonNameAndAddress(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
