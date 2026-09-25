using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekaru
{
    public class Pekaruk
    {
        public string Nev { get; set; }
        public bool Edes { get; set; }
        public double AlapAr { get; set; }
        public bool Akcios { get; set; }

      
        public Pekaruk(string nev, bool edes, double alapAr, bool akcios)
        {
            Nev = nev;
            Edes = edes;
            AlapAr = alapAr;
            Akcios = akcios;
        }

       
        public double Ar()
        {
            if (Akcios)
            {
                return AlapAr / 2;
            }

            return AlapAr;
        }

        public override string ToString()
        {
            string akciosSzoveg = Akcios ? "Akciós" : "Nem akciós";
            string edesSzoveg = Edes ? "Édes" : "Sós";

            return $"Pékáru neve: {Nev}, {akciosSzoveg}, {edesSzoveg}, " +
                   $"Alapár: {AlapAr} Ft/db, Ár: {Ar()} Ft/db";
        }
    }


   
}
