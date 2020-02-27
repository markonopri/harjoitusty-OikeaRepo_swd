﻿using matkalaskuCore;
using System;
using System.IO;
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
            static void Main(string[] args)
            {
                int valinta;
                int muokkausvalinta;
                ArrayList matkanLähtöaika = new ArrayList();
                ArrayList matkanPaluuaika = new ArrayList();
                List<int> matkanKestoMin = new List<int>();
                List<string> matkanTarkoitus = new List<string>();
                List<string> matkanLisätiedot = new List<string>();
                List<string> matkakorvausSaaja = new List<string>();
                ArrayList matkalaskunLuomisPvm = new ArrayList();
                List<string> reitinKuvaus = new List<string>();
                List<double> välimatkaKm = new List<double>();
                List<int> välimatkaKm2 = new List<int>();
                List<double> matkustajienLukumäärä = new List<double>();
                int laskujenMäärä = 0;
                List<int> matkalaskunStatus = new List<int>();

                int päivärahaKorvausMäärä = 0;

                // Matkalasku-ohjelma käyttöliittymä
            do
                {
                    Console.WriteLine("-Matkalasku-");
                    Console.WriteLine("------------");
                    Console.WriteLine("1. Lisää uusi matkalasku");
                    Console.WriteLine("2. Näytä matkalasku");
                    Console.WriteLine("3. Matkalaskun muokkaus");
                    Console.WriteLine("4. Poista matkalasku"); // kesken korjaus!
                    Console.WriteLine("5. Lopeta ohjelma");
                    valinta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                if (valinta == 1)
                {
                    // Lisää uusi matkalasku
                    Console.WriteLine("-Lisää uusi matkalasku-");
                    Console.WriteLine("");

                    // Matkan lähtöaika
                    Console.WriteLine("Anna matkan lähtöaika (pp.kk.vvvv klo hh.mm)");
                    string lähtöpvm = Console.ReadLine();
                    matkanLähtöaika.Insert(laskujenMäärä, lähtöpvm);
                    int lähtöpäivä = Int32.Parse(lähtöpvm.Substring(0, 2));
                    int lähtökuukausi = Int32.Parse(lähtöpvm.Substring(3, 2));
                    int lähtövuosi = Int32.Parse(lähtöpvm.Substring(6, 4));
                    int lähtötunti = Int32.Parse(lähtöpvm.Substring(15, 2));
                    int lähtöminuutti = Int32.Parse(lähtöpvm.Substring(18, 2));

                    // Matkan paluuaika
                    Console.WriteLine("Anna matkan paluuaika (pp.kk.vvvv klo hh.mm)");
                    string paluupvm = Console.ReadLine();
                    matkanPaluuaika.Insert(laskujenMäärä, paluupvm);
                    int paluupäivä = Int32.Parse(paluupvm.Substring(0, 2));
                    int paluukuukausi = Int32.Parse(paluupvm.Substring(3, 2));
                    int paluuvuosi = Int32.Parse(paluupvm.Substring(6, 4));
                    int paluutunti = Int32.Parse(paluupvm.Substring(15, 2));
                    int paluuminuutti = Int32.Parse(paluupvm.Substring(18, 2));

                    // Matkan keston laskenta
                    // vuosi, kuukausi, päivä, tunti, minuutti, sekunti
                    DateTime a = new DateTime(lähtövuosi, lähtökuukausi, lähtöpäivä, lähtötunti, lähtöminuutti, 00);
                    DateTime b = new DateTime(paluuvuosi, paluukuukausi, paluupäivä, paluutunti, paluuminuutti, 00);

                    // Matkan kesto minuutteina
                    var matkanKesto = b.Subtract(a).TotalMinutes;
                    int matkanKestoSyöte = Convert.ToInt32(matkanKesto);
                    matkanKestoMin.Insert(laskujenMäärä, matkanKestoSyöte);

                    // Matkan tarkoitus ja lisätiedot
                    Console.WriteLine("Anna matkan tarkoitus");
                    string matkanTarkoitusSyöte = Console.ReadLine();
                    matkanTarkoitus.Insert(laskujenMäärä, matkanTarkoitusSyöte);

                    // Matkan lisätiedot
                    Console.WriteLine("Syötä lisätietoja matkasta");
                    string lisätietoSyöte = Console.ReadLine();
                    matkanLisätiedot.Insert(laskujenMäärä, lisätietoSyöte);

                    // Matkakorvauksen saaja
                    Console.WriteLine("Syötä matkakorvauksen saaja");
                    string matkakorvausSaajaSyöte = Console.ReadLine();
                    matkakorvausSaaja.Insert(laskujenMäärä, matkakorvausSaajaSyöte);

                    // Matkalaskun päivämäärä
                    Console.WriteLine("Syötä matkalaskun päivämäärä (pp.kk.vvvv klo hh.mm)");
                    string pvmSyöte = Console.ReadLine();
                    matkalaskunLuomisPvm.Insert(laskujenMäärä, pvmSyöte);

                    // Reitin kuvaus
                    Console.WriteLine("Syötä reitin kuvaus");
                    string reitinKuvausSyöte = Console.ReadLine();
                    reitinKuvaus.Insert(laskujenMäärä, reitinKuvausSyöte);

                    // Välimatka (km)
                    Console.WriteLine("Syötä välimatka kilometreinä (km)");
                    int kilometriSyöte = Convert.ToInt32(Console.ReadLine());

                    välimatkaKm.Insert(laskujenMäärä, kilometriSyöte);
                    välimatkaKm2.Insert(laskujenMäärä, kilometriSyöte);

                    // Matkustajien lukumäärä
                    Console.WriteLine("Syötä matkustajien lukumäärä");
                    int matkustajaSyöte = Convert.ToInt32(Console.ReadLine());
                    matkustajienLukumäärä.Insert(laskujenMäärä, matkustajaSyöte);
                    Console.WriteLine("");

                    // Matkalaskun status [MAKSETTU / EI MAKSETTU]
                    Console.WriteLine("Onko matkalasku maksettu: ");
                    Console.WriteLine("Kyllä = 1");
                    Console.WriteLine("Ei = 2");
                    int laskunStatusValintaSyöte = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (laskunStatusValintaSyöte == 1)
                    {
                        matkalaskunStatus.Insert(laskujenMäärä, laskunStatusValintaSyöte);
                    }
                    else if (laskunStatusValintaSyöte == 2)
                    {
                        matkalaskunStatus.Insert(laskujenMäärä, laskunStatusValintaSyöte);
                    }

                    laskujenMäärä++;
                }

                // Näytä matkalasku(t)
                else if (valinta == 2)
                {
                    Console.WriteLine("-Näytä matkalasku-");
                    Console.WriteLine("------------");
                    Console.WriteLine("");
                    Console.WriteLine("Matkalaskujen lukumäärä: " + laskujenMäärä);
                    Console.WriteLine("Anna laskun numero");
                    int laskunNumero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    // Mikä lasku kyseessä
                    Console.WriteLine("------------------------");
                    Console.WriteLine("MATKALASKU NRO " + laskunNumero);
                    Console.WriteLine("------------------------");
                    Console.WriteLine("");

                    // Matkalaskun maksettutila [MAKSETTU / EI MAKSETTU]
                    if (matkalaskunStatus[laskunNumero - 1] == 1)
                    {
                        Console.WriteLine("[MAKSETTU]");
                        Console.WriteLine("");
                    }
                    else if (matkalaskunStatus[laskunNumero - 1] == 2)
                    {
                        Console.WriteLine("[EI MAKSETTU]");
                        Console.WriteLine("");
                    }

                    // Matkan lähtö- ja paluuaika
                    Console.WriteLine("Matkan lähtöaika: " + matkanLähtöaika[laskunNumero - 1]);
                    Console.WriteLine("Matkan paluuaika: " + matkanPaluuaika[laskunNumero - 1]);
                    Console.WriteLine("");

                    // Matkan tarkoitus, lisätietoja, korvauksen saaja
                    Console.WriteLine("Matkan tarkoitus: " + matkanTarkoitus[laskunNumero - 1]);
                    Console.WriteLine("Lisätietoja: " + matkanLisätiedot[laskunNumero - 1]);
                    Console.WriteLine("Korvauksen saaja: " + matkakorvausSaaja[laskunNumero - 1]);
                    Console.WriteLine("");

                    // Matkan reitti ja välimatka
                    Console.WriteLine("Reitti: " + reitinKuvaus[laskunNumero - 1]);
                    Console.WriteLine("Välimatka: " + välimatkaKm[laskunNumero - 1] + " km");
                    Console.WriteLine("");

                    // Kilometrikorvauksen laskin
                    matkalaskuLuokat korvaus = new matkalaskuLuokat();
                    double matkustajienLukumäärä2 = matkustajienLukumäärä[laskunNumero - 1];
                    double välimatkaKm3 = välimatkaKm[laskunNumero - 1];

                    double kilometrikorvausMäärä = korvaus.Kilometrikorvaus(matkustajienLukumäärä2, välimatkaKm3);

                    Console.WriteLine("------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("KILOMETRIKORVAUKSET");
                    Console.WriteLine("");
                    Console.WriteLine("Henkilöiden lukumäärä: " + matkustajienLukumäärä[laskunNumero - 1] + " kpl");
                    Console.WriteLine("Kilometrit: " + välimatkaKm[laskunNumero - 1] + " km");
                    Console.WriteLine("EUR / km: 0.43 euroa");
                    Console.WriteLine("Kilometrikorvausten kokonaishinta: " + kilometrikorvausMäärä + " euroa");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------");

                    // Päivärahakorvaus laskin
                    int minuutit = matkanKestoMin[laskunNumero - 1];
                    int päivät = 0;
                    int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                    int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;
                    int yliKymmenenTuntiaKorvaus = 0;
                    int yliKuusiTuntiaKorvaus = 0;
                    int kokoPäiväRahaHinta = 43;
                    int osaPäiväRahaHinta = 20;

                    // Lasketaan päivät ja aika, jos päivät yli 1
                    if (välimatkaKm2[laskunNumero - 1] > 15)
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
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    // Lasketaan päivät ja aika, jos päivät alle 0 
                    if (välimatkaKm2[laskunNumero - 1] > 15 && päivät == 0)
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
                        matkalaskuLuokat päivärahaKorvaus1 = new matkalaskuLuokat();
                        päivärahaKorvausMäärä = päivärahaKorvaus1.YliYksiPäiväJaKuusiTuntia(päivät, yliYksiPäiväJaKuusiTuntiaKorvaus);
                    }
                    else if (päivät > 0 && yliYksiPäiväJaKaksiTuntiaKorvaus > 0)
                    {
                        matkalaskuLuokat päivärahaKorvaus2 = new matkalaskuLuokat();
                        päivärahaKorvausMäärä = päivärahaKorvaus2.YliYksiPäiväJaKaksiTuntia(päivät, yliYksiPäiväJaKaksiTuntiaKorvaus);
                    }
                    else if (päivät > 0)
                    {
                        matkalaskuLuokat päivärahaKorvaus3 = new matkalaskuLuokat();
                        päivärahaKorvausMäärä = päivärahaKorvaus3.YliYksiPäiväMutteiMuuta(päivät);
                    }
                    else if (päivät == 0 && yliKymmenenTuntiaKorvaus == 1)
                    {
                        matkalaskuLuokat päivärahakorvaus4 = new matkalaskuLuokat();
                        päivärahaKorvausMäärä = päivärahakorvaus4.AllePäiväMuttaYliKymmenenTuntia(yliKymmenenTuntiaKorvaus);
                    }
                    else if (päivät == 0 && yliKuusiTuntiaKorvaus == 1)
                    {
                        matkalaskuLuokat päivärahakorvaus5 = new matkalaskuLuokat();
                        päivärahaKorvausMäärä = päivärahakorvaus5.AllePäiväMuttaYliKuusiTuntia(yliKuusiTuntiaKorvaus);
                    }

                    // Päivärahakorvauksen laskin
                    Console.WriteLine("");
                    Console.WriteLine("PÄIVÄRAHAKORVAUKSET:");
                    Console.WriteLine("");
                    if (yliKuusiTuntiaKorvaus == 1)
                    {
                        Console.WriteLine("Kokopäivärahakorvauksia: " + (päivät + yliYksiPäiväJaKuusiTuntiaKorvaus - 1) + " kpl");
                        Console.WriteLine("Yksikköhinta: " + kokoPäiväRahaHinta + " euroa");
                        Console.WriteLine("Kokopäivärahojen kokonaishinta: " + ((päivät + yliYksiPäiväJaKuusiTuntiaKorvaus - 1) * kokoPäiväRahaHinta) + " euroa");
                    }
                    else
                    {
                        Console.WriteLine("Kokopäivärahakorvauksia: " + (päivät + yliYksiPäiväJaKuusiTuntiaKorvaus) + " kpl");
                        Console.WriteLine("Yksikköhinta: " + kokoPäiväRahaHinta + " euroa");
                        Console.WriteLine("Kokopäivärahojen kokonaishinta: " + ((päivät + yliYksiPäiväJaKuusiTuntiaKorvaus) * kokoPäiväRahaHinta) + " euroa");
                    }                    
                    Console.WriteLine("");
                    Console.WriteLine("Osapäivärahakorvauksia: " + (yliYksiPäiväJaKaksiTuntiaKorvaus + yliKuusiTuntiaKorvaus) + " kpl");
                    Console.WriteLine("Yksikköhinta: " + osaPäiväRahaHinta + " euroa");
                    Console.WriteLine("Osapäivärahojen kokonaishinta: " + (yliYksiPäiväJaKaksiTuntiaKorvaus + yliKuusiTuntiaKorvaus) * osaPäiväRahaHinta + " euroa");
                    Console.WriteLine("");
                    Console.WriteLine("Päivärahojen kokonaishinta: " + päivärahaKorvausMäärä + " euroa");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("");

                    // Maksetaan yhteensä korvauksia
                    Console.WriteLine("Maksetaan korvauksia yhteensä: " + (päivärahaKorvausMäärä + kilometrikorvausMäärä) + " euroa");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("");

                    // Tallennetaanko lasku
                    Console.WriteLine("\n### TALLENNA LASKU ###\n1. Kyllä\n2. Ei\n");
                    int laskuTallennus = Convert.ToInt32(Console.ReadLine());

                    if (laskuTallennus == 1)
                    {
                        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "matkalasku" + laskunNumero + ".txt")))
                        {
                            outputFile.WriteLine("--MATKALASKU--");
                            outputFile.WriteLine("--------------");

                            outputFile.WriteLine("------------------------");
                            outputFile.WriteLine("MATKALASKU NRO " + laskunNumero);
                            outputFile.WriteLine("------------------------");
                            outputFile.WriteLine("");

                            // Matkan lähtö- ja paluuaika
                            outputFile.WriteLine("Matkan lähtöaika: " + matkanLähtöaika[laskunNumero - 1]);
                            outputFile.WriteLine("Matkan paluuaika: " + matkanPaluuaika[laskunNumero - 1]);
                            outputFile.WriteLine("");

                            // Matkan tarkoitus, lisätietoja, korvauksen saaja
                            outputFile.WriteLine("Matkan tarkoitus: " + matkanTarkoitus[laskunNumero - 1]);
                            outputFile.WriteLine("Lisätietoja: " + matkanLisätiedot[laskunNumero - 1]);
                            outputFile.WriteLine("Korvauksen saaja: " + matkakorvausSaaja[laskunNumero - 1]);
                            outputFile.WriteLine("");

                            // Matkan reitti ja välimatka
                            outputFile.WriteLine("Reitti: " + reitinKuvaus[laskunNumero - 1]);
                            outputFile.WriteLine("Välimatka: " + välimatkaKm[laskunNumero - 1] + " km");
                            outputFile.WriteLine("");

                            outputFile.WriteLine("------------------------");
                            outputFile.WriteLine("");
                            outputFile.WriteLine("KILOMETRIKORVAUKSET");
                            outputFile.WriteLine("");
                            outputFile.WriteLine("Henkilöiden lukumäärä: " + matkustajienLukumäärä[laskunNumero - 1] + " kpl");
                            outputFile.WriteLine("Kilometrit: " + välimatkaKm[laskunNumero - 1] + " km");
                            outputFile.WriteLine("EUR / km: 0.43 euroa");
                            outputFile.WriteLine("kokonaishinta: " + kilometrikorvausMäärä + " euroa");
                            outputFile.WriteLine("");
                            outputFile.WriteLine("------------------------");

                            // Päivärahakorvauksen laskin
                            outputFile.WriteLine("Päivärahojen kokonaishinta: " + päivärahaKorvausMäärä + " euroa");
                            outputFile.WriteLine("");
                            outputFile.WriteLine("------------------------");
                            outputFile.WriteLine("");

                            // Maksetaan yhteensä korvauksia
                            outputFile.WriteLine("Maksetaan korvauksia yhteensä: " + (päivärahaKorvausMäärä + kilometrikorvausMäärä) + " euroa");
                            outputFile.WriteLine("");
                            outputFile.WriteLine("------------------------");
                            outputFile.WriteLine("");

                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                // Matkalaskun muokkaus
                else if (valinta == 3)
                {
                    Console.WriteLine("-Matkalaskun muokkaaminen-");
                    Console.WriteLine("------------");
                    Console.WriteLine("Matkalaskujen lukumäärä: " + laskujenMäärä);
                    Console.WriteLine("Anna laskun numero");
                    int laskunNumero2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    // Mitä laskua muokataan
                    Console.WriteLine("------------------------");
                    Console.WriteLine("MATKALASKU NRO " + laskunNumero2);
                    Console.WriteLine("------------------------");
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Valitse jokin seuraavista: \n");
                        Console.WriteLine("1. Matkan lähtöaika");
                        Console.WriteLine("2. Matkan paluuaika");
                        Console.WriteLine("3. Matkan tarkoitus");
                        Console.WriteLine("4. Matkan lisätiedot");
                        Console.WriteLine("5. Matkakorvauksen saaja");
                        Console.WriteLine("6. Reitin kuvaus");
                        Console.WriteLine("7. Reitin kilometrit");
                        Console.WriteLine("8. Matkustajien lukumäärä");
                        Console.WriteLine("9. Matkalaskun päivämäärä");
                        Console.WriteLine("10. Matkalaskun status");
                        Console.WriteLine("11. Palaa etusivulle");
                        muokkausvalinta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        // Muokkaa matkan lähtöaika
                        if (muokkausvalinta == 1)
                        {
                            Console.WriteLine("Nykyinen lähtöaika: " + matkanLähtöaika[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi lähtöaika: ");
                            string lähtöaikaSyöte = Console.ReadLine();

                            matkanLähtöaika[laskunNumero2 - 1] = lähtöaikaSyöte;
                        }
                        // Muokkaa matkan paluuaika
                        else if (muokkausvalinta == 2)
                        {
                            Console.WriteLine("Nykyinen paluuaika: " + matkanPaluuaika[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi paluuaika: ");
                            string paluuaikaSyöte = Console.ReadLine();

                            matkanPaluuaika[laskunNumero2 - 1] = paluuaikaSyöte;
                        }
                        // Muokkaa matkan tarkoitus
                        else if (muokkausvalinta == 3)
                        {
                            Console.WriteLine("Nykyinen matkan tarkoitus: " + matkanTarkoitus[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi matkan tarkoitus: ");
                            string matkanTarkoitusSyöte = Console.ReadLine();

                            matkanTarkoitus[laskunNumero2 - 1] = matkanTarkoitusSyöte;
                        }
                        // Muokkaa matkan lisätiedot 
                        else if (muokkausvalinta == 4)
                        {
                            Console.WriteLine("Nykyinen matkan lisätieto: " + matkanLisätiedot[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi matkan lisätieto: ");
                            string lisätiedotSyöte = Console.ReadLine();

                            matkanLisätiedot[laskunNumero2 - 1] = lisätiedotSyöte;
                        }
                        // Muokkaa matkakorvauksen saaja 
                        else if (muokkausvalinta == 5)
                        {
                            Console.WriteLine("Nykyinen matkakorvauksen saaja: " + matkakorvausSaaja[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi matkakorvauksen saaja: ");
                            string matkakorvausSaajaSyöte = Console.ReadLine();

                            matkakorvausSaaja[laskunNumero2 - 1] = matkakorvausSaajaSyöte;
                        }
                        // Muokkaa reitin kuvaus
                        else if (muokkausvalinta == 6)
                        {
                            Console.WriteLine("Nykyinen reitin kuvaus: " + reitinKuvaus[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi reitin kuvaus: ");
                            string reitinKuvausSyöte = Console.ReadLine();

                            reitinKuvaus[laskunNumero2 - 1] = reitinKuvausSyöte;
                        }
                        // Muokkaa reitin välimatkaa (kilometrit)
                        else if (muokkausvalinta == 7)
                        {
                            Console.WriteLine("Nykyinen välimatka (km): " + välimatkaKm[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi välimatka (km): ");
                            int välimatkaKmSyöte = Convert.ToInt32(Console.ReadLine());

                            välimatkaKm[laskunNumero2 - 1] = välimatkaKmSyöte;
                            välimatkaKm2[laskunNumero2 - 1] = välimatkaKmSyöte;
                        }
                        // Muokkaa matkustajien lukumäärää
                        else if (muokkausvalinta == 8)
                        {
                            Console.WriteLine("Nykyinen matkustajien lukumäärä: " + matkustajienLukumäärä[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi matkustajien lukumäärä: ");
                            int matkustajienLukumääräSyöte = Convert.ToInt32(Console.ReadLine());

                            matkustajienLukumäärä[laskunNumero2 - 1] = matkustajienLukumääräSyöte;
                        }
                        // Muokkaa matkalaskun päivämäärää
                        else if (muokkausvalinta == 9)
                        {
                            Console.WriteLine("Nykyinen matkalaskun luomispäivämäärä: " + matkalaskunLuomisPvm[laskunNumero2 - 1]);
                            Console.WriteLine("Syötä uusi matkalaskun luomispäivämäärä: ");
                            string matkalaskunLuomisPvmSyöte = Console.ReadLine();

                            matkalaskunLuomisPvm[laskunNumero2 - 1] = matkalaskunLuomisPvmSyöte;
                        }
                        // Muokkaa laskun status
                        else if (muokkausvalinta == 10)
                        {
                            // Jos maksettu
                            if (matkalaskunStatus[laskunNumero2 - 1] == 1)
                            {
                                Console.WriteLine("Nykyinen matkalaskun status: [MAKSETTU]");
                                Console.WriteLine("Syötä uusi matkalaskun status: ");
                                Console.WriteLine("Onko matkalasku maksettu: ");
                                Console.WriteLine("Kyllä = 1");
                                Console.WriteLine("Ei = 2");
                                int matkalaskunStatusSyöte = Convert.ToInt32(Console.ReadLine());

                                matkalaskunStatus[laskunNumero2 - 1] = matkalaskunStatusSyöte;
                            }
                            // Jos ei maksettu
                            else if (matkalaskunStatus[laskunNumero2 - 1] == 2)
                            {
                                Console.WriteLine("Nykyinen matkalaskun status: [EI MAKSETTU]");
                                Console.WriteLine("Syötä uusi matkalaskun status: ");
                                Console.WriteLine("Onko matkalasku maksettu: ");
                                Console.WriteLine("Kyllä = 1");
                                Console.WriteLine("Ei = 2");
                                int matkalaskunStatusSyöte = Convert.ToInt32(Console.ReadLine());

                                matkalaskunStatus[laskunNumero2 - 1] = matkalaskunStatusSyöte;
                            }
                        }
                    }
                    while (muokkausvalinta != 11);
                }
                else if (valinta == 4)
                {
                    //Array.Clear(arr, 0, arr.Length); // KESKEN VIELä

                }




            }
                while (valinta != 5);
            }
    }
}
