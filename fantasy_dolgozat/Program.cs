using System;
using System.Collections.Generic;
using System.Linq;
using fantasyDolgozat;

namespace fantasy_dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis adatbazis = new SzornyAdatbazis();
            List<szorny> szornyek = adatbazis.Feltolt();

            var szornyNevek = szornyek.Select(x => x.Nev).ToList();

            foreach (var nev in szornyNevek)
            {
                Console.WriteLine(nev);
            }
        }
    }
}
