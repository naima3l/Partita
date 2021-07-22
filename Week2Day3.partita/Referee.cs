using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class Referee : Athlet
    {
        public int YearsOfService { get; set; }
        public Referee(string name, string surname, int age, int code, int yearsOfService)
            : base(name, surname, age, code)
        {
            YearsOfService = yearsOfService;
        }
    }
}
