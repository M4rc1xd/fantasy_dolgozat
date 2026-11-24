using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_dolgozat
{
    internal class szorny
    {
        private int id;
        private string nev;
        private int veszelyessegiSzint;
        private string elohely;
        private string foGyengeseg;
        private string leggyakoribbZsakmany;
        private bool veszelyesE;

        public szorny(int id, string nev, int veszelyessegiSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.Id = id;
            this.Nev = nev;
            this.VeszelyessegiSzint = veszelyessegiSzint;
            this.Elohely = elohely;
            this.FoGyengeseg = foGyengeseg;
            this.LeggyakoribbZsakmany = leggyakoribbZsakmany;
            this.VeszelyesE = veszelyesE;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int VeszelyessegiSzint { get => veszelyessegiSzint; set => veszelyessegiSzint = value; }
        public string Elohely { get => elohely; set => elohely = value; }
        public string FoGyengeseg { get => foGyengeseg; set => foGyengeseg = value; }
        public string LeggyakoribbZsakmany { get => leggyakoribbZsakmany; set => leggyakoribbZsakmany = value; }
        public bool VeszelyesE { get => veszelyesE; set => veszelyesE = value; }
    }
}
