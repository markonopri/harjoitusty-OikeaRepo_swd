using System;
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


            }
            while (valinta != 5);
                return 0;
        }
    }
}
