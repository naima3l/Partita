using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class Midfielder : SoccerPlayer
    {
        public int Assists { get; set; }
        public Midfielder(string name, string surname, int age, int code, string role, int num, int assists)
            : base(name, surname, age,code, role, num)
        {
            Assists = assists;
        }
    }
}
