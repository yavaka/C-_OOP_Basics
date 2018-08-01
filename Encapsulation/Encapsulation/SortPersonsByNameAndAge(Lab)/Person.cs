using System;
using System.Collections.Generic;
using System.Text;

namespace SortPersonsByNameAndAge
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
        }

        private int age;

        public int Age
        {
            get { return age; }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
