using System;



namespace Palkkalaskenta
{

    class Program
    {
        static void Main(string[] args)
        {

            int työntekijöidenMäärä = 0;
            Tyontekija[] työntekijäLista = new Tyontekija[10000];
            int valinta;

            // Ohjelman valikko
            do
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("PALKANLASKENTASOVELLUKSEN PÄÄVALIKKO");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Valitse toiminto");
                Console.WriteLine("");
                Console.WriteLine("1. Lisää työntekijä");
                Console.WriteLine("2. Näytä työntekijät");
                Console.WriteLine("3. Muokkaa työntekijää");
                Console.WriteLine("4. Tarkastele työntekijän palkkaa");
                Console.WriteLine("5. Lopeta");
                valinta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                // Lisää työntekijä
                if (valinta == 1)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("LISÄÄ TYÖNTEKIJÄ");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Syötä uuden työntekijän nimi");
                    string syötettyNimi = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Syötä uuden työntekijän bruttopalkka");
                    double syötettyPalkka = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    työntekijäLista[työntekijöidenMäärä] = new Tyontekija(syötettyNimi, syötettyPalkka);
                    työntekijöidenMäärä = työntekijöidenMäärä + 1;
                }

                // Näytä työntekijät
                else if (valinta == 2)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("NÄYTÄ TYÖNTEKIJÄT");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("");

                    // Näytetään työntekijät, jos työntekijöitä löytyy
                    if (työntekijöidenMäärä > 0)
                    {
                        Console.WriteLine("Nykyiset työntekijät");
                        Console.WriteLine("");

                        int näytäTyöntekijät = työntekijöidenMäärä;
                        int työntekijäNumero = 1;

                        for (int i = 0; i < työntekijäLista.Length; i++)
                        {
                            if (näytäTyöntekijät > 0)
                            {
                                Console.WriteLine(työntekijäNumero + ". " + työntekijäLista[i].Nimi + ", " + työntekijäLista[i].Palkka + " euroa/kk");
                                näytäTyöntekijät--;
                                työntekijäNumero++;
                            }
                            else
                            {
                                Console.WriteLine("");
                                break;
                            }
                        }
                    }
                    // Jos näytettäviä työntekijöitä ei ole
                    else
                    {
                        Console.WriteLine("Nykyisiä työntekijöitä ei ole");
                        Console.WriteLine("");
                    }
                }

                // Muokkaa työntekijää
                else if (valinta == 3)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("MUOKKAA TYÖNTEKIJÄÄ");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("");

