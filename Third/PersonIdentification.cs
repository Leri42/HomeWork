﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class PersonIdentification
    {
        public int Id { get; set; }
        public long UnicCode { get; set; }
        public PersonIdentification(int id, long unicCode)
        {
            Id = id;
            UnicCode = unicCode;
        }
    }
}
