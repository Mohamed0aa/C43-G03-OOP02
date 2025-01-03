using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal struct Person
    {
        public string name {  get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"nmae ={name}\n age = {age}";
        }

    }
}
