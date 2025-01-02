using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class parent
    {
        #region attribute
        public int X { get; set; }
        public int Y { get; set; }
        #endregion


        #region constructor
        public parent(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        //public parent()
        //{

        //}
        //#endregion
        #endregion
        #region methode
        public int product()
        {
            return X*Y;
        }

        public override string ToString()
        {
            return$"x= {X} y={Y}";
        }
        #endregion
    }
}