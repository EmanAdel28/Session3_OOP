using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session3_OOP.Inheritance
{
    internal class Parent
    {
      
        #region Propert
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Costructor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Functions

        //public int prodect()
        //{
        //    return X * Y;
        //}

        public void Fun1()
        {
            Console.WriteLine("I am Parent");
        }

        public virtual void Fun2()
        {
            Console.WriteLine("Hello Parent");
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        #endregion

    }
}
