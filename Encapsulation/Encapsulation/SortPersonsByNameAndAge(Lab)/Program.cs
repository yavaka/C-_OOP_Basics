using System;
using System.Collections.Generic;
using System.Linq;
namespace SortPersonsByNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPersons = int.Parse(Console.ReadLine());
            List<Person> persons = Persons(numberOfPersons);
            PrintPersons(persons);
        }

        private static void PrintPersons(List<Person> persons)
        {
            persons.OrderBy(f => f.FirstName)
                .ThenBy(a => a.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
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
            //input: first name, last name, age
            var newPerson = Console.ReadLine().Split();
            return new Person(newPerson[0], newPerson[1], int.Parse(newPerson[2]));
        }
    }
}
