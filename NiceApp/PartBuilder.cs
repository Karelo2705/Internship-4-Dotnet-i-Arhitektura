using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Data.Entities;
using Data.Enums;
using NiceApp;
using Data;

namespace Presentation
{
    class PartBuilder
    {
        public static Components[] FinalBuilder()
        {

            var comps = new List<Components> { };
            var typeComp = Enum.GetValues(typeof(TypeOfComp)).Cast<TypeOfComp>();

            foreach (var item in typeComp)
            {
                var component = CompType(item);
                if (component != null)
                    comps.Add(component);
            }
            
            return comps.ToArray();

        }

        public static Components CompType(TypeOfComp Comp)
        {
            var comps = CompGet.GetByType(Comp);

            Console.Clear();
            Console.WriteLine($"Komponenta {Comp}:");
            ComponentsPrinter(comps);

            var randVar = Options(comps.Length);

            if (randVar == 0)
                return null;

            return comps[randVar - 1];
        }

        public static void ComponentsPrinter(Components[] comps)
        {
            var listAdd = new List<string>();
            Console.WriteLine("Pritisnite 0 za preskociti komponentu.");
            int i = 0;
            foreach (var item in comps.Select(comp => new { comp }))
            {
                i++;
                Console.WriteLine($"{i}.{item.comp.Data()}");
                listAdd.Add(item.comp.Data());
            }
            OrderAdd.Set(listAdd);
            
        }

        public static int Options(int num)
        {

            while (true)
            {
                Console.Write("Upišite numeričku vrijednost željenog proizvoda: ");

                var tryThis = int.TryParse(Console.ReadLine(), out int option);

                if (option >= 0 && tryThis && option <= num)
                {
                    return option;
                }

                Console.WriteLine("Neispravan input");

            }

        }
        
     
    }
        
}

