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
    }
}
