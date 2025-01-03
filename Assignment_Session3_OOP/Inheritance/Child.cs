using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session3_OOP.Inheritance
{
    internal class Child : Parent
    {

        #region Propert
        public int Z { get; set; }
       
        #endregion

        #region Costructor
        public Child(int x, int y , int z) : base(x , y )
        {
           Z = z;
        }
        #endregion

        #region Functions

        //public new int prodect()
        //{
        //    return X * Y * Z;
        //}

        public new void Fun1()
        {
            Console.WriteLine("I am Parent");
        }

        public override void Fun2()
        {
            Console.WriteLine("Hello Parent");
        }
        public override string ToString()
        {
            return $"({X},{Y} ,{Z})";
        }

        #endregion
    }
}
