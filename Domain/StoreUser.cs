using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    
        public class StoreUser
        {
            public static string name { get => User.name; }
            public static string surname { get => User.surname; }
            public static string address { get => User.adress; }
            public static int Distance { get => User.Distance; }

            public static void Set(string name, string surname, string address)
            {
                User.name = name;
                User.surname = surname;
                User.adress = address;

                var r = new Random();
                User.Distance = r.Next(50, 999);
            }
        
    }
}
