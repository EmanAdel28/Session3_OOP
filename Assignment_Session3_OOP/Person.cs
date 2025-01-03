using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session3_OOP
{
    internal struct Person
    {
       

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name is : {Name} , Age is : {Age}";
        }

    }
}
