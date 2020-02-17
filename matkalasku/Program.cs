using matkalaskuCore;
using System;
using System.Collections;
using System.Collections.Generic;

namespace matkalasku
{
    /**
                Matkalaskun sisältö on seuraavanlainen:
	            •	Matkan lähtö- ja paluuaika.
	            •	Matkan tarkoitus ja lisätiedot.
	            •	Matkakorvauksen saaja.
	            •	Ajankohta, jolloin matkalasku on luotu.
	            •	Reitin kuvaus ja välimatka (km)
	            •	Matkustajien lukumäärä.              Annettujen tietojen perusteella ohjelman tulisi laskea:
	            •	Kilometrikorvaus auton käytöstä (https://www.veronmaksajat.fi/Palkka-ja-elake/Kilometrikorvaukset/kilometrikorvaukset-2020/#3c29c31d)
	            •	Kilometrikorvauksesta tulisi nähdä sen erittely eli mistä kokonaiskorvaus muodostuu. (kilometrit, henkilöiden lkm., laskemiseen käytetty korvauksen määrä per kilometri)
	            •	Päivärahat matkan keston perusteella. (https://www.veronmaksajat.fi/Palkka-ja-elake/Paivarahat/kotimaan-paivarahat-2020/#3c29c31d)
	            •	Päivärahasta tulee nähdä määrä, yksikköhinta ja päivärahojen kokonaiskorvaus.
	            •	Lopuksi ohjelman tulee laskea edellisten tietojen pohjalta kokonaiskorvaus.               Ohjelman toimintojen lisätoiveet
	            •	Matkalaskun laskemiseen käytettyjä korvausmääriä voi vaihtaa.
	            •	Matkalaskuun voi merkitä myös auton lisäksi muita kulkuneuvoja.
	            •	Matkalaskuista saisi yhden yhteenvedon kaikista luoduista matkalaskuista.
	            •	Matkalaskun voi merkitä Maksetuksi -tilaan.
	            •	Matkalaskuja voi luoda usealle eri henkilöille.

    **/

    class Program
    {



