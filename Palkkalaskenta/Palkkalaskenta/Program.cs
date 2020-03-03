using System;



namespace Palkkalaskenta
{

    class Program
    {
        static void Main(string[] args)
        {

            int työntekijöidenMäärä = 0;
            Tyontekija[] työntekijäLista = new Tyontekija[1000];
            int valinta;

            do
            {
                Console.WriteLine("1. Lisää työntekijä");
                Console.WriteLine("2. Näytä työntekijät");
                Console.WriteLine("3. Tarkastele työntekijän palkan koostumusta");
                Console.WriteLine("4. Lopeta");
                valinta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                // Lisää työntekijä
                if (valinta == 1)
                {
                    Console.WriteLine("Lisää työntekijä ja bruttopalkka");
                    Console.WriteLine("Anna nimi");
                    string syötettyNimi = Console.ReadLine();
                    Console.WriteLine("Anna bruttopalkka");
                    int syötettyPalkka = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    työntekijäLista[työntekijöidenMäärä] = new Tyontekija(syötettyNimi, syötettyPalkka);
                    työntekijöidenMäärä = työntekijöidenMäärä + 1;
                }

                // Näytä työntekijät
                if (valinta == 2)
                {
                    if (työntekijöidenMäärä > 0)
                    {
                        int näytäTyöntekijät = työntekijöidenMäärä;
                        int työntekijäNumero = 1;

                        Console.WriteLine("Nykyiset työntekijät");
                        for (int i = 0; i < työntekijäLista.Length; i++)
                        {
                            if (näytäTyöntekijät > 0)
                            {
                                Console.WriteLine(työntekijäNumero + ". " + työntekijäLista[i].Nimi + ", " + työntekijäLista[i].Palkka + " euroa/kk");
                                näytäTyöntekijät--;
                            }
                            else
                            {
                                Console.WriteLine("");
                                break;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Ei työntekijöitä");
                        Console.WriteLine("");
                    }
                }
                // Tarkastele työntekijän palkan koostumusta
                if (valinta == 3)
                {
                    Console.WriteLine("Työntekijän palkan koostumus");
                    Console.WriteLine("Valitse työntekijän");

                    if (työntekijöidenMäärä > 0)
                    {
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
                    else
                    {
                        Console.WriteLine("Ei työntekijöitä");
                        Console.WriteLine("");
                    }

                    int tarkasteluValinta;
                    double ennakkopidatysprosentti;
                    double työeläkemaksu = 0.065;
                    double työttömyysvakuutusmaksu = 0.015;

                    Console.WriteLine("Kenen palkkaa haluat tarkastella?");
                    tarkasteluValinta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Anna ennakkopidätysprosentti");
                    ennakkopidatysprosentti = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Valintasi: " + työntekijäLista[tarkasteluValinta - 1].Nimi);
                    Console.WriteLine("");
                    Console.WriteLine("ARVIOLASKELMA");

                    int bruttopalkka = työntekijäLista[tarkasteluValinta - 1].Palkka;

                    Console.WriteLine("Bruttopalkka: " + bruttopalkka);
                    Console.WriteLine("Ennakkopidätys: " + bruttopalkka * ennakkopidatysprosentti / 100);
                    Console.WriteLine("Työeläkemaksu: " + bruttopalkka * työeläkemaksu);
                    Console.WriteLine("Työttömyysvakuutusmaksu: " + bruttopalkka * työttömyysvakuutusmaksu);
                    Console.WriteLine("-----");
                    Console.WriteLine("Nettopalkka: " + Math.Round((bruttopalkka - (bruttopalkka * ennakkopidatysprosentti / 100) - (bruttopalkka * työeläkemaksu) - (bruttopalkka * työttömyysvakuutusmaksu)), 2));
                    Console.WriteLine("");

                }
            }
            while (valinta != 4);

        }
    }
}
