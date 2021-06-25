using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class UI
    {
        List<Participant> allParticipants = new List<Participant>();
        List<Team> allTeams = new List<Team>();
        List<Event> allEvent = new List<Event>();
        private List<Tournament> allTournament = new List<Tournament>();


        public int selectTeam()
        {
            for (int i = 0; i < allTeams.Count; i++)
            {
                Console.WriteLine(i + ": " + allTeams[i].getName());
            }

            Console.WriteLine("Select team: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public int selectParticipant()
        {
            for (int i = 0; i < allParticipants.Count; i++)
            {
                Console.WriteLine(i + ": " + allParticipants[i].getName());
            }

            Console.WriteLine("Select Participant: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public int selectEvent()
        {
            for (int i = 0; i < allEvent.Count; i++)
            {
                Console.WriteLine(i + ": " + allEvent[i].getName());
            }
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public int selectTournament()
        {
            for (int i = 0; i < allTournament.Count; i++)
            {
                Console.WriteLine(i + ": " + allTournament[i].getName());
            }
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public void MainMenu()
        {
            string choice = "start";
            while (!choice.Equals("quit"))
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Enter a new participant");
                Console.WriteLine("2 - Enter a new team");
                Console.WriteLine("3 - Enter a new event");
                Console.WriteLine("4 - Enter a new tournament");
                Console.WriteLine("5 - Add a participant to a team");
                Console.WriteLine("6 - Add team to event");
                Console.WriteLine("7 - Add event to Tournament");
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
                        Team teamselected = allTeams[selectTeam()];
                        Participant partselected = allParticipants[selectParticipant()];
                        teamselected.addParticipant(partselected);
                        teamselected.printTeam();
                        break;

                    case "6":
                        
                        break;

                    case "7":
                        
                        break;
                }
            }

        }
    }
}