        static int Main(string[] args)
        {


            int valinta;
            int valinta2; // ilman tätä esiinty bugeja, joten laitoin
            ArrayList matkanTarkoitus = new ArrayList();
            ArrayList matkanLisätiedot = new ArrayList();
            ArrayList matkanLähtöaika = new ArrayList();
            ArrayList matkanPaluuaika = new ArrayList();
            ArrayList korvauksenSaaja = new ArrayList();
            ArrayList reitinKuvaus = new ArrayList();
            List<double> välimatkaKm = new List<double>();
            List<double> matkustajienLukumäärä = new List<double>();

            // Matkalasku-ohjelman käyttöliittymä.
            do
            {
                Console.WriteLine("-Matkalasku-");
                Console.WriteLine("------------");
                Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                Console.WriteLine("1. Lisää uusi matkalasku");
                Console.WriteLine("2. Näytä matkalaskut");
                Console.WriteLine("3. Muokkaa matkalaskuja");
                Console.WriteLine("4. Poista matkalasku");
                Console.WriteLine("5. Lopeta ohjelma");
                valinta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                // Lisää uusi matkalasku
                if (valinta == 1)
                {
                    do
                    {
                        Console.WriteLine("-Lisää uusi matkalasku-");
                        Console.WriteLine("------------");
                        Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                        Console.WriteLine("1. Matkan lähtö- ja paluuaika");
                        Console.WriteLine("2. Matkan tarkoitus ja lisätiedot");
                        Console.WriteLine("3. Matkakorvauksen saaja");
                        Console.WriteLine("4. Ajankohta, jolloin matkalasku on luotu"); // annetaanko itse syötteenä vai antaako ohjelma automaattisesti päivän?
                        Console.WriteLine("5. Reitin kuvaus ja välimatka(km)");
                        Console.WriteLine("6. Matkustajien lukumäärä");
                        Console.WriteLine("7. Palaa etusivulle");
                        valinta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        // Matkan lähtö- ja paluuaika.
                        if (valinta == 1)
                        {
                            do
                            {
                                Console.WriteLine("-Matkan lähtö- ja paluuaika-");
                                Console.WriteLine("------------");
                                Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                                Console.WriteLine("1. Lisää matkan lähtöaika");
                                Console.WriteLine("2. Lisää matkan paluuaika");
                                Console.WriteLine("3. Palaa etusivulle");
                                valinta2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                // Matkan lähtöaika
                                if (valinta2 == 1)
                                {
                                    Console.WriteLine("Syötä matkan lähtöaika");
                                    string lähtöaikaSyöte = Console.ReadLine();
                                    
                                    matkanLähtöaika.Add(lähtöaikaSyöte);
                                }

                                // Matkan paluuaika
                                else if (valinta2 == 2)
                                {
                                    Console.WriteLine("Syötä matkan paluuaika");
                                    string paluuaikaSyöte = Console.ReadLine();
                                    Console.WriteLine("");

                                    matkanPaluuaika.Add(paluuaikaSyöte);
                                }
                            }
                            while (valinta2 != 3);
                        }

                        // Matkan tarkoitus ja lisätiedot.
                        if (valinta == 2)
                        {
                            do
                            {
                                Console.WriteLine("-Matkan tarkoitus ja lisätiedot-");
                                Console.WriteLine("------------");
                                Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                                Console.WriteLine("1. Lisää matkan tarkoitus");
                                Console.WriteLine("2. Lisää lisätietoja matkaan");
                                Console.WriteLine("3. Palaa etusivulle");
                                valinta2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                // Matkan tarkoitus syöte
                                if (valinta2 == 1)
                                {
                                    Console.WriteLine("Syötä matkan tarkoitus");
                                    string tarkoitusSyöte = Console.ReadLine();
                                    Console.WriteLine("");

                                    matkanTarkoitus.Add(tarkoitusSyöte);

                                }
                                // Matkan lisätietosyöte
                                else if (valinta2 == 2)
                                {
                                    Console.WriteLine("Syötä lisätietoja matkaan");
                                    string lisätietoSyöte = Console.ReadLine();
                                    Console.WriteLine("");

                                    matkanLisätiedot.Add(lisätietoSyöte);
                                }

                            }

                            while (valinta2 != 3);
                        }

                        // Matkakorvauksen saaja
                        if (valinta == 3)
                        {
                            do
                            {
                                Console.WriteLine("-Matkakorvauksen saaja-");
                                Console.WriteLine("------------");
                                Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                                Console.WriteLine("1. Lisää matkakorvauksen saaja");
                                Console.WriteLine("2. Palaa etusivulle");
                                valinta2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                // Matkan lähtöaika
                                if (valinta2 == 1)
                                {
                                    Console.WriteLine("Syötä matkan matkakorvauksen saaja");
                                    string korvausSyöte = Console.ReadLine();

                                    korvauksenSaaja.Add(korvausSyöte);
                                }

                            }
                            while (valinta2 != 2);
                        }

                        // Reitin kuvaus ja välimatka(km)
                        if (valinta == 5)
                        {
                            do
                            {
                                Console.WriteLine("-Reitin kuvaus ja välimatka(km)-");
                                Console.WriteLine("------------");
                                Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                                Console.WriteLine("1. Lisää reitin kuvaus");
                                Console.WriteLine("2. Lisää välimatka(km)");
                                Console.WriteLine("3. Palaa etusivulle");
                                valinta2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                // Reitin kuvaus
                                if (valinta2 == 1)
                                {
                                    Console.WriteLine("Syötä reitin kuvaus");
                                    string reittiSyöte = Console.ReadLine();

                                    reitinKuvaus.Add(reittiSyöte);
                                }

                                // Välimatka (km)
                                else if (valinta2 == 2)
                                {
                                    Console.WriteLine("Syötä välimatka kilometreinä (km)");
                                    int kilometriSyöte = Convert.ToInt32(Console.ReadLine());

                                    välimatkaKm.Add(kilometriSyöte);
                                }
                               
                            }
                            while (valinta2 != 3);
                        }

                        // Matkustajien lukumäärä
                        if (valinta == 6)
                        {
                            do
                            {
                                Console.WriteLine("-Matkustajien lukumäärä-");
                                Console.WriteLine("------------");
                                Console.WriteLine("Valitse jokin seuraavista toimminnoista: \n");
                                Console.WriteLine("1. Lisää matkustajien lukumäärä");
                                Console.WriteLine("2. Palaa etusivulle");
                                valinta2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                if (valinta2 == 1)
                                {
                                    Console.WriteLine("Syötä matkustajien lukumäärä");
                                    int matkustajaSyöte = Convert.ToInt32(Console.ReadLine());
                                    
                                    matkustajienLukumäärä.Add(matkustajaSyöte);
                                }
                            }
                            while (valinta2 != 2);
                        }
                    }
                    while (valinta != 7);
            
                }
                // Näytä matkalaskut -- Suurin osa testinä toistaiseksi, että tulostus toimii
                else if (valinta == 2)
                {
                    // Kilometrikorvauksen laskin
                    matkalaskuLuokat korvaus = new matkalaskuLuokat();
                    double korvausMäärä = korvaus.Kilometrikorvaus(matkustajienLukumäärä, välimatkaKm);

                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("KILOMETRIKORVAUKSET:");
                    Console.WriteLine("");
                    Console.WriteLine("Henkilöiden lukumäärä: " + matkustajienLukumäärä[0] + " kpl");
                    Console.WriteLine("Kilometrit: " + välimatkaKm[0] + " km");
                    Console.WriteLine("EUR / km: 0.43 euroa");
                    Console.WriteLine("Kokonaishinta: " + korvausMäärä + " euroa");
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------");

                    foreach (var item in matkanLähtöaika)
                    {
                        Console.WriteLine("Matkan lähtöaika: " + item);
                    }

                    foreach (var item in matkanPaluuaika)
                    {
                        Console.WriteLine("Matkan paluuaika: " + item);
                    }

                    foreach (var item in matkanTarkoitus)
                    {
                        Console.WriteLine("Matkan tarkoitus: " + item);
                    }

                    foreach (var item in matkanLisätiedot)
                    {
                        Console.WriteLine("Matkan lisätiedot: " + item);
                    }

                    foreach (var item in korvauksenSaaja)
                    {
                        Console.WriteLine("Matkakorvauksen saaja: " + item);
                    }

                    foreach (var item in reitinKuvaus)
                    {
                        Console.WriteLine("Reitin kuvaus: " + item);
                    }

                    Console.WriteLine("");
                }

            }
            while (valinta != 5);
            return 0;

            
        }
    }
}
