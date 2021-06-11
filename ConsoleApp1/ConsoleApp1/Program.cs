using System;

namespace Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            Participant p = new Participant();
            p.setName("Rainen");
            t.addParticipant(p);
            p.printParticipant();
            p = new Participant();
            p.setName("Ethan");
            p.printParticipant();
            t.addParticipant(p);
            
            t.setName("Rainen's Team");
            t.printTeam();
        }
    }
}
