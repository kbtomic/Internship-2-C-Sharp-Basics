using System;
using System.Collections.Generic;

namespace Music_Playlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var playlist = new Dictionary<int, string>()
            {
                { 1, "Ja te srecom castim" },
                { 2, "Dobro da nije vece zlo" },
                { 3, "Miris karmina" }
            };
            var choice = 0;
            do
            {
                Console.WriteLine("Odaberite akciju: ");
                Console.WriteLine("1 - ispis cijele liste");
                Console.WriteLine("2 - ispis imena pjesme unosom pripadajuceg rednog broja");
                Console.WriteLine("3 - ispis rednog broja pjesme unosom pripadajuceg imena");
                Console.WriteLine("4 - unos nove pjesme");
                Console.WriteLine("5 - brisanje pjesme po rednom broju");
                Console.WriteLine("6 - brisanje pjesme po imenu");
                Console.WriteLine("7 - brisanje cijele liste");
                Console.WriteLine("8 - uredivanje imena pjesme");
                Console.WriteLine("9 - uredivanje rednog broja pjesme");
                Console.WriteLine("0 - izlaz iz aplikacije");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Nepostojeci unos! Pokusaj ponovno!");
                        break;

                }
            } while (choice != 0);
        }
    }
}
