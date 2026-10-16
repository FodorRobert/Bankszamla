using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankszamla_FR
{
    public class FolyoSzamla : Bankszamla
    {
        public decimal Hitelkeret { get; set; } = 10000m;

        public FolyoSzamla(string szamlaszam, string tulajdonos) : base(szamlaszam, tulajdonos)
        {
        }

        public FolyoSzamla(string szamlaszam, string tulajdonos, decimal kezdoOsszeg) : base(szamlaszam, tulajdonos, kezdoOsszeg)
        {
        }

        public override void Kifizetes(decimal osszeg)
        {
            if (osszeg < 0)
                throw new ArgumentException("A kifizetés összege nem lehet negatív!");

            if (Egyenleg - osszeg < -Hitelkeret)
                return;

            Egyenleg -= osszeg;
        }
    }
}
