using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment
{
    internal class Date
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public override string ToString()
        {
            return $"day = {day}\n month = {month}\n yeat ={year}";
        }
    }
}
