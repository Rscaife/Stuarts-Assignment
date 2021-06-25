using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class Event
    {
        string eventname;
        List<string> types = new List<string>();
        string type;
        Dictionary<Team, int> placing = new Dictionary<Team, int>();

        public void allocatePlace(Team t, int i)
        {
            placing.Add(t, i);
        }

        public int getPoints(Team t)
        {
            int postition = placing[t];
            switch (position)
            {
                case 1:
                    return 10;
                    break;
            }
            return 0;
        }

        public Event()
        {
            types.Add("academic");
            types.Add("sporting");
        }
        public void setName(String e)
        {
            this.eventname = e;
        }

        public void setType(String s)
        {
            if(type.Contains(s))
            {
                type = s;
            } else
            {
                Console.WriteLine("this is not valid type");
            }
        }

        public void printEvent()
        {
            Console.WriteLine("A" + type + "An event called " + eventname);
        }

        public string getName()
        {
            return eventname;
        }
    }
}
