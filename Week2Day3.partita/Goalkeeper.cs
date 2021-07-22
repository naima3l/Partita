using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class Goalkeeper : SoccerPlayer
    {
        public int GoalsTaken { get; set; }
       
        public Goalkeeper(string name, string surname, int age, int code, string role, int num, int goalsTaken)
            : base(name, surname, age,code, role, num)
        {
            GoalsTaken = goalsTaken;
        }

    }
}
