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

        public Event()
        {
            types.Add("academic");
            types.Add("sporting");
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
    }
}
