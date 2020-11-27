using System;
using System.Collections.Generic;
using System.Linq;

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

            MainMenu(playlist);          
        }
        static void IspisListe(Dictionary<int,string> playlist)
        {
            foreach(var pair in playlist)
            {
                Console.WriteLine("Redni broj pjesme: " + pair.Key + " Ime pjesme: " + pair.Value);
            }
        }
        static void IspisBrojem(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi redni broj pjesme cije ime zelis saznati: ");
            var redniBroj = int.Parse(Console.ReadLine());
            if(playlist.ContainsKey(redniBroj))
                Console.WriteLine(playlist[redniBroj]);
            else
                Console.WriteLine("Ne postoji pjesma pod tim rednim brojem!");
        }
        static void IspisImenom(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi ime pjesme ciji redni broj zelis saznati: ");
            var imePjesme = Console.ReadLine();
            if(playlist.ContainsValue(imePjesme))
            {
                foreach (var name in playlist)
                {
                    if (imePjesme == name.Value)
                        Console.WriteLine("Pjesma pod imenom: " + imePjesme + " je pod rednim brojem: " + name.Key);
                }
            }
            else
                Console.WriteLine("Ne postoji pjesma pod tim imenom!");
        }
        static void UnosPjesme(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi ime pjesme koju zelis dodati u playlistu: ");
            var imeNovePjesme = Console.ReadLine();
            var redniBrojNovePjesme = playlist.Count + 1;

            if (playlist.ContainsValue(imeNovePjesme)) 
                    Console.WriteLine("Vec postoji pjesma pod tim nazivom!");
            else
            {
                Console.WriteLine("Ako si siguran da zelis dodati pjesmu: " + imeNovePjesme + " onda upisi DA");
                var potvrda = Console.ReadLine();
                if(potvrda == "DA")
                    playlist.Add(redniBrojNovePjesme, imeNovePjesme);
            }
        }
        static void MainMenu(Dictionary<int, string> playlist)
        {
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
                        IspisListe(playlist);
                        break;
                    case 2:
                        IspisBrojem(playlist);
                        break;
                    case 3:
                        IspisImenom(playlist);
                        break;
                    case 4:
                        UnosPjesme(playlist);
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
