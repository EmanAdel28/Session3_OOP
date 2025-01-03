namespace Assignment_Session3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part02 Q1
            //1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects
            //and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[3];

            //person[0] = new Person("Eman" , 23);
            //person[1] = new Person("Amira" , 23);
            //person[2] = new Person("Mohamed" , 34);


            //Console.WriteLine("Data of Persons : ");
            //try
            //{

            //    for (int i = 0; i < person?.Length; i++)
            //    {
            //        Console.WriteLine(person[i]);
            //    }
            //}catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            #endregion

            #region Part02 Q2
            //2 Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from
            //the user and displays the name and age of the oldest person.

            //Person[] person = new Person[3];
            //bool Flags;
            //int Age;
            //Console.WriteLine("Enter data of user : ");

            //for(int i = 0; i < person?.Length; i++)
            //{
            //        Console.Write($"Enter Name Of Person {i+1} : ");
            //    person[i].Name= Console.ReadLine();

            //    do
            //    {
            //        Console.Write($"Enter Age Of Person {i+1} : ");
            //        Flags = int.TryParse(Console.ReadLine(), out  Age);

            //    } while (!Flags || Age < 0);

            //    person[i].Age = Age;
            //}
            //Console.Clear();
            //Console.WriteLine("Data Of The Oldest Person. ");

            //Person oldestPerson = person[0];
            //for (int i = 1; i < person.Length; i++)
            //{
            //    if (person[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person[i];
            //    }
            //}
            //Console.WriteLine(oldestPerson);

            #endregion

            #region Part03 
            HiringDate hireDate1 = null;
            HiringDate hireDate2 = null;
            HiringDate hireDate3 = null;

            try
            {
                hireDate1 = new HiringDate(2, 1, 2024); // Invalid month
                hireDate2 = new HiringDate(20, 3, 2023); // Invalid month
                hireDate3 = new HiringDate(16, 5, 2022); // Invalid month
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); // Will print: "Month must be between 1 and 12."
            }

            Employee[] employee = new Employee[3];

            employee[0] = new Employee(1, "Eman", SecurityLevel.Developer, 20000, hireDate1, Gender.F);
            employee[1] = new Employee(2, "Amira", SecurityLevel.Developer, 30000, hireDate2, Gender.F);
            employee[2] = new Employee(3, "Nohammed", SecurityLevel.Developer, 40000, hireDate3, Gender.M);

            //for(int i = 0; i < employee.Length; i++)
            //{
            //    Console.WriteLine(employee[i]);

            //}

            Console.WriteLine("Before Sorting : \n");
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }

            // Sorting based on HireDate and counting boxing/unboxing
            int boxingCount = 0;
            Array.Sort(employee, (x, y) =>
            {
                boxingCount++; // Boxing during comparison
                return x.HireDate.CompareTo(y.HireDate);
            });

            Console.WriteLine("\nAfter Sorting : \n");
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine($"\nNumber of times boxing occurred during sorting: {boxingCount}");
            #endregion
        }
    }
}
