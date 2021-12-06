using Data;
using Data.Entities;
using Domain;
using Presentation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NiceApp
{
    public class ForPrettierCode
    {
        public static void InitDiag()
        {
            Console.WriteLine("||||||||||||||||||||");
            Console.WriteLine("Little hardware shop");
            Console.WriteLine("||||||||||||||||||||\n");
            Console.WriteLine("Za pristup sustavu prvo se trebate prijaviti.");

            Console.WriteLine("Unesite svoje ime (samo ime, bez prezimena): ");
            var name = Console.ReadLine();
            CheckIfNum(name);

            Console.WriteLine("Unesite svoje prezime: ");
            var surname = Console.ReadLine();
            CheckIfNum(surname);

            Console.WriteLine("Unesite adresu ulice u koju želite da paket bude dostavljen: ");
            var adress = Console.ReadLine();


            StoreUser.Set(name, surname, adress);
            Console.Clear();

        }
        private static string Menu()
        {
            return
                "Prijava uspjesna!\n" +
                "Koju uslugu želite izabrati\n" +
                "1 - Sastavi i naruci novo racunalo\n" +
                "2 - Prikazi moje narudzbe\n" +
                "3 - Odjava\n";

        }

        public static void Delay()
        {
            Task.Delay(2000).Wait();
        }

        public static void OpenMenu()
        {
            var imABool = true;
            int options;
            while (imABool)
            {
                Console.WriteLine(Menu());

                while (!int.TryParse(Console.ReadLine(), out options))
                    Console.WriteLine("Nevažeći input.");

                switch (options)
                {
                    case 1:
                        var components = PartBuilder.FinalBuilder();
                        Console.Clear();
                        Console.WriteLine("Vaša konfiguracija:");
                        PartBuilder.ComponentsPrinter(components);
                        Console.WriteLine("pritisnite bilo koju tipku za nastavak.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        SecondMenu();
                        break;

                    case 3:
                        imABool = false;
                        break;

                    default:
                        Console.Clear();
                        break;


                }
            }
        }


        public static string CheckIfNum(string name)
        {
            bool canConvert = int.TryParse(name, out int num);
            while (canConvert)
            {

                Console.WriteLine("Ime ili prezime nemože biti broj!");
                name = Console.ReadLine();
                canConvert = int.TryParse(name, out num);

            }
            return name;

        }
        public static void SecondMenu()
        {
            var listItems = OrderAdd.OrderIds;
            var newList = new List<string>();
            Console.WriteLine("Vaša narudžba:");
            foreach (var item in listItems)
            {
                newList.Add(item);
            }
            foreach(var item in newList)
            {
                Console.WriteLine(item); 
            }
            Delay();
            Console.Clear ();
        }
    }
}
