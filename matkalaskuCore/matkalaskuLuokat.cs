using System;
using System.Collections;
using System.Collections.Generic;

namespace matkalaskuCore
{
    public class matkalaskuLuokat
    {
        // Kilometrikorvaus auton käytöstä(https://www.veronmaksajat.fi/Palkka-ja-elake/Kilometrikorvaukset/kilometrikorvaukset-2020/#3c29c31d)
        // Kilometrikorvauksesta tulisi nähdä sen erittely eli mistä kokonaiskorvaus muodostuu. 
        // -> (kilometrit, henkilöiden lkm., laskemiseen käytetty korvauksen määrä per kilometri)

        public double Kilometrikorvaus(List<double> matkustajienLukumäärä, List<double> välimatkaKm)
        {
            double kilometrikorvausPerKm = 0.43;
            double korvausMäärä = matkustajienLukumäärä[0] * välimatkaKm[0] * kilometrikorvausPerKm;
            return korvausMäärä;
        }

    }
}
