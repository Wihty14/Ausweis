using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweiß
{
    internal class Inhaber
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Wohnort { get; set; }

        public string Augenfarber { get; set; }
        public int Koerpergroeße { get; set; }
        public int Geburtsdatum { get; set; }

        public Inhaber(string vorname, string nachname, string wohnort, string augenfarber, int koerpergroeße, int geburtsdatum)
        {
            Vorname = vorname;
            Nachname = nachname;
            Wohnort = wohnort;
            Augenfarber = augenfarber;
            Koerpergroeße = koerpergroeße;
            Geburtsdatum = geburtsdatum;
        }
    }
}
