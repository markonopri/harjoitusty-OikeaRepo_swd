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

        // Kilometrikorvauslaskuri
        public double Kilometrikorvaus(List<double> matkustajienLukumäärä, List<double> välimatkaKm)
        {
            double kilometrikorvausPerKm = 0.43;
            double korvausMäärä = matkustajienLukumäärä[0] * välimatkaKm[0] * kilometrikorvausPerKm;
            return korvausMäärä;
        }
        
        // Päivärahakorvaus laskuri
        public int PäivärahaKorvaus(List<int> aika, List<int> km)
        {
            int kilometrit = km[0];
            int minuutit = aika[0];
            int päivät = 0;
            int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
            int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;
            int kokoPäiväRahaHinta = 43;
            int osaPäiväRahaHinta = 20;
            int korvauksetYhteensä = 0;

            if (kilometrit > 15)
            {
                while (true)
                {
                    if (minuutit > 1440)
                    {
                        päivät++;
                        minuutit -= 1440;
                    }
                    else if (minuutit > 360)
                    {
                        yliYksiPäiväJaKuusiTuntiaKorvaus += 1;
                        break;
                    }
                    else if (minuutit > 120)
                    {
                        yliYksiPäiväJaKaksiTuntiaKorvaus += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (päivät > 0 && yliYksiPäiväJaKuusiTuntiaKorvaus > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET:");
                Console.WriteLine("");
                Console.WriteLine("Kokopäivärahakorvauksia: " + päivät + " kpl");
                Console.WriteLine("Yksikköhinta " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (päivät * kokoPäiväRahaHinta) + " euroa");
                Console.WriteLine("Osapäivärahakorvauksia " + yliYksiPäiväJaKuusiTuntiaKorvaus + " kpl");
                Console.WriteLine("Yksikköhinta " + osaPäiväRahaHinta + " euroa");
                Console.WriteLine("Osapäivärahojen kokonaishinta: " + (yliYksiPäiväJaKuusiTuntiaKorvaus * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = ((päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKuusiTuntiaKorvaus * kokoPäiväRahaHinta));
            }
            else if (päivät > 0 && yliYksiPäiväJaKaksiTuntiaKorvaus > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET:");
                Console.WriteLine("");
                Console.WriteLine("Kokopäivärahakorvauksia: " + päivät + " kpl");
                Console.WriteLine("Yksikköhinta " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (päivät * kokoPäiväRahaHinta) + " euroa");
                Console.WriteLine("Osapäivärahakorvauksia " + yliYksiPäiväJaKaksiTuntiaKorvaus + " kpl");
                Console.WriteLine("Yksikköhinta " + osaPäiväRahaHinta + " euroa");
                Console.WriteLine("Osapäivärahojen kokonaishinta: " + (yliYksiPäiväJaKaksiTuntiaKorvaus * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = ((päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKaksiTuntiaKorvaus * kokoPäiväRahaHinta));

            }
            else if (päivät > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET:");
                Console.WriteLine("");
                Console.WriteLine("Kokopäivärahakorvauksia: " + päivät + " kpl");
                Console.WriteLine("Yksikköhinta " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (päivät * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = (päivät * kokoPäiväRahaHinta);
            }

            return korvauksetYhteensä;

        }
        
    }
}
