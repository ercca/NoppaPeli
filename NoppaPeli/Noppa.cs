using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
    class Noppa
    {
        //Muuttujat
        static Random rnd = new Random();

        //Ominaisuudet
        public int Lukema { get; set; }
        public int HeittoLkm { get; set; }

        //Konstruktorit
        public Noppa()
        {
            HeittoLkm = 0;
        }

        //Metodit
        public int Heita()
        {
            Lukema = rnd.Next(1, 6);
            HeittoLkm++;
            return Lukema;
        }
    }
}
