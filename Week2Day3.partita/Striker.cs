using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class Striker : SoccerPlayer
    {
        public int GoalsScored { get; set; }
        public Striker(string name, string surname, int age, int code, string role, int num, int goalsScored)
            : base(name, surname, age,code, role, num)
        {
            GoalsScored = goalsScored;
        }

    }
}
