using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Demo
{
    internal struct  Employee
    {
        //encabulation : seperate data definition from  its use [getter ,setter]
        
        #region attribute 
        private int id;
        private string? name;
        private decimal salary;
        private decimal deduction=default;// derived attribute


        #endregion

        #region constructor 

        public Employee(int id,string? name,decimal age)
        {
            this.id = id;
            this.name = name;
            this.salary = age;
        }
        #endregion

        #region apply encabsulatuioin  through setter and getter [old approach]
        //set
        public void setid (int id)
        {
            this.id=id;
        }

        //Getter 
        public int getid ()
        {  return id; }
        #endregion

        #region apply encabsulatuioin  through setter and getter [new approach] make full property
        //propfull
        public string? Name
        {
            get
            { 
                return name; 
            }
            set
            {
                name = value is null ? null : value?.Length <= 10 ? value : value.Substring(0, 10);
            }

            //init // only prevent set data after opject 
            //{
            //    name = value is null ? null : value?.Length <= 10 ? value : value.Substring(0, 10);
            //}
        }
        public int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id =(int) value;
            }

            //init // only prevent set data after opject 
            //{
            //    name = value is null ? null : value?.Length <= 10 ? value : value.Substring(0, 10);
            //}
        }

        public decimal? Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary =value>=5000?(decimal)value:5000;
            }


            //init // only prevent set data after opject 
            //{
            //    name = value is null ? null : value?.Length <= 10 ? value : value.Substring(0, 10);
            //}
        }

        public decimal? Deduction //read only property
        {
            get
            {
                return deduction= salary *(decimal)0.2;
            }
            
        }
        #endregion

        #region atomatic property background field
        // prop
        public int mo { get; set; }
        #endregion
        #region method
        public override string ToString()
        {
            return $"id = {id}, name = {name} , salary ={salary}";
        }
        #endregion



    }
}
