using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; }

        public int Age { get; }

        public DateTime Birthdate { get; }

        public Person(string name, int age, DateTime birthdate)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        //public string GetName()
        //{
        //    return Name;
        //}
    }
}
