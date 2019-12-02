using System;
using System.Collections.Generic;
using System.Text;

namespace AutonomniRizeni
{
    public class RidiciCentrum : AutonomniAuto
    {
        public event DruhTrasy Trasa;
        public delegate void DruhTrasy(AutonomniAuto a);

        public void ZjistiTrasu()
        {
            if (trasaDruh == TrasaDruh.Tunel)
            {
                Rychlost += Rychlost/2;
                Sviti = true;
            }
            else if (trasaDruh == TrasaDruh.Most)
            {
                Rychlost += Rychlost / 2;
                Sviti = false;
            }
            else
            {
                Rychlost = Rychlost;
                Sviti = false;
            }
        }
        public RidiciCentrum(AutonomniAuto elon) : base (elon.Rychlost, elon.DelkaTrasy, elon.trasaStav, elon.trasaDruh){}
    }
}
