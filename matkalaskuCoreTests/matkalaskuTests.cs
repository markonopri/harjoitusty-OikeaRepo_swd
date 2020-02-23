using NUnit.Framework;
using System.Collections.Generic;

namespace matkalaskuCoreTests
{
    public class matkalaskuTests
    {
        [TestFixture]
        public class Tests
        {
            [Test]
            public void KilometrikorvausMatkustajienLukumääräTesti()
            {
                List<double> matkustajienLukumäärä = new List<double>();
                if (matkustajienLukumäärä == null)
                {
                    Assert.IsNull(matkustajienLukumäärä);
                }
                else
                {
                    Assert.IsNotNull(matkustajienLukumäärä);
                }
            }

            [Test]
            public void KilometrikorvausVälimatkaKmTesti()
            {
                List<double> välimatkaKm = new List<double>();
                if (välimatkaKm == null)
                {
                    Assert.IsNull(välimatkaKm);
                }
                else
                {
                    Assert.IsNotNull(välimatkaKm);
                }
            }

            [Test]
            public void PäivärahakorvausAikaTesti()
            {
                List<int> aika = new List<int>();
                Assert.IsNotNull(aika);
                if (aika == null)
                {
                    Assert.IsNull(aika);
                }
                else
                {
                    Assert.IsNotNull(aika);
                }

            }

            [Test]
            public void PäivärahakorvausKmTesti()
            {
                List<int> km = new List<int>();
                Assert.IsNotNull(km);
                if (km == null)
                {
                    Assert.IsNull(km);
                }
                else
                {
                    Assert.IsNotNull(km);
                }
            }

            [Test]
            public void KilometritYli15KmTesti()
            {
                int kilometrit = 16;

                if (kilometrit > 15)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void KilometritAlle15kmTesti()
            {
                int kilometrit = 15;

                if (kilometrit > 15)
                {
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }

            [Test]
            public void KilometritYli15KmJaMinuutitYli360minTesti()
            {
                int kilometrit = 16;
                int minuutit = 361;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 360)
                        {
                            Assert.IsTrue(true);
                            break;
                        }
                        else if (minuutit > 120)
                        {
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
            }

            [Test]
            public void KilometritYli15KmJaMinuutitYli1440minTesti()
            {
                int kilometrit = 16;
                int minuutit = 1441;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            Assert.IsTrue(true);
                            break;
                        }
                        else if (minuutit > 360)
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120)
                        {
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
            }

            [Test]
            public void KilometritYli15KmMuttaMinuutitEiTäytyTesti()
            {
                int kilometrit = 16;
                int minuutit = 119;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 360)
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120)
                        {
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
            public void KilometritAlle15KmMuttaMinuutitYli1440MinTesti()
            {
                int kilometrit = 14;
                int minuutit = 1700;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 360)
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120)
                        {
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
            public void PäivätYli1JaKuusiTuntiaKorvausTesti()
            {
                int päivät = 2;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 1;

                if (päivät > 0 && yliYksiPäiväJaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void PäivätYli1MuttaEiMuitaKorvauksiaTesti()
            {
                int päivät = 54;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;

                if (päivät > 0 && yliYksiPäiväJaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (päivät > 0 && yliYksiPäiväJaKaksiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (päivät > 0)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void PäivärahaKorvausOikeaSummaTesti1()
            {
                int päivät = 6;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 1;
                int kokoPäiväRahaHinta = 43;

                var tulos = (päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKuusiTuntiaKorvaus * kokoPäiväRahaHinta);
                Assert.AreEqual(301, tulos); 
            }

            [Test]
            public void PäivärahaKorvausOikeaSummaTesti2()
            {
                int päivät = 15;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 1;
                int kokoPäiväRahaHinta = 43;
                int osaPäiväRahaHinta = 20;

                var tulos = ((päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKaksiTuntiaKorvaus * osaPäiväRahaHinta));
                Assert.AreEqual(665, tulos);
            }

            [Test]
            public void PäivärahaKorvausOikeaSummaTesti3()
            {
                int päivät = 15;
                int kokoPäiväRahaHinta = 43;

                var tulos = (päivät * kokoPäiväRahaHinta);
                Assert.AreEqual(645, tulos);
            }

            [Test]
            public void PäivärahaKorvausOikeaSummaKaikkienIfElseEhtojenKanssaTesti1()
            {
                int päivät = 5;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 1;
                int kokoPäiväRahaHinta = 43;
                int osaPäiväRahaHinta = 20;


                if (päivät > 0 && yliYksiPäiväJaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (päivät > 0 && yliYksiPäiväJaKaksiTuntiaKorvaus > 0)
                {

                    var tulos = ((päivät * kokoPäiväRahaHinta) + (yliYksiPäiväJaKaksiTuntiaKorvaus * osaPäiväRahaHinta));
                    Assert.IsTrue(true);
                    Assert.AreEqual(235, tulos);

                }
                else if (päivät > 0)
                {
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void PäivärahaKorvausOikeaSummaKaikkienIfElseEhtojenKanssaTesti2()
            {
                int päivät = 0;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;

                if (päivät > 0 && yliYksiPäiväJaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (päivät > 0 && yliYksiPäiväJaKaksiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (päivät > 0)
                {
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }
        }

    }
}