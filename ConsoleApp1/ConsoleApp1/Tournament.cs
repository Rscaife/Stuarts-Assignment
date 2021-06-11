using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class Tournament
    {
        string tournamentname;
        List<Team> teams = new List<Team>();

        public void setName(String s)
        {
            this.tournamentname = s;
        }

        public string getName()
        {
            return tournamentname;
        }

        public void addTeam(Team t)
        {
            if (teams.Count >= 4)
            {
                Console.WriteLine("Tournament Is Full.");
            }
            else
            {
                teams.Add(t);
            }
        }
    }
}
