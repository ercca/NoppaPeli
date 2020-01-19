using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
    class Pelaaja : INimi
    {
        //Ominaisuudet
        public string Nimi { get; set; }
        public int Pisteet { get; set; }

        //Konstruktorit
        public Pelaaja(string nimi)
        {
            Nimi = nimi;
            Pisteet = 0;
        }
    }
}
