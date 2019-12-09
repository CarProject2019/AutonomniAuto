using System;
using System.Threading;
using System.IO;

namespace AutonomniRizeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nc = new Random();
            AutonomniAuto CyberTruck = new AutonomniAuto(50, 90, Pocasi.GetPocasi(nc.Next(0, 101)), DruhTrasy.GetTrasa(nc.Next(0, 101)));
            RidiciCentrum RC = new RidiciCentrum(CyberTruck);
            RC.ZjistiTrasu();
        }
    }

    public enum Svetla
    {
        Mlhova,
        Dalkova,
        Denni,
        Potkavaci
    }
}
