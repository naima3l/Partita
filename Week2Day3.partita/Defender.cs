using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class Defender : SoccerPlayer
    {
        public int GoalsSaved { get; set; }

        
        public Defender(string name, string surname, int age, int code, string role, int num, int goalsSaved)
            : base(name, surname, age, code, role, num)
        {
            GoalsSaved = goalsSaved;
        }

        public Defender()
        {

        }
    }
}
