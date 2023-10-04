using System;
namespace Uppgift3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Skriv in ett annat ord:");
            string word2 = Console.ReadLine();

            Console.WriteLine("Skriv in ytterligare ett ord:");
            string word3 = Console.ReadLine();

            //Ord ett eller ord två kommer först?
            string first = word1.CompareTo(word2) < 0 ? word1 : word2;

            //Jämför det tidigare första med ord tre
            first = first.CompareTo(word3) < 0 ? first : word3;

            if (word1 == word2 && word1 == word3) //samma ord
            {
                Console.WriteLine("Du har skrivit samma ord tre gånger.");
            }
            else //inte samma ord
            {
                Console.WriteLine($"{first} kommer först i bokstavsordning.");
            }


        }
    }
}