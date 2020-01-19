using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
    static class Sovellus
    {
        //Muuttujat
        static int VOITONPISTERAJA = 3;

        //Metodit
        public static void Aja()
        {
            //Pelaaja -oliot
            Pelaaja p1 = new Pelaaja(Helpers.Syote.Merkkijono("Pelaajan 1 nimi:"));
            Pelaaja p2 = new Pelaaja(Helpers.Syote.Merkkijono("Pelaajan 2 nimi:"));
            //Noppa -oliot
            Noppa n1 = new Noppa();
            Noppa n2 = new Noppa();

            while (true)
            {
                //Heittokierroksen määräytyminen HeittoLkm:n avulla
                if (n1.HeittoLkm == 0)
                {
                    WriteLine($"Heittokierros 1");
                }

                else if (n1.HeittoLkm != 0)
                {
                    WriteLine($"Heittokierros {(n1.HeittoLkm / 2) + 1}");
                }

                //Noppien heittely
                WriteLine($"{p1.Nimi}: {n1.Heita()} + {n2.Heita()} = {n1.Lukema + n2.Lukema}");
                int p1p = n1.Lukema + n2.Lukema; //Muuttujaan tallennettu yhteenlaskettu tulos

                WriteLine($"{p2.Nimi}: {n1.Heita()} + {n2.Heita()} = {n1.Lukema + n2.Lukema}");
                int p2p = n1.Lukema + n2.Lukema; //Muuttujaan tallennettu yhteenlaskettu tulos

                //Yhteenlaskettujen silmälukujen vertailu
                if(p1p > p2p)
                {
                    p1.Pisteet++;
                    p2.Pisteet = 0;
                }

                else if(p2p > p1p)
                {
                    p2.Pisteet++;
                    p1.Pisteet = 0;
                }

                //Jos jommankumman pelaajan pisteet saavuttavat voittoon tarvittavan määrän,
                //looppi katkeaa
                if(p1.Pisteet == VOITONPISTERAJA)
                {
                    WriteLine();
                    WriteLine($"Pelin voittaja on {p1.Nimi} ja noppia heitettiin {n1.HeittoLkm / 2} kertaa!");
                    WriteLine();
                    break;
                }

                else if(p2.Pisteet == VOITONPISTERAJA)
                {
                    WriteLine();
                    WriteLine($"Pelin voittaja on {p2.Nimi} ja noppia heitettiin {n1.HeittoLkm / 2} kertaa!");
                    WriteLine();
                    break;
                }
            }
        }
    }
}
