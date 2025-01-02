using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct point
    {
        //Attribute
        public int x;
        public int y;

        #region
        //constructor :special function
        //1-named only with the same name of struct or class
        // 2-no return type
        //ctor gnerate constructor
        public point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //we can generate multible constructor with diffrent tasks
        #endregion

        #region method
        public override string ToString()
            {
                return $"{x} AND {y}";
            }
        #endregion
    }
}
