using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometrikorvaus
{
    class Paivarahalaskuri
    {
        public int Paivaraha(int minuutit)
        {
            int kokoPaivaRahaHinta = 43;
            int osaPaivaRahaHinta = 20;
            int paivat = 0;
            int yliYksiPaivaJaKuusiTuntiaKorvaus = 0;
            int yliYksiPaivaJaKaksiTuntiaKorvaus = 0;
            int yliKymmenenTuntiaKorvaus = 0;
            int yliKuusiTuntiaKorvaus = 0;
            int korvauksetYhteensa;

            // Jos päivät yli 1
            if (minuutit > 1440)
            {
                while (true)
                {
                    if (minuutit > 1440)
                    {
                        paivat++;
                        minuutit -= 1440;
                    }
                    else if (minuutit > 360 && paivat >= 1)
                    {
                        yliYksiPaivaJaKuusiTuntiaKorvaus += 1;
                        break;
                    }
                    else if (minuutit > 120 && paivat >= 1)
                    {
                        yliYksiPaivaJaKaksiTuntiaKorvaus += 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Jos päivät alle 1
            if (paivat == 0)
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

            // Palautetaan korvauksien määrä
            if (paivat > 0 && yliYksiPaivaJaKuusiTuntiaKorvaus > 0)
            {
                korvauksetYhteensa = (paivat * kokoPaivaRahaHinta) + (yliKuusiTuntiaKorvaus * kokoPaivaRahaHinta);
                return korvauksetYhteensa;
            }
            else if (paivat > 0 && yliYksiPaivaJaKaksiTuntiaKorvaus > 0)
            {
                korvauksetYhteensa = (paivat * kokoPaivaRahaHinta) + (yliYksiPaivaJaKaksiTuntiaKorvaus * osaPaivaRahaHinta);
                return korvauksetYhteensa;
            }
            else if (paivat > 0)
            {
                korvauksetYhteensa = (paivat * kokoPaivaRahaHinta);
                return korvauksetYhteensa;
            }
            else if (paivat == 0 && yliKymmenenTuntiaKorvaus == 1)
            {
                korvauksetYhteensa = yliKymmenenTuntiaKorvaus * kokoPaivaRahaHinta;
                return korvauksetYhteensa;
            }
            else if (paivat == 0 && yliKuusiTuntiaKorvaus == 1)
            {
                korvauksetYhteensa = yliKuusiTuntiaKorvaus * osaPaivaRahaHinta;
                return korvauksetYhteensa;
            }
            else
            {
                return 0;
            }
        }
    }
}
