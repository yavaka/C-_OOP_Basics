using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var numberOfPersons = int.Parse(Console.ReadLine());
        List<Person> persons = Persons(numberOfPersons);
        Team team = Team(persons);
        PrintTeam(team);
    }

    private static Team Team(List<Person> persons)
    {
        var team = new Team("SoftUni");
        foreach (var person in persons)
        {
            team.AddPlayer(person);
        }
        return team;
    }

    private static void PrintTeam(Team team)
    {
        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
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
        try
        {
            return new Person(newPerson[0], newPerson[1], int.Parse(newPerson[2]), decimal.Parse(newPerson[3]));
        }
        catch (ArgumentException argExc)
        {
            Console.WriteLine(argExc.Message);
        }

        return null;
    }
}

