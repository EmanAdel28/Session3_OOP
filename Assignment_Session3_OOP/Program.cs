using System.Net.Http.Headers;
using Assignment_Session3_OOP.Inheritance;

namespace Assignment_Session3_OOP
{
   
    internal class Program
    {
        public static int Sum(int x, int y)
        { return x + y; }

        public static int Sum(int x, int y , int z)
        { return x + y + z; }

        public static double Sum(double x, double y)
        { return x + y; }
        static void Main(string[] args)
        {
            #region Inheritance
            //Parent parent = new Parent(1,2);
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.prodect());

            //Child child = new Child(1, 2 , 3);
            //Console.WriteLine(child);
            //Console.WriteLine(child.prodect());
            #endregion
            #region Access Modifier
            // Private Protected
            // Protected
            // Internal Protected
            #endregion

            #region RelationShips Between Classes
            //1) Inheritance [FullTime Employee is a Employee]
            //2) Aggreagetion [Department has Employee]
            // 2.1 Composition => Room has walls
            // 2.2 Association => Room has chairs
            #endregion

           

        }
    }
}
