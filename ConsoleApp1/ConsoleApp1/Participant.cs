using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class Participant
    {
        string personname;
        List<Team> members;

        public void setName(String s)
        {
            this.personname = s;
        }

        public string getName()
        {
            return personname;
        }

        public void printParticipant()
        {
            Console.WriteLine("A participant called " + personname);
        }
    }
}