                    // Näytetään työntekijät, jos työntekijöitä löytyy
                    if (työntekijöidenMäärä > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Valitse työntekijä");
                        Console.WriteLine("");

                        int näytäTyöntekijät = työntekijöidenMäärä;
                        int työntekijäNumero = 1;

                        for (int i = 0; i < työntekijäLista.Length; i++)
                        {
                            if (näytäTyöntekijät > 0)
                            {
                                Console.WriteLine(työntekijäNumero + ". " + työntekijäLista[i].Nimi + ", " + työntekijäLista[i].Palkka + " euroa/kk");
                                näytäTyöntekijät--;
                                työntekijäNumero++;
                            }
                            else
                            {
                                Console.WriteLine("");
                                break;
                            }
                        }
                        int muokkausValinta;
                        string nimimuokkaus;
                        double palkkaMuokkaus;

                        Console.WriteLine("Valitse muokattava työntekijä");
                        muokkausValinta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Syötä uusi nimi");
                        nimimuokkaus = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Syötä uusi palkka");
                        palkkaMuokkaus = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        työntekijäLista[muokkausValinta - 1] = new Tyontekija(nimimuokkaus, palkkaMuokkaus);                  

                    }
                    // Jos näytettäviä työntekijöitä ei ole
                    else
                    {
                        Console.WriteLine("Muokattavia työntekijöitä ei ole");
                        Console.WriteLine("");
                    }
                }

                // Tarkastele työntekijän palkan koostumusta
                else if (valinta == 4)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("PALKAN KOOSTUMUS");
                    Console.WriteLine("--------------------");

                    // Suoritetaan jos työntekijöitä on enemmän kuin yksi
                    if (työntekijöidenMäärä > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Valitse työntekijä");
                        Console.WriteLine("");

                        int näytäTyöntekijät = työntekijöidenMäärä;
                        int työntekijäNumero = 1;

                        for (int i = 0; i < työntekijäLista.Length; i++)
                        {
                            if (näytäTyöntekijät > 0)
                            {
                                Console.WriteLine(työntekijäNumero + ". " + työntekijäLista[i].Nimi + ", " + työntekijäLista[i].Palkka + " euroa/kk");
                                näytäTyöntekijät--;
                                työntekijäNumero++;
                            }
                            else
                            {
                                Console.WriteLine("");
                                break;
                            }
                        }

                        int tarkasteluValinta;
                        double ennakkopidatysprosentti;
                        double työeläkemaksu = 0.0715;
                        double työttömyysvakuutusmaksu = 0.0125;

                        Console.WriteLine("Valitse kenen palkkaa haluat tarkastella");
                        tarkasteluValinta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Anna ennakkopidätysprosentti");
                        ennakkopidatysprosentti = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Työntekijä: " + työntekijäLista[tarkasteluValinta - 1].Nimi);
                        Console.WriteLine("");
                        Console.WriteLine("ARVIOLASKELMA");

                        // Kaikki voi halutessaan siirtää omaan luokkaan ja kutsua sitä täältä
                        double bruttopalkka = työntekijäLista[tarkasteluValinta - 1].Palkka;
                        double ennakkopidatysMaara = Math.Round(bruttopalkka * ennakkopidatysprosentti / 100, 2);
                        double tyoelakemaksuMaara = Math.Round(bruttopalkka * työeläkemaksu, 2);
                        double tyottomyysvakuutusmaksu = Math.Round(bruttopalkka * työttömyysvakuutusmaksu, 2);
                        double bruttopalkkaMaara = Math.Round(bruttopalkka - ennakkopidatysMaara - tyoelakemaksuMaara - tyottomyysvakuutusmaksu, 2);

                        Console.WriteLine("-----");
                        Console.WriteLine("Bruttopalkka: " + bruttopalkka + " euroa");                        
                        Console.WriteLine("Ennakkopidätys: " + ennakkopidatysMaara + " euroa");
                        Console.WriteLine("Työeläkemaksu: " + tyoelakemaksuMaara + " euroa");
                        Console.WriteLine("Työttömyysvakuutusmaksu: " + tyottomyysvakuutusmaksu + " euroa");
                        Console.WriteLine("-----");
                        Console.WriteLine("Nettopalkka: " + bruttopalkkaMaara + " euroa");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");

                        // Näytetäänkö työnantajan maksut
                        Console.WriteLine("Näytetäänkö työnantajan maksut");
                        Console.WriteLine("1. Kyllä");
                        Console.WriteLine("2. Ei");
                        int palkantarkasteluvalinta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        if (palkantarkasteluvalinta == 1)
                        {
                            // Kaikki voi halutessaan siirtää omaan luokkaan ja kutsua sitä täältä
                            double tyonantajanTyoelakemaksuMaara = Math.Round(bruttopalkka * 0.1815, 2);
                            double tyonantajanSairasvakuutusmaksuMaara = Math.Round(bruttopalkka * 0.0134, 2);
                            double tyonantajanTyottomyysvakuutusmaksuMaara = Math.Round(bruttopalkka * 0.0045, 2);
                            double sivukulutYhteensa = Math.Round(tyonantajanTyoelakemaksuMaara + tyonantajanSairasvakuutusmaksuMaara + tyonantajanTyottomyysvakuutusmaksuMaara, 2);

                            Console.WriteLine("--------------------");
                            Console.WriteLine("");
                            Console.WriteLine("TYÖNANTAJAN MUUT MAKSUT");
                            Console.WriteLine("-----");
                            Console.WriteLine("Työeläkemaksu " + tyonantajanTyoelakemaksuMaara + " euroa");
                            Console.WriteLine("Sairasvakuutusmaksu " + tyonantajanSairasvakuutusmaksuMaara + " euroa");
                            // En ottanut mukaan muita pakollisia vakuutuksia, koska olisi pitänyt itse syöttää %
                            Console.WriteLine("Työttömyysvakuutusmaksu " + tyonantajanTyottomyysvakuutusmaksuMaara + " euroa");
                            // En ottamut mukaan muita kuluja, koska olisi pitänyt itse syöttää euromäärä
                            Console.WriteLine("-----");
                            Console.WriteLine("Yhteensä: " + sivukulutYhteensa + " euroa");
                            Console.WriteLine("");
                            Console.WriteLine("--------------------");
                            Console.WriteLine("");
                        }
                    }
                    // Suoritetaan, jos työntekijöitä ei ole
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Tarkasteltavia työntekijöitä ei ole");
                        Console.WriteLine("");

                    }
                }
            }
            while (valinta != 5);
        }
    }
}
