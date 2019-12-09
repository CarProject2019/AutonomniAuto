using System;
using System.Collections.Generic;
using System.Text;

namespace AutonomniRizeni
{
    public class Pocasi
    {
        //Prší 30-50
        //Mrholí 5-10
        //Mlha 10-30
        //Slunečno 50-100
        //Sněží 0-5
        public static TrasaStav GetPocasi(int Vygenerovano)
        {
            if (Vygenerovano >= 50) return TrasaStav.Slunecno;
            else if (Vygenerovano >= 30 && Vygenerovano < 50) return TrasaStav.Prsi;
            else if (Vygenerovano >= 10 && Vygenerovano < 30) return TrasaStav.Mlha;
            else if (Vygenerovano >= 5 && Vygenerovano < 10) return TrasaStav.Mrholi;
            else return TrasaStav.Snih;
        }
    }
}
