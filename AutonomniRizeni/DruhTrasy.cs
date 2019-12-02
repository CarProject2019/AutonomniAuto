using System;
using System.Collections.Generic;
using System.Text;

namespace AutonomniRizeni
{
    public class DruhTrasy
    {
        // public enum TrasaDruh {Tunel, Most, Common}
        public static TrasaDruh GetTrasa(int Vygenerovano)
        {
            if (Vygenerovano >= 50) return TrasaDruh.Common;
            else if (Vygenerovano >= 25 && Vygenerovano < 50) return TrasaDruh.Most;
            else return TrasaDruh.Tunel;
        }
    }
}
