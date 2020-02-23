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
            public void KilometrikorvausMatkustajienLukum‰‰r‰Testi()
            {
                List<double> matkustajienLukum‰‰r‰ = new List<double>();
                if (matkustajienLukum‰‰r‰ == null)
                {
                    Assert.IsNull(matkustajienLukum‰‰r‰);
                }
                else
                {
                    Assert.IsNotNull(matkustajienLukum‰‰r‰);
                }
            }

            [Test]
            public void KilometrikorvausV‰limatkaKmTesti()
            {
                List<double> v‰limatkaKm = new List<double>();
                if (v‰limatkaKm == null)
                {
                    Assert.IsNull(v‰limatkaKm);
                }
                else
                {
                    Assert.IsNotNull(v‰limatkaKm);
                }
            }

            [Test]
            public void P‰iv‰rahakorvausAikaTesti()
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
            public void P‰iv‰rahakorvausKmTesti()
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
            public void KilometritYli15KmMuttaMinuutitEiT‰ytyTesti()
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
            public void P‰iv‰tYli1JaKuusiTuntiaKorvausTesti()
            {
                int p‰iv‰t = 2;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 1;

                if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void P‰iv‰tYli1MuttaEiMuitaKorvauksiaTesti()
            {
                int p‰iv‰t = 54;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 0;

                if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKaksiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (p‰iv‰t > 0)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void P‰iv‰rahaKorvausOikeaSummaTesti1()
            {
                int p‰iv‰t = 6;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 1;
                int kokoP‰iv‰RahaHinta = 43;

                var tulos = (p‰iv‰t * kokoP‰iv‰RahaHinta) + (yliYksiP‰iv‰JaKuusiTuntiaKorvaus * kokoP‰iv‰RahaHinta);
                Assert.AreEqual(301, tulos); 
            }

            [Test]
            public void P‰iv‰rahaKorvausOikeaSummaTesti2()
            {
                int p‰iv‰t = 15;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 1;
                int kokoP‰iv‰RahaHinta = 43;
                int osaP‰iv‰RahaHinta = 20;

                var tulos = ((p‰iv‰t * kokoP‰iv‰RahaHinta) + (yliYksiP‰iv‰JaKaksiTuntiaKorvaus * osaP‰iv‰RahaHinta));
                Assert.AreEqual(665, tulos);
            }

            [Test]
            public void P‰iv‰rahaKorvausOikeaSummaTesti3()
            {
                int p‰iv‰t = 15;
                int kokoP‰iv‰RahaHinta = 43;

                var tulos = (p‰iv‰t * kokoP‰iv‰RahaHinta);
                Assert.AreEqual(645, tulos);
            }

            [Test]
            public void P‰iv‰rahaKorvausOikeaSummaKaikkienIfElseEhtojenKanssaTesti1()
            {
                int p‰iv‰t = 5;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 1;
                int kokoP‰iv‰RahaHinta = 43;
                int osaP‰iv‰RahaHinta = 20;


                if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKaksiTuntiaKorvaus > 0)
                {

                    var tulos = ((p‰iv‰t * kokoP‰iv‰RahaHinta) + (yliYksiP‰iv‰JaKaksiTuntiaKorvaus * osaP‰iv‰RahaHinta));
                    Assert.IsTrue(true);
                    Assert.AreEqual(235, tulos);

                }
                else if (p‰iv‰t > 0)
                {
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }

            [Test]
            public void P‰iv‰rahaKorvausOikeaSummaKaikkienIfElseEhtojenKanssaTesti2()
            {
                int p‰iv‰t = 0;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 0;

                if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKuusiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (p‰iv‰t > 0 && yliYksiP‰iv‰JaKaksiTuntiaKorvaus > 0)
                {
                    Assert.IsTrue(false);
                }
                else if (p‰iv‰t > 0)
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