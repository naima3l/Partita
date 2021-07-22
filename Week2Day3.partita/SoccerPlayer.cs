using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class SoccerPlayer : Athlet
    {
        public string Role { get; set; }
        public int Num { get; set; }
        public SoccerPlayer(string name, string surname, int age, int code, string role, int num)
            : base(name, surname, age, code)
        {
            Role = role;
            Num = num;
        }

        public SoccerPlayer()
        {

        }


    }
}
