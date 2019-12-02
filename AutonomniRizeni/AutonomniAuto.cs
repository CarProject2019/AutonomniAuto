using System;
using System.Collections.Generic;
using System.Text;

namespace AutonomniRizeni
{
    public enum TrasaStav {Prsi, Mrholi, Mlha, Snih, Slunecno}
    public enum TrasaDruh {Tunel, Most, Common}
    public class AutonomniAuto
    {
        public double Rychlost { get; set; }
        public double DelkaTrasy { get; set; }
        public bool Sviti { get; set; } = false;
        public TrasaStav trasaStav;
        public TrasaDruh trasaDruh;
        public AutonomniAuto(double Rychlost, double DelkaTrasy, TrasaStav trasaStav, TrasaDruh trasaDruh)
        {
            this.Rychlost = Rychlost;
            this.DelkaTrasy = DelkaTrasy;
            this.trasaDruh = trasaDruh;
            this.trasaStav = trasaStav;
        }
    }
}
