using System.Collections.Generic;
using System.Linq;

namespace fantasy_dolgozat
{
    class szornyelemzo
    {
        private List<szorny> szornyek;

        public szornyelemzo(List<szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int veszelyesSzornyekSzama()
        {
            return szornyek.Count(x => x.VeszelyesE);
        }

        public IEnumerable<string> gyengeszornyekneve()
        {
            return szornyek
                .Where(x => x.VeszelyessegiSzint < 4)
                .Select(x => x.Nev);
        }

        public int LegkisebbVeszelyessegiSzint()
        {
            return szornyek.Min(x => x.VeszelyessegiSzint);
        }

        public IEnumerable<Szorny> NemVeszelyesSzornyek()
        {
            return szornyek.Where(x => !x.VeszelyesE).sortBy(x => x.Nev);
        }

        public bool VanVizGyengeVeszelyesSzorny()
        {
            return szornyek.Any(x => x.Elohely.ToLower().Contains("víz") && x.VeszelyessegiSzint < 4);
        }

        public IEnumerable<string> SzornyekSzamaZsakmanyonkent()
        {
            return szornyek
                .GroupBy(x => x.LeggyakoribbZsakmany)
                .Select(g => $"{g.Key}: {g.Count()}");
        }

        public IEnumerable<string> LegveszelyesebbElohelyek()
        {
            return szornyek
                .Where(x => x.VeszelyessegiSzint >= 7)
                .Select(x => x.Elohely)
                .Distinct();
        }
    }
}
