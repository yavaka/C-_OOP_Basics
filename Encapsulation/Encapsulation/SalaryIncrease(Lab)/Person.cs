using System;
using System.Collections.Generic;
using System.Text;

    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
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

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }
    }

