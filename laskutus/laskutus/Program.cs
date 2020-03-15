using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;


// -Ohjelmaan lisättäisiin asiakas ja palvelutaso.
// -Asiakkaalla voi olla kerrallaan vain yksi palvelutaso ja laskutus tapahtuu kuukausittain aina 30 päivän välein.
// -Palvelutasoja voi olla useita erilaisia ja niillä tarkoitetaan esimerkiksi Basic, Pro, Enterprise versioita tulevasta verkkopalvelusta.
// Palvelutasolle pitää pystyä määrittämään kuukausihinta.
// -Asiakas toivoisi, että voisi nähdä ohjelmasta listan tulevista maksuista seuraavilta kuukausilta.
// -Asiakas haluaisi tarjota myös mahdollisuuden ostaa esimerkiksi 6kk tai 12kk kerralla ja vasta sen jälkeen alkaisi kuukausikohtainen laskutus.
// Jos palvelusta maksetaan heti 6kk, kokonaishintaan annetaan 10% alennus ja 12kk kohdalla, kokonaishintaan annetaan 18% alennus.


namespace laskutusohjelma
{
    class Program
    {
        static void Main(string[] args)
        {

            int asiakasNro = 0;
            int valinta;

            // Hintojen määrittely
            double Pro = 0.0;
            double SemiPro = 0.0;
            double Basic = 0.0;

            // Tasojen laskurit
            int ProCount = 0;
            int SemiProCount = 0;
            int BasicCount = 0;

            // Maksutapojen laskurit
            int kkMaksuCount = 0;
            int SixKKCount = 0;
            int twelveKKCount = 0;


            // Funktio 6kk alennukselle
            static double calcSix(double x)
            {
                double alennus = x * 0.9;
                double loppusumma = alennus * 5;
                // kerrotaan viidellä koska yksi kuukausi on ilmainen kokeilukuukausi
                return loppusumma;
            }

            // Funktio 12kk alennukselle
            static double calcTwelve(double x)
            {
                double alennus = x * 0.82;
                double loppusumma = alennus * 11;
                // kerrotaan viidellä koska yksi kuukausi on ilmainen kokeilukuukausi
                return loppusumma;
            }
            static double calcKK(double x)
            {
                double loppusumma = x * 5;
                // kuukausimaksullisella on ensimmäinen kuukausi ilmainen. Joten 6kk lasku on 5*kkmaksu
                return loppusumma;
            }
            

            List<string> asiakasNimi = new List<string>();  // Asiakkaan nimi
            List<string> asiakasTaso = new List<string>();  // asiakkaan taso
            List<string> asiakasLaskutus = new List<string>();  // asiakkaan 
            List<Double> TasoSumma = new List<double>();    // asiakkaan tason summa
            List<Double> laskuRekisteri = new List<double>();   // Rekisteri laskujen summalle


            do
            {
                Console.WriteLine("-Laskutusohjelma-");
                Console.WriteLine("-----------------\n");
                Console.WriteLine("Valitse seuraavista vaihtoehdoista: \n");
                Console.WriteLine("1. Määritä tasojen hinnat");
                Console.WriteLine("2. Lisää asiakas");
                Console.WriteLine("3. Tulevat maksut");
                Console.WriteLine("4. Päivitä asiakas");
                Console.WriteLine("5. Lopeta ohjelma");
                valinta = Convert.ToInt32(Console.ReadLine());

                if (valinta == 2)   // Lisää asiakas
                {
                    
                    // Asiakkaan nimi
                    Console.WriteLine("-Lisää asiakas-");
                    Console.WriteLine("---------------");
                    Console.WriteLine("Lisää asiakkaan nimi: ");
                    string syoteNimi = Convert.ToString(Console.ReadLine());
                    asiakasNimi.Insert(asiakasNro, syoteNimi);

                    // Asiakkaan taso
                    Console.WriteLine("-Lisää asiakkaan tilauksen taso-");
                    Console.WriteLine("--------------------------------\n");
                    Console.WriteLine("1. Pro");
                    Console.WriteLine("2. Semipro");
                    Console.WriteLine("3. Basic");
                    int syoteTaso = Convert.ToInt32(Console.ReadLine());
                    if(syoteTaso == 1)
                    {
                        asiakasTaso.Insert(asiakasNro, "Pro");
                        ProCount++;
                        TasoSumma.Insert(asiakasNro, Pro);
                    }
                    else if(syoteTaso == 2)
                    {
                        asiakasTaso.Insert(asiakasNro, "SemiPro");
                        SemiProCount++;
                        TasoSumma.Insert(asiakasNro, SemiPro);
                    }
                    else if(syoteTaso == 3)
                    {
                        asiakasTaso.Insert(asiakasNro, "Basic");
                        BasicCount++;
                        TasoSumma.Insert(asiakasNro, Basic);
                    }


                    // Asiakkaan laskutustapa
                    Console.WriteLine("-Laskutustapa-");
                    Console.WriteLine("--------------\n");
                    Console.WriteLine("1. kuukausikohtainen laskutus");
                    Console.WriteLine("2. 6kk tilaus");
                    Console.WriteLine("3. 12kk tilaus\n");
                    int syoteTilaus = Convert.ToInt32(Console.ReadLine());

                    if (syoteTilaus == 1)
                    {
                        Console.WriteLine("Kuukausikohtainen laskutus valittu!");
                        asiakasLaskutus.Insert(asiakasNro, "Kuukausikohtainen laskutus");
                        kkMaksuCount++;
                    }
                    else if (syoteTilaus == 2)
                    {
                        Console.WriteLine("6kk tilaus valittu!");
                        asiakasLaskutus.Insert(asiakasNro, "6kk tilaus");
                        SixKKCount++;
                    }
                    else if (syoteTilaus == 3)
                    {
                        Console.WriteLine("12kk tilaus valittu!");
                        asiakasLaskutus.Insert(asiakasNro, "12kk tilaus");
                        twelveKKCount++;
                    }
                    else
                    {
                        Console.WriteLine("Syöttövirhe!");
                    }

                    // Kuukausilaskutus

                    if (asiakasTaso[asiakasNro] == "Pro" && asiakasLaskutus[asiakasNro] == "Kuukausikohtainen laskutus")
                    {
                        //Console.WriteLine(calcKK(Pro));
                        laskuRekisteri.Insert(asiakasNro, calcKK(Pro));
                    }

                    else if (asiakasTaso[asiakasNro] == "SemiPro" && asiakasLaskutus[asiakasNro] == "Kuukausikohtainen laskutus")
                    {
                        //Console.WriteLine(calcKK(SemiPro));
                        laskuRekisteri.Insert(asiakasNro, calcKK(SemiPro));
                    }

                    else if (asiakasTaso[asiakasNro] == "Basic" && asiakasLaskutus[asiakasNro] == "Kuukausikohtainen laskutus")
                    {
                        //Console.WriteLine(calcKK(Basic));
                        laskuRekisteri.Insert(asiakasNro, calcKK(Basic));
                    }

                    // 6kk Laskutus

                    else if (asiakasTaso[asiakasNro] == "Pro" && asiakasLaskutus[asiakasNro] == "6kk tilaus")
                    {
                        //Console.WriteLine(calcSix(Pro));
                        laskuRekisteri.Insert(asiakasNro, calcSix(Pro));
                    }
                    else if (asiakasTaso[asiakasNro] == "SemiPro" && asiakasLaskutus[asiakasNro] == "6kk tilaus")
                    {
                        //Console.WriteLine(calcSix(SemiPro));
                        laskuRekisteri.Insert(asiakasNro, calcSix(SemiPro));
                    }
                    else if (asiakasTaso[asiakasNro] == "Basic" && asiakasLaskutus[asiakasNro] == "6kk tilaus")
                    {
                        //Console.WriteLine(calcSix(Basic));
                        laskuRekisteri.Insert(asiakasNro, calcSix(Basic));
                    }

                    // 12kk Laskutus

                    else if (asiakasTaso[asiakasNro] == "Pro" && asiakasLaskutus[asiakasNro] == "12kk tilaus")
                    {
                        //Console.WriteLine(calcTwelve(Pro));
                        laskuRekisteri.Insert(asiakasNro, calcTwelve(Pro));
                    }
                    else if (asiakasTaso[asiakasNro] == "SemiPro" && asiakasLaskutus[asiakasNro] == "12kk tilaus")
                    {
                        //Console.WriteLine(calcTwelve(SemiPro));
                        laskuRekisteri.Insert(asiakasNro, calcTwelve(SemiPro));
                    }
                    else if (asiakasTaso[asiakasNro] == "Basic" && asiakasLaskutus[asiakasNro] == "12kk tilaus")
                    {
                        //Console.WriteLine(calcTwelve(Basic));
                        laskuRekisteri.Insert(asiakasNro, calcTwelve(Basic));
                    }


                    asiakasNro++;


                }   
                else if (valinta == 1)  // Määritä tasojen hinnat
                {
                    Console.WriteLine("-Määritä tasojen hinnat-");
                    Console.WriteLine("------------------------\n");
                    Console.WriteLine("1. Pro");
                    Console.WriteLine("2. SemiPro");
                    Console.WriteLine("3. Basic\n");
                    int syoteTasoMaaritys = Convert.ToInt32(Console.ReadLine());
                    if (syoteTasoMaaritys == 1)
                    {
                        Console.WriteLine("-Pro määritys-");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Kirjoita kuukausikohtainen hinta (esim. 25,0):\n");
                        double syotePro = Convert.ToDouble(Console.ReadLine());
                        Pro += syotePro;
                        Console.WriteLine("Hinnaksi lisätty " + Pro + " €\n");
                    }
                    else if (syoteTasoMaaritys == 2)
                    {
                        Console.WriteLine("-SemiPro määritys-");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Kirjoita kuukausikohtainen hinta (esim. 25,0):\n");
                        double syotePro = Convert.ToDouble(Console.ReadLine());
                        SemiPro += syotePro;
                        Console.WriteLine("Hinnaksi lisätty " + SemiPro + " €\n");
                    }
                    else if (syoteTasoMaaritys == 3)
                    {
                        Console.WriteLine("-Basic määritys-");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Kirjoita kuukausikohtainen hinta (esim. 25,0):\n");
                        double syotePro = Convert.ToDouble(Console.ReadLine());
                        Basic += syotePro;
                        Console.WriteLine("Hinnaksi lisätty " + Basic + " €\n");
                    }

                }
                else if (valinta == 3)
                {
                    Console.WriteLine("-Tulevat maksut (6kk)-");
                    Console.WriteLine("----------------------\n");


                    double lopputulos = 0.0;

                    // Yksittäiset rahatulot listattuna
                    
                    laskuRekisteri.ForEach(delegate (double lasku)
                    {
                        //Console.WriteLine(lasku);   //debug
                        lopputulos += lasku;
                    });

                    Console.WriteLine("Asiakkaiden nimet: \n");
                    asiakasNimi.ForEach(delegate (string name)
                    {
                        Console.WriteLine(name);
                    });
                    Console.WriteLine("\n");
                    Console.WriteLine("---------------------------\n");
                    Console.WriteLine("-Pro tasot: " + ProCount + " kpl");
                    Console.WriteLine("-SemiPro tasot: " + SemiProCount + " kpl");
                    Console.WriteLine("-Basic tasot: " + BasicCount + " kpl\n");
                    Console.WriteLine("---------------------------\n");
                    Console.WriteLine("Kuukausikohtaiset maksut: " + kkMaksuCount + " kpl");
                    Console.WriteLine("6 kuukauden maksusopimukset: " + SixKKCount + " kpl");
                    Console.WriteLine("12 kuukauden maksusopimukset: " + twelveKKCount + " kpl\n");
                    Console.WriteLine("---------------------------\n");

                    Console.WriteLine("Kaikki laskutettavat yhteensä: " + lopputulos + " €");
                    

                }
                else if(valinta ==4)    // Asiakkaan tason päivitys
                {
                    if (asiakasNro > 0) // jos asiakkaita on
                    {
                        int naytaAsiakkaat = asiakasNro;
                        int asiakasNumero = 1;

                        Console.WriteLine("-Asiakkaan tason päivitys-");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Asiakkaita: " + asiakasNro);
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Valitse asiakas jonka tasoa haluat muokata\n");
                        asiakasNimi.ForEach(delegate (string name)
                        {
                            Console.WriteLine(asiakasNumero + ". " + " " + name);
                            naytaAsiakkaat--;
                            asiakasNumero++;
                        });
                        int asiakasMuokkaus = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-Syötä uusi taso-");
                        Console.WriteLine("-----------------");
                        Console.WriteLine("vaihtoehdot:\n1. Pro\n2. SemiPro\n3. Basic\n");
                        int uusiTaso = Convert.ToInt32(Console.ReadLine());

                        if(uusiTaso == 1)
                        {
                            if(asiakasTaso[asiakasMuokkaus - 1] == "Pro")
                            {
                                ProCount--;
                            }
                            else if(asiakasTaso[asiakasMuokkaus - 1] == "SemiPro")
                            {
                                SemiProCount--;
                            }
                            else if(asiakasTaso[asiakasMuokkaus - 1] == "Basic")
                            {
                                BasicCount--;
                            }
                            asiakasTaso[asiakasMuokkaus - 1] = "Pro";
                            TasoSumma.Insert(asiakasMuokkaus - 1, Pro);
                            laskuRekisteri[asiakasMuokkaus - 1] = 0.0;
                            ProCount++;

                            if(asiakasLaskutus[asiakasMuokkaus - 1] == "Kuukausikohtainen laskutus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcKK(Pro));
                            }
                            else if (asiakasLaskutus[asiakasMuokkaus - 1] == "6kk tilaus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcSix(Pro));
                            }
                            else if (asiakasLaskutus[asiakasMuokkaus - 1] == "12kk tilaus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcTwelve(Pro));
                            }

                        }
                        else if(uusiTaso == 2)
                        {
                            if (asiakasTaso[asiakasMuokkaus - 1] == "Pro")
                            {
                                ProCount--;
                            }
                            else if (asiakasTaso[asiakasMuokkaus - 1] == "SemiPro")
                            {
                                SemiProCount--;
                            }
                            else if (asiakasTaso[asiakasMuokkaus - 1] == "Basic")
                            {
                                BasicCount--;
                            }
                            asiakasTaso[asiakasMuokkaus - 1] = "SemiPro";
                            TasoSumma.Insert(asiakasMuokkaus - 1, SemiPro);
                            laskuRekisteri[asiakasMuokkaus - 1] = 0.0;
                            SemiProCount++;

                            if (asiakasLaskutus[asiakasMuokkaus - 1] == "Kuukausikohtainen laskutus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcKK(SemiPro));
                            }
                            else if (asiakasLaskutus[asiakasMuokkaus - 1] == "6kk tilaus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcSix(SemiPro));
                            }
                            else if (asiakasLaskutus[asiakasMuokkaus - 1] == "12kk tilaus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcTwelve(SemiPro));
                            }
                        }
                        else if (uusiTaso == 3)
                        {
                            if (asiakasTaso[asiakasMuokkaus - 1] == "Pro")
                            {
                                ProCount--;
                            }
                            else if (asiakasTaso[asiakasMuokkaus - 1] == "SemiPro")
                            {
                                SemiProCount--;
                            }
                            else if (asiakasTaso[asiakasMuokkaus - 1] == "Basic")
                            {
                                BasicCount--;
                            }
                            asiakasTaso[asiakasMuokkaus - 1] = "Basic";
                            TasoSumma.Insert(asiakasMuokkaus - 1, Basic);
                            laskuRekisteri[asiakasMuokkaus - 1] = 0.0;
                            BasicCount++;
                            
                            if (asiakasLaskutus[asiakasMuokkaus - 1] == "Kuukausikohtainen laskutus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcKK(Basic));
                            }
                            else if (asiakasLaskutus[asiakasMuokkaus - 1] == "6kk tilaus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcSix(Basic));
                            }
                            else if (asiakasLaskutus[asiakasMuokkaus - 1] == "12kk tilaus")
                            {
                                laskuRekisteri.Insert(asiakasMuokkaus - 1, calcTwelve(Basic));
                            }
                        }


                    }
                    else    // jos asiakkaita ei ole
                    {
                        Console.WriteLine("Asiakkaita ei ole\n");
                    }

                }
               

            }
            while (valinta != 5);

        }
    }
}
