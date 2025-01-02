using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class car
    {
        private int  id =default ;
        private string? model= default;
        private double speed= default;

        #region property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region constructor chaning
        public car (int id,string? model,double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
            Console.WriteLine("coun1");
        }
        public car(int id,string?model) : this(id, model, 102)
        {
            Console.WriteLine("co2");
        }
        #endregion

        #region method
        public override string ToString()
        {
            return $"id ={id} ,model = {model} , speed = {speed}";
        }
        #endregion
    }
}
