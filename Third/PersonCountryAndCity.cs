using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class PersonCountryAndCity :PersonIdentification
    {
        public string Country { get; set; }
        public string City { get; set; }
        public PersonCountryAndCity(int id, long unicCode, string country, string city) : base(id, unicCode)
        {
            Country = country;
            City = city;
        }

        public void Info()
        {
            Console.WriteLine($"Id  - {Id}\nUniCode - {UnicCode}\nCoyntry - {Country}\nCity - {City} ");
        }

    }
}
