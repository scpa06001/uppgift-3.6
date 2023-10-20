using System;
namespace Uppgift_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt förnamn och efternamn.");
            string helanamn = Console.ReadLine();
            int mellanslagIndex = helanamn.IndexOf(" ");
            string förnamn = helanamn[..mellanslagIndex];
            string efternamn = helanamn[(mellanslagIndex + 1)..];

            if (förnamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine("Ditt förnamn kommer före ditt efternamn i bokstavsordningen");
            }
            else if (förnamn.CompareTo(efternamn) > 0)
            {
                Console.WriteLine("Ditt förnamn kommer efter ditt efternamn i bokstavsordningen");
            }
            else if (förnamn.CompareTo(efternamn) == 0)
            {
                Console.WriteLine("Dina namn är på samma plats i bokstavsordnigen");
            }
                Console.ReadKey();

        }
    }
}
