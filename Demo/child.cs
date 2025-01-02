using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class child :parent
    {
        public int z {  get; set; }
        public child(int x,int y, int z) :base(x,y)
        {
            this.z = z;
        }

        public override string ToString()
        {
             return $"x= {X} y={Y} z={z}";
        }

        public new int product()
        {
            return X * Y*z;
        }
    }
}
