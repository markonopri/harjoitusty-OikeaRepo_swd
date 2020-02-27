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
        // Kilometrikorvauslaskuri
        public double Kilometrikorvaus(double matkustajienLukumäärä, double välimatkaKm)
        {
            double kilometrikorvausPerKm = 0.43;
            double korvausMäärä = matkustajienLukumäärä * välimatkaKm * kilometrikorvausPerKm;
            return korvausMäärä;
        }

        // Päivärahakorvauslaskuri
        public int Päivärahakorvaus(int aika, int km)
        {
            int kilometrit = km;
            int minuutit = aika;
            int päivät = 0;
            int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
            int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;
            int yliKymmenenTuntiaKorvaus = 0;
            int yliKuusiTuntiaKorvaus = 0;
            int kokoPäiväRahaHinta = 43;
            int osaPäiväRahaHinta = 20;
            int korvauksetYhteensä = 0;

            // Päivärahakorvauslaskin, jos päivät yli 1
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
                    }
                    else if (minuutit > 120)
                    {
                        yliYksiPäiväJaKaksiTuntiaKorvaus += 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Päivärahakorvauslaskin, jos päivät alle 0
            if (kilometrit > 15 && päivät < 0)
            {
                while (true)
                {
                    if (minuutit > 600)
                    {
                        yliKymmenenTuntiaKorvaus += 1;
                        break;
                    }
                    else if (minuutit > 360)
                    {
                        yliKuusiTuntiaKorvaus += 1;
                        break;
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
                Console.WriteLine("Yksikköhinta: " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (päivät * kokoPäiväRahaHinta) + " euroa");
                Console.WriteLine("Osapäivärahakorvauksia: " + yliYksiPäiväJaKuusiTuntiaKorvaus + " kpl");
                Console.WriteLine("Yksikköhinta: " + osaPäiväRahaHinta + " euroa");
                Console.WriteLine("Osapäivärahojen kokonaishinta: " + (yliYksiPäiväJaKuusiTuntiaKorvaus * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = ((päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKuusiTuntiaKorvaus * kokoPäiväRahaHinta));
            }
            else if (päivät > 0 && yliYksiPäiväJaKaksiTuntiaKorvaus > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET:");
                Console.WriteLine("");
                Console.WriteLine("Kokopäivärahakorvauksia: " + päivät + " kpl");
                Console.WriteLine("Yksikköhinta: " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (päivät * kokoPäiväRahaHinta) + " euroa");
                Console.WriteLine("Osapäivärahakorvauksia: " + yliYksiPäiväJaKaksiTuntiaKorvaus + " kpl");
                Console.WriteLine("Yksikköhinta: " + osaPäiväRahaHinta + " euroa");
                Console.WriteLine("Osapäivärahojen kokonaishinta: " + (yliYksiPäiväJaKaksiTuntiaKorvaus * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = ((päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKaksiTuntiaKorvaus * osaPäiväRahaHinta));
            }
            else if (päivät > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET");
                Console.WriteLine("");
                Console.WriteLine("Kokopäivärahakorvauksia: " + päivät + " kpl");
                Console.WriteLine("Yksikköhinta: " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (päivät * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = (päivät * kokoPäiväRahaHinta);
            }
            else if (päivät < 0 && yliKymmenenTuntiaKorvaus > 1)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET");
                Console.WriteLine("");
                Console.WriteLine("Kokopäivärahakorvauksia: " + yliKymmenenTuntiaKorvaus + " kpl");
                Console.WriteLine("Yksikköhinta: " + kokoPäiväRahaHinta + " euroa");
                Console.WriteLine("Kokopäivärahojen kokonaishinta: " + (yliKymmenenTuntiaKorvaus * kokoPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = (yliKymmenenTuntiaKorvaus * kokoPäiväRahaHinta);
            }
            else if (päivät < 0 && yliKuusiTuntiaKorvaus > 1)
            {
                Console.WriteLine("");
                Console.WriteLine("PÄIVÄRAHAKORVAUKSET");
                Console.WriteLine("");
                Console.WriteLine("Osapäivärahakorvauksia: " + yliKuusiTuntiaKorvaus + " kpl");
                Console.WriteLine("Yksikköhinta: " + osaPäiväRahaHinta + " euroa");
                Console.WriteLine("Osapäivärahojen kokonaishinta: " + (yliKuusiTuntiaKorvaus * osaPäiväRahaHinta) + " euroa");
                korvauksetYhteensä = (yliKuusiTuntiaKorvaus * osaPäiväRahaHinta);
            }
            else
            {
                Console.WriteLine("");
            }

            return korvauksetYhteensä;
        }

    }
}
