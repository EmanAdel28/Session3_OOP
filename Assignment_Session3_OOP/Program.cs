namespace Assignment_Session3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part02 Q1
            //1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects
            //and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] person = new Person[3];

            person[0] = new Person("Eman" , 23);
            person[1] = new Person("Amira" , 23);
            person[2] = new Person("Mohamed" , 34);


            Console.WriteLine("Data of Persons : ");
            try
            {

                for (int i = 0; i < person?.Length; i++)
                {
                    Console.WriteLine(person[i]);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            #endregion
        }
    }
}
