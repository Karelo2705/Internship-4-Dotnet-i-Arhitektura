using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class User
    {
        public String name { get; set; }
        public String surname { get; set; }

        public String adress { get; set; }

        public int Distance { get; set; }


        public User(String Name, String Surname, String Adress)
        {
            name = Name;
            surname = Surname;
            adress = Adress;
            Distance = DistanceGen();
        }
        public int DistanceGen()
        {
            var num = new Random();
            return (num.Next(50, 999));
        }
    }
}
