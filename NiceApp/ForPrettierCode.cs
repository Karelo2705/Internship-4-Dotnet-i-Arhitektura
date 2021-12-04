using System;
using System.Threading.Tasks;
using Domain;


namespace NiceApp
{
    public class ForPrettierCode
    {
        public static string Menu()
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


        }
        private static void Delay()
        {
            Task.Delay(2000).Wait();
        }
    }
}
