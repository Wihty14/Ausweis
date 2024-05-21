using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweiß
{
    internal class Ausweiß
    {
        public Inhaber Inhaber { get; set; }
        public int ausweißnummer { get; set; }
        public int Ablaufdatum { get; set; }

        public Ausweiß(Inhaber inhaber, int ausweißnummer, int ablaufdatum)
        {
            Inhaber = inhaber;
            this.ausweißnummer = ausweißnummer;
            Ablaufdatum = ablaufdatum;
        }
    }
}
