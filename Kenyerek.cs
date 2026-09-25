using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekaru
{
    internal class Kenyerek : Pekaruk
    {
       
    
        public int Súly { get; set; }

        public Kenyerek(string nev, double alapAr, bool akcios, int súly) : base(nev, false, alapAr, akcios)
        {
            Súly = súly;
        }

        public override string ToString()
        {
            string akciosSzoveg = Akcios ? "Akciós" : "Nem akciós";

            return $"Pékáru neve: {Nev}, {akciosSzoveg}, " +
                   $"Alapár: {AlapAr} Ft/db, Ár: {Ar()} Ft/db, Súly: {Súly} g";
        }
    }
}
