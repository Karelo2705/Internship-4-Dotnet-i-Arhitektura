using System;
using System.Threading.Tasks;
using Domain;


namespace NiceApp
{
    public class ForPrettierCode
    {
        public static void InitDiag()
        {
            Console.WriteLine("||||||||||||||||||||");
            Console.WriteLine("Little hardware shop");
            Console.WriteLine("||||||||||||||||||||\n");
            Delay();
            Console.WriteLine("Za pristup sustavu prvo se trebate prijaviti.");
            Delay();
            Console.WriteLine("Unesite svoje ime (samo ime, bez prezimena): ");
            var name = Console.ReadLine();
            Console.WriteLine("Unesite svoje prezime: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Unesite adresu ulice u koju želite da paket bude dostavljen: ");
            var adress = Console.ReadLine();


            var newUser = new User(name, surname, adress);
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

        private static void Delay()
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

                while(!int.TryParse(Console.ReadLine(), out options))
                    Console.WriteLine("Nevažeći input.");

                switch (options)
                {
                    case 1:
                        ChooseComponents.TypeChoose();
                        break;
                    case 3:
                        imABool = false;
                        break;

                }
            }
        }
    }
}
