using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suoritetaan ohjelma vikasietoisesti
            try
            {
                WriteLine("Noppa-peli");
                Sovellus.Aja();
            }

            catch (Exception e)
            {
                WriteLine("Ohjelman suoritus päättyi virheeseen.");
                WriteLine($"Virhe: {e.Message}");
            }

            finally
            {
                WriteLine("Paina Enter lopettaaksesi...");
                ReadLine();
            }
        }
    }
}
