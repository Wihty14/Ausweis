using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweiß
{
    internal class Personalausweiß:Ausweiß
    {
       public Fingerabdruck fingerabdruck { get; set; }

        public Personalausweiß(Fingerabdruck fingerabdruck, Inhaber inhaber, int ausweißnummer, int ablaufdatum) : base(inhaber,ausweißnummer,ablaufdatum)
        {
            this.fingerabdruck = fingerabdruck;
        }
    }
}
