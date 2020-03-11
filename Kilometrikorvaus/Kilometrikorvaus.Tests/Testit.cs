using NUnit.Framework;

namespace Kilometrikorvaus.Tests
{
    [TestFixture]
    public class Tests
    {
        // Testit hieman irrallaan ohjelmasta, mutta käytännössä sama koodi kuin ohjelmassa

        [Test]
        public void JosPaiviaYli1Testi1()
        {
            int paivat = 0;
            int yliYksiPaivaJaKuusiTuntiaKorvaus = 0;
            int yliYksiPaivaJaKaksiTuntiaKorvaus = 0;
            int minuutit = 1441;

            if (minuutit > 1440)
            {
                while (true)
                {
                    if (minuutit > 1440)
                    {
                        paivat++;
                        minuutit -= 1440;
                        Assert.IsTrue(true);
                    }
                    else if (minuutit > 360 && paivat >= 1)
                    {
                        yliYksiPaivaJaKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else if (minuutit > 120 && paivat >= 1)
                    {
                        yliYksiPaivaJaKaksiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(true);
                        break;
                    }
                }
            }
        }

        [Test]
        public void JosPaiviaYli1Testi2()
        {
            int paivat = 0;
            int yliYksiPaivaJaKuusiTuntiaKorvaus = 0;
            int yliYksiPaivaJaKaksiTuntiaKorvaus = 0;
            int minuutit = 361;

            if (minuutit > 1440)
            {
                while (true)
                {
                    if (minuutit > 1440)
                    {
                        paivat++;
                        minuutit -= 1440;
                        Assert.IsTrue(false);
                    }
                    else if (minuutit > 360 && paivat >= 1)
                    {
                        yliYksiPaivaJaKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(true);
                        break;
                    }
                    else if (minuutit > 120 && paivat >= 1)
                    {
                        yliYksiPaivaJaKaksiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(true);
                        break;
                    }
                }
            }
        }

        [Test]
        public void JosPaiviaYli1Testi3()
        {
            int paivat = 0;
            int yliYksiPaivaJaKuusiTuntiaKorvaus = 0;
            int yliYksiPaivaJaKaksiTuntiaKorvaus = 0;
            int minuutit = 121;

            if (minuutit > 1440)
            {
                while (true)
                {
                    if (minuutit > 1440)
                    {
                        paivat++;
                        minuutit -= 1440;
                        Assert.IsTrue(false);
                    }
                    else if (minuutit > 360 && paivat >= 1)
                    {
                        yliYksiPaivaJaKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else if (minuutit > 120 && paivat >= 1)
                    {
                        yliYksiPaivaJaKaksiTuntiaKorvaus += 1;
                        Assert.IsTrue(true);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(true);
                        break;
                    }
                }
            }
        }

        [Test]
        public void JosPaiviaYli1Testi4()
        {
            int paivat = 0;
            int yliYksiPaivaJaKuusiTuntiaKorvaus = 0;
            int yliYksiPaivaJaKaksiTuntiaKorvaus = 0;
            int minuutit = 1440;

            if (minuutit > 1440)
            {
                while (true)
                {
                    if (minuutit > 1440)
                    {
                        paivat++;
                        minuutit -= 1440;
                        Assert.IsTrue(false);
                    }
                    else if (minuutit > 360 && paivat >= 1)
                    {
                        yliYksiPaivaJaKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else if (minuutit > 120 && paivat >= 1)
                    {
                        yliYksiPaivaJaKaksiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(true);
                        break;
                    }
                }
            }
        }

        [Test]
        public void JosPaiviaYli1NiinEhtoEiToteuduTesti1()
        {
            int paivat = 1;
            int yliKymmenenTuntiaKorvaus = 0;
            int yliKuusiTuntiaKorvaus = 0;
            int minuutit = 1440;

            if (paivat == 0)
            {
                while (true)
                {
                    if (minuutit > 600)
                    {
                        yliKymmenenTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else if (minuutit > 360)
                    {
                        yliKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(false);
                        break;
                    }
                }
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [Test]
        public void JosPaiviaAlle1Testi1()
        {
            int paivat = 0;
            int yliKymmenenTuntiaKorvaus = 0;
            int yliKuusiTuntiaKorvaus = 0;
            int minuutit = 1440;

            if (paivat == 0)
            {
                while (true)
                {
                    if (minuutit > 600)
                    {
                        yliKymmenenTuntiaKorvaus += 1;
                        Assert.IsTrue(true);
                        break;
                    }
                    else if (minuutit > 360)
                    {
                        yliKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(false);
                        break;
                    }
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void JosPaiviaAlle1Testi2()
        {
            int paivat = 0;
            int yliKymmenenTuntiaKorvaus = 0;
            int yliKuusiTuntiaKorvaus = 0;
            int minuutit = 361;

            if (paivat == 0)
            {
                while (true)
                {
                    if (minuutit > 600)
                    {
                        yliKymmenenTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else if (minuutit > 360)
                    {
                        yliKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(true);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(false);
                        break;
                    }
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void JosPaiviaAlle1Testi3()
        {
            int paivat = 0;
            int yliKymmenenTuntiaKorvaus = 0;
            int yliKuusiTuntiaKorvaus = 0;
            int minuutit = 60;

            if (paivat == 0)
            {
                while (true)
                {
                    if (minuutit > 600)
                    {
                        yliKymmenenTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else if (minuutit > 360)
                    {
                        yliKuusiTuntiaKorvaus += 1;
                        Assert.IsTrue(false);
                        break;
                    }
                    else
                    {
                        Assert.IsTrue(true);
                        break;
                    }
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void KorvauksetOikeinYli1PaivaJaKuusiTuntiaTesti()
        {
            int kokoPaivaRahaHinta = 43;
            int paivat = 3;
            int yliYksiPaivaJaKuusiTuntiaKorvaus = 1;
            int korvauksetYhteensa;

            if (paivat > 0 && yliYksiPaivaJaKuusiTuntiaKorvaus > 0)
            {
                korvauksetYhteensa = (paivat * kokoPaivaRahaHinta) + (yliYksiPaivaJaKuusiTuntiaKorvaus * kokoPaivaRahaHinta);
                Assert.AreEqual(172, korvauksetYhteensa);
            }
        }

        [Test]
        public void KorvauksetOikeinYli1PaivaJaKaksiTuntiaTesti()
        {
            int kokoPaivaRahaHinta = 43;
            int osaPaivaRahaHinta = 20;
            int paivat = 7;
            int yliYksiPaivaJaKaksiTuntiaKorvaus = 1;
            int korvauksetYhteensa;

            if (paivat > 0 && yliYksiPaivaJaKaksiTuntiaKorvaus > 0)
            {
                korvauksetYhteensa = (paivat * kokoPaivaRahaHinta) + (yliYksiPaivaJaKaksiTuntiaKorvaus * osaPaivaRahaHinta);
                Assert.AreEqual(321, korvauksetYhteensa);
            }
        }

        [Test]
        public void PaivatYli1MutteiMuutaTesti()
        {
            int kokoPaivaRahaHinta = 43;
            int paivat = 70;
            int korvauksetYhteensa;

            if (paivat > 0)
            {
                korvauksetYhteensa = (paivat * kokoPaivaRahaHinta);
                Assert.AreEqual(3010, korvauksetYhteensa);
            }
        }

        [Test]
        public void PaivatAlle1MuttaYliKymmenenTuntiaKorvausTesti()
        {
            int kokoPaivaRahaHinta = 43;
            int korvauksetYhteensa;
            int paivat = 0;
            int yliKymmenenTuntiaKorvaus = 1;

            if (paivat == 0 && yliKymmenenTuntiaKorvaus == 1)
            {
                korvauksetYhteensa = yliKymmenenTuntiaKorvaus * kokoPaivaRahaHinta;
                Assert.AreEqual(43, korvauksetYhteensa);
            }
        }

        [Test]
        public void PaivatAlle1MuttaYliKuusiTuntiaKorvausTesti()
        {
            int osaPaivaRahaHinta = 20;
            int korvauksetYhteensa;
            int paivat = 0;
            int yliKuusiTuntiaKorvaus = 1;

            if (paivat == 0 && yliKuusiTuntiaKorvaus == 1)
            {
                korvauksetYhteensa = yliKuusiTuntiaKorvaus * osaPaivaRahaHinta;
                Assert.AreEqual(20, korvauksetYhteensa);
            }
        }


    }
}