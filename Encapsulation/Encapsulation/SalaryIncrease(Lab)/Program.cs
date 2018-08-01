using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPersons = int.Parse(Console.ReadLine());
            List<Person> persons = Persons(numberOfPersons);
            persons = IncreaseSalary(persons);
            PrintPersons(persons);
        }

        private static List<Person> IncreaseSalary(List<Person> persons)
        {
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(s => s.IncreaseSalary(bonus));
            return persons;
        }

        private static void PrintPersons(List<Person> persons)
        {
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }

        private static List<Person> Persons(int numberOfPersons)
        {
            var persons = new List<Person>();
            for (int i = 0; i < numberOfPersons; i++)
            {
                persons.Add(AddPerson());
            }
            return persons;
        }

        private static Person AddPerson()
        {
            //input: first name, last name, age, salary
            var newPerson = Console.ReadLine().Split();
            return new Person(newPerson[0], newPerson[1], int.Parse(newPerson[2]), decimal.Parse(newPerson[3]));
        }
    }

