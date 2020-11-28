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
        static void BrisiRednimBrojem(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi redni broj pjesme koju zelis izbrisati iz playliste: ");
            var redniBrojBrisanePjesme = int.Parse(Console.ReadLine());
            if(playlist.ContainsKey(redniBrojBrisanePjesme))
            {
                    Console.WriteLine("Ako si siguran da zelis izbrisati pjesmu: " + playlist[redniBrojBrisanePjesme] + " onda upisi DA");
                    var potvrda = Console.ReadLine();
                    if (potvrda == "DA")
                    {
                        for (var i = redniBrojBrisanePjesme; i < playlist.Count; i++) {
                            playlist[i] = playlist[i + 1];
                        }
                        playlist.Remove(playlist.Count);
                    }
            }
            else
                Console.WriteLine("Ne postoji pjesma pod tim rednim brojem!");
        }
        static void BrisiImenom(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi ime pjesme koju zelis izbrisati iz playliste: ");
            var imeBrisanePjesme = Console.ReadLine();
            if (playlist.ContainsValue(imeBrisanePjesme))
            {
                Console.WriteLine("Ako si siguran da zelis izbrisati pjesmu: " + imeBrisanePjesme + " onda upisi DA");
                var potvrda = Console.ReadLine();
                if (potvrda == "DA")
                {
                    var redniBrojBrisanePjesme = 0;
                    foreach (var name in playlist)
                    { 
                        if (imeBrisanePjesme == name.Value)
                             redniBrojBrisanePjesme = name.Key;
                    }
                    for(var i = redniBrojBrisanePjesme; i < playlist.Count; i++)
                    {
                        playlist[i] = playlist[i + 1];
                    }
                    playlist.Remove(playlist.Count);
                }
            }
            else
                Console.WriteLine("Ne postoji pjesma pod tim imenom!");
        }
        static void UrediImePjesme(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi redni broj pjesme cije ime zelis urediti: ");
            var redniBroj = int.Parse(Console.ReadLine());
            if(playlist.ContainsKey(redniBroj))
            {
                Console.WriteLine("Unesi zeljeno novo ime pjesme: " + playlist[redniBroj]);
                var novoImePjesme = Console.ReadLine();
                Console.WriteLine("Ako si siguran da zelis promijeniti ime pjesme: " + playlist[redniBroj] + " onda upisi DA");
                var potvrda = Console.ReadLine();
                if (potvrda == "DA")
                    playlist[redniBroj] = novoImePjesme;
            }
            else
                Console.WriteLine("Ne postoji pjesma pod tim rednim brojem!");
        }
        static void UrediRedniBrojPjesme(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Unesi redni broj pjesme ciji redni broj zelis urediti: ");
            var stariRedniBroj = int.Parse(Console.ReadLine());
            if (playlist.ContainsKey(stariRedniBroj))
            {
                Console.WriteLine("Unesi redni broj pozicije na koju zelis premjestiti pjesmu: ");
                var noviRedniBroj = int.Parse(Console.ReadLine());
                if (playlist.ContainsKey(noviRedniBroj))
                {
                    if (stariRedniBroj != noviRedniBroj)
                    {
                        Console.WriteLine("Ako si siguran da zelis premjestiti pjesmu: " + playlist[stariRedniBroj] + " na redni broj pjesme: " + playlist[noviRedniBroj] + " onda upisi DA");
                        var potvrda = Console.ReadLine();
                        if (potvrda == "DA")
                        {
                            var imePjesme = playlist[stariRedniBroj];
                            if (noviRedniBroj < stariRedniBroj)
                            {

                                for (int i = stariRedniBroj; i > noviRedniBroj; i--)
                                {
                                    playlist[i] = playlist[i - 1];
                                }
                                playlist[noviRedniBroj] = imePjesme;

                            }
                            else
                            {
                                for (int i = stariRedniBroj; i < noviRedniBroj; i++)
                                {
                                    playlist[i] = playlist[i + 1];
                                }
                                playlist[noviRedniBroj] = imePjesme;
                            }
                        }
                    }
                    else
                        Console.WriteLine("Pokusavas premjestiti pjesmu na mjesto na kojem se vec nalazi!");
                }
                else
                    Console.WriteLine("Ne postoji ta pozicija u listi!");
            }
            else
                Console.WriteLine("Ne postoji pjesma pod tim rednim brojem!");
        }
        static void BrisiPlaylistu(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Ako si siguran da zelis izbrisati cijelu playlistu onda upisi DA");
            var potvrda = Console.ReadLine();
            if (potvrda == "DA")
                playlist.Clear();
        }
        static void Shuffle(Dictionary<int, string> playlist)
        {
            Console.WriteLine("Ako si siguran da zelis shuffleati cijelu playlistu onda upisi DA");
            var potvrda = Console.ReadLine();
            if (potvrda == "DA")
            {
                var random = new Random();
                for (int i = 1; i <= playlist.Count; i++)
                {
                    var randomRedniBroj = random.Next(1, playlist.Count);
                    var imeTrenutnePjesme = playlist[i];
                    playlist[i] = playlist[randomRedniBroj];
                    playlist[randomRedniBroj] = imeTrenutnePjesme;
                }
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
                Console.WriteLine("10 - shuffle pjesama");

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
                        BrisiRednimBrojem(playlist);
                        break;
                    case 6:
                        BrisiImenom(playlist);
                        break;
                    case 7:
                        BrisiPlaylistu(playlist);
                        break;
                    case 8:
                        UrediImePjesme(playlist);
                        break;
                    case 9:
                        UrediRedniBrojPjesme(playlist);
                        break;
                    case 10:
                        Shuffle(playlist);
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
