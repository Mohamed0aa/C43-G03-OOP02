using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public enum Security_level
    {
        guest,
       Developer,
       secretary,
        DBA
    }
    internal class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Security_level  security_level { get; set; }
        public decimal salary { get; set; }
        public string Hire_date { get; set; }
        public char gender { get; set; }

        public char Gender
        {
            get {return gender;}
            set
            {
                if(value !='M' &&  value !='F')
                {
                    gender= 'F';
                }
                else
                {
                    gender = value;
                }
            }
        }


        //method
        public override string ToString()
        {
            return $"name = {Name}\n id = {ID}\n security_level = {security_level}\n salary = {salary}\n Hire_date = {Hire_date}\n gender ={gender}";
        }


    }
}
