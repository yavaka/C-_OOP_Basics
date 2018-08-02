using System;
using System.Collections.Generic;
using System.Text;


    public class Team
    {
    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    private string name;

    public string Name
    {
        get { return name; }
    }


    private List<Person> firstTeam;

    public List<Person> FirstTeam
    {
        get { return firstTeam; }
    }


    private List<Person> reserveTeam;

    public List<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }


    public void AddPlayer(Person player)
    {
        if (player.Age<40)
        {
            firstTeam.Add(player);
        }
        else
        {
            reserveTeam.Add(player);
        }
    }
}
