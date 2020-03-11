using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometrikorvaus
{
    class Program
    {
        static void Main(string[] args)
        {

            int myyntiedustajienMaara = 0;
            Myyntiedustaja[] myyntiedustajaLista = new Myyntiedustaja[10000];
            int valinta;
            int valinta2;

            // Ohjelman valikko
            do
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("KILOMETRIKORVAUSSOVELLUKSEN PÄÄVALIKKO");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Valitse toiminto");
                Console.WriteLine("");
                Console.WriteLine("1. Lisää myyntiedustaja");
                Console.WriteLine("2. Lisää matkakulu");
                Console.WriteLine("3. Näytä myyntiedustajien matkakulut");
                Console.WriteLine("4. Lopeta ohjelma");
                valinta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                // Lisää myyntiedustaja
                if (valinta == 1)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("LISÄÄ MYYNTIEDUSTAJA");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Syötä uuden myyntiedustajan nimi");
                    string syotettyNimi = Console.ReadLine();
                    Console.WriteLine("");

                    myyntiedustajaLista[myyntiedustajienMaara] = new Myyntiedustaja(syotettyNimi, 0, "");
                    myyntiedustajienMaara = myyntiedustajienMaara + 1;
                }

                // Lisää matkakuluja
                else if (valinta == 2)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("LISÄÄ MATKAKULU");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("");

                    // Näytetään myyntiedustajat, jos niitä löytyy
                    if (myyntiedustajienMaara > 0)
                    {
                        Console.WriteLine("Valitse myyntiedustaja");
                        Console.WriteLine("");

                        int naytaMyyntiedustajat = myyntiedustajienMaara;
                        int myyntiedustajaNumero = 1;

                        for (int i = 0; i < myyntiedustajaLista.Length; i++)
                        {
                            if (naytaMyyntiedustajat > 0)
                            {
                                Console.WriteLine(myyntiedustajaNumero + ". " + myyntiedustajaLista[i].Nimi);
                                myyntiedustajaNumero++;
                                naytaMyyntiedustajat--;
                            }
                            else
                            {
                                Console.WriteLine("");
                                break;
                            }
                        }

                        int myyntiedustajaValinta;
                        double uusiMatkakuluSumma;
                    
                        Console.WriteLine("Valitse myyntiedustaja");
                        myyntiedustajaValinta = Convert.ToInt32(Console.ReadLine());

                        if (myyntiedustajaValinta > myyntiedustajienMaara)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Syötä matkan päivämäärä (dd.mm.yyyy)");
                            string paivamaaraSyote = Console.ReadLine();

                            Console.WriteLine("");
                            Console.WriteLine("Syötä matkakulujen summa");
                            string matkakuluString = Console.ReadLine();
                            double matkakuluSyote = Convert.ToDouble(matkakuluString);

                            string matkakululistaSyote = myyntiedustajaLista[myyntiedustajaValinta - 1].Matkakululistaus + "," + "Päivämäärä: " + paivamaaraSyote + " | Matkakulu: " + matkakuluSyote + " euroa";

                            uusiMatkakuluSumma = myyntiedustajaLista[myyntiedustajaValinta - 1].Matkakulut + matkakuluSyote;

                            Console.WriteLine("");

                            string edustajanNimi = myyntiedustajaLista[myyntiedustajaValinta - 1].Nimi;

                            myyntiedustajaLista[myyntiedustajaValinta - 1] = new Myyntiedustaja(edustajanNimi, uusiMatkakuluSumma, matkakululistaSyote);

                        }
                    }

                    else
                    {
                        Console.WriteLine("Myyntiedustajia ei ole");
                        Console.WriteLine("");
                    }
                }

                // Näytä myyntiedustajat matkakuluineen
                else if (valinta == 3)
                {
                    do
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("MYYNTIEDUSTAJIEN MATKAKULUT");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Valitse toiminto");
                        Console.WriteLine("");
                        Console.WriteLine("1. Yhteenveto myyntiedustajista");
                        Console.WriteLine("2. Tarkastele yksittäistä myyntiedustajaa");
                        Console.WriteLine("3. Palaa etusivulle");
                        valinta2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        // Yhteenveto myyntiedustajista
                        if (valinta2 == 1)
                        {
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("MYYNTIEDUSTAJIEN MATKAKULUT");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("");

                            int naytaMyyntiedustajat = myyntiedustajienMaara;
                            int myyntiedustajaNumero = 1;

                            if (naytaMyyntiedustajat > 0)
                            {
                                Console.WriteLine("Myyntiedustajat matkakuluineen");
                                Console.WriteLine("");

                                for (int i = 0; i < myyntiedustajaLista.Length; i++)
                                {
                                    if (naytaMyyntiedustajat > 0)
                                    {
                                        Console.WriteLine(myyntiedustajaNumero + ". " + myyntiedustajaLista[i].Nimi + "  " + myyntiedustajaLista[i].Matkakulut + " euroa");
                                        myyntiedustajaNumero++;
                                        naytaMyyntiedustajat--;
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
                                Console.WriteLine("Myyntiedustajia ei ole");
                                Console.WriteLine("");
                            }
                        }

                        // Yksittäinen myyntiedustaja
                        else if (valinta2 == 2)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("YKSITTÄISEN MYYNTIEDUSTAJAN MATKAKULUT");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("");

                            // Näytetään myyntiedustajat, jos niitä löytyy
                            if (myyntiedustajienMaara > 0)
                            {
                                Console.WriteLine("Valitse myyntiedustaja");
                                Console.WriteLine("");

                                int naytaMyyntiedustajat = myyntiedustajienMaara;
                                int myyntiedustajaNumero = 1;

                                for (int i = 0; i < myyntiedustajaLista.Length; i++)
                                {
                                    if (naytaMyyntiedustajat > 0)
                                    {
                                        Console.WriteLine(myyntiedustajaNumero + ". " + myyntiedustajaLista[i].Nimi);
                                        myyntiedustajaNumero++;
                                        naytaMyyntiedustajat--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        break;
                                    }
                                }

                                int myyntiedustajaValinta;

                                Console.WriteLine("Valitse myyntiedustaja");
                                myyntiedustajaValinta = Convert.ToInt32(Console.ReadLine());

                                if (myyntiedustajaValinta > myyntiedustajienMaara)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                                    Console.WriteLine("");
                                }
                                else
                                { 
                                    Console.WriteLine("");
                                    Console.WriteLine("////////////////////////////////////////");
                                    Console.WriteLine("");
                                    Console.WriteLine("Myyntiedustaja: " + myyntiedustajaLista[myyntiedustajaValinta - 1].Nimi);
                                    Console.WriteLine("Matkakorvauksia yhteensä: " + myyntiedustajaLista[myyntiedustajaValinta - 1].Matkakulut + " euroa");
                                    
                                    string merkkijono = myyntiedustajaLista[myyntiedustajaValinta - 1].Matkakululistaus;
                                    string[] kulut = merkkijono.Split(',');

                                    Console.WriteLine("");
                                    Console.WriteLine("----------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Matkakulut listattuna: ");
                                    foreach (var kulu in kulut)
                                    {
                                        Console.WriteLine(kulu);
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("----------");

                                    Console.WriteLine("");
                                    Console.WriteLine("////////////////////////////////////////");
                                    Console.WriteLine("");



                                }



                            }




                        }

                    }
                    while (valinta2 != 3);

                }

            }
            while (valinta != 4);

        }
    }
}
