using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class PersonNameAndAddress:PersonIdentification
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public PersonNameAndAddress(int id, long unicCode, string name, string address) : base(id, unicCode)
        {
            Name = name;
            Address = address;
        }
        public void Info()
        {
            Console.WriteLine($"Id  - {Id}\nUniCode - {UnicCode}\nName - {Name}\nAddress - {Address} ");
        }
    }
}
