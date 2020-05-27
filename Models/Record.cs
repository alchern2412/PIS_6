﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Record
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public Record() { }

        public Record(int Id, string Name, string Number)
        {
            this.Id = Id;
            this.Name = Name;
            this.Number = Number;
        }
    }
}
