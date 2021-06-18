using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class UI
    {

        public void MainMenu()
        {
            string choice = "start";
            while (!choice.Equals("quit"))
            {
                Console.WriteLine("1 - Enter a new participant");
                Console.WriteLine("2 - Enter a new team");
                Console.WriteLine("3 - Enter a new event");
                Console.WriteLine("4 - Enter a new tournament");
                Console.WriteLine("5 - Add a participant to a team");
                Console.WriteLine("or type quit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter participant name");
                        string name = Console.ReadLine();
                        Participant p = new Participant();
                        p.setName(name);
                        p.printParticipant();
                        break;

                    case "2":
                        Console.WriteLine("Enter team name");
                        name = Console.ReadLine();
                        Team t = new Team();
                        t.setName(name);
                        t.printTeam();
                        break;

                    case "3":
                        Console.WriteLine("Enter event name");
                        name = Console.ReadLine();
                        Event e = new Event();
                        e.setName(name);
                        e.printEvent();
                        break;

                    case "4":
                        Console.WriteLine("Enter tournament name");
                        name = Console.ReadLine();
                        Tournament s = new Tournament();
                        s.setName(name);
                        s.printTournament();
                        break;

                    case "5":
                        Team teamselected = AllTeams[selectTeam()];
                        Participant partselected = allParticipants[selectParticipant()];
                        teamselected.addParticipant(partselected);
                        teamselected.printTeam();
                        break;
                }
            }

        }
    }
}