using System;
using System.Collections.Generic;
using fantasyDolgozat;

namespace fantasy_dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis adatbazis = new SzornyAdatbazis();
            List<szorny> szornyek = adatbazis.Feltolt();
            szornyelemzo elemzo = new szornyelemzo(szornyek);

            Console.WriteLine("Veszelyes szornyek szama: " + elemzo.veszelyesSzornyekSzama());

            Console.WriteLine("Gyenge szornyek neve:");
            foreach (var nev in elemzo.gyengeszornyekneve())
            {
                Console.WriteLine(nev);
            }

            Console.WriteLine("Legkisebb veszelyessegi szint: " + elemzo.LegkisebbVeszelyessegiSzint());

            Console.WriteLine("Nem veszelyes szornyek:");
            foreach (var szorny in elemzo.NemVeszelyesSzornyek())
            {
                Console.WriteLine(szorny.Nev);
            }

            Console.WriteLine("Van-e gyenge vizi szorny: " + elemzo.VanVizGyengeVeszelyesSzorny());

            Console.WriteLine("Szornyek szama zsákmányonkent:");
            foreach (var zsákmany in elemzo.SzornyekSzamaZsakmanyonkent())
            {
                Console.WriteLine(zsákmany);
            }

            Console.WriteLine("Legveszelyesebb elohelyek:");
            foreach (var elohely in elemzo.LegveszelyesebbElohelyek())
            {
                Console.WriteLine(elohely);
            }
        }
    }
}
