using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankszamla_FR
{
    public abstract class Bankszamla
    {
        public string Szamlaszam { get; set; }
        public string Tulajdonos { get; set; }
        public decimal Egyenleg { get; protected set; } = 0m;

        public Bankszamla(string szamlaszam, string tulajdonos)
        {
            Szamlaszam = szamlaszam;
            Tulajdonos = tulajdonos;
        }

        public Bankszamla(string szamlaszam, string tulajdonos, decimal kezdoOsszeg) : this(szamlaszam, tulajdonos)
        {
            Befizetes(kezdoOsszeg);
        }

        public void Befizetes(decimal osszeg)
        {
            if (osszeg < 0)
                throw new ArgumentException("Negatív összeg nem fizethető be!");

            Egyenleg += osszeg;
        }

        public abstract void Kifizetes(decimal osszeg);
    }
}