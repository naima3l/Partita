using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class Athlet
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Code { get; set; }

        public Athlet(string name, string surname, int age, int code)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Code = code;
        }
        public Athlet()
        {

        }
        
        
    }
}
