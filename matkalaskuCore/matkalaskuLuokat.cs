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

        public int YliYksiPäiväJaKuusiTuntia(int päivät, int kuusiTuntia)
        {
            int kokoPäiväRahaHinta = 43;

            int korvauksetYhteensä = (päivät * kokoPäiväRahaHinta) + (kuusiTuntia * kokoPäiväRahaHinta);

            return korvauksetYhteensä;
        }

        public int YliYksiPäiväJaKaksiTuntia(int päivät, int kaksiTuntia)
        {
            int osaPäiväRahaHinta = 20;
            int kokoPäiväRahaHinta = 43;

            int korvauksetYhteensä = (päivät * kokoPäiväRahaHinta) + (kaksiTuntia * osaPäiväRahaHinta);

            return korvauksetYhteensä;
        }

        public int YliYksiPäiväMutteiMuuta(int päivät)
        {
            int kokoPäiväRahaHinta = 43;

            int korvauksetYhteensä = (päivät * kokoPäiväRahaHinta);

            return korvauksetYhteensä;
        }
        
        public int AllePäiväMuttaYliKymmenenTuntia(int yliKymmenenTuntia)
        {
            int kokoPäiväRahaHinta = 43;

            int korvauksetYhteensä = (yliKymmenenTuntia * kokoPäiväRahaHinta);

            return korvauksetYhteensä;
        }

        public int AllePäiväMuttaYliKuusiTuntia(int yliKuusiTuntia)
        {
            int osaPäiväRahaHinta = 20;

            int korvauksetYhteensä = yliKuusiTuntia * osaPäiväRahaHinta;

            return korvauksetYhteensä;
        }

        public double MoottoriveneEnintään50Hv(double kilometrit)
        {
            double kmKorvausPerKm = 0.75;

            double korvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return korvauksetYhteensä;
        }
        public double MoottoriveneYli50Hv(double kilometrit)
        {
            double kmKorvausPerKm = 1.10;

            double KorvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return KorvauksetYhteensä;
        }
        public double Moottorikelkka(double kilometrit)
        {
            double kmKorvausPerKm = 1.04;

            double KorvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return KorvauksetYhteensä;
        }
        public double Mönkijä(double kilometrit)
        {
            double kmKorvausPerKm = 0.98;

            double KorvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return KorvauksetYhteensä;
        }
        public double Moottoripyörä(double kilometrit)
        {
            double kmKorvausPerKm = 0.33;

            double KorvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return KorvauksetYhteensä;
        }
        public double Mopo(double kilometrit)
        {
            double kmKorvausPerKm = 0.18;

            double KorvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return KorvauksetYhteensä;
        }
        public double MuuKulkuneuvo(double kilometrit)
        {
            double kmKorvausPerKm = 0.10;

            double KorvauksetYhteensä = kilometrit * kmKorvausPerKm;

            return KorvauksetYhteensä;
        }

    }   
}
