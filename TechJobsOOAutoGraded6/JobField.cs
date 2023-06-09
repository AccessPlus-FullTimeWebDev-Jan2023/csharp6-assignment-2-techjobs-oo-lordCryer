﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechJobsOOAutoGraded6
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }


        public JobField() 
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object? obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
