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
            public void YliYksiP‰iv‰JaKuusiTuntiaTesti()
            {
                int p‰iv‰t = 3;
                int kuusiTuntia = 1;
                int kokoP‰iv‰RahaHinta = 43;

                var tulos = (p‰iv‰t * kokoP‰iv‰RahaHinta) + (kuusiTuntia * kokoP‰iv‰RahaHinta);
                Assert.AreEqual(172, tulos);
            }
            [Test]
            public void YliYksiP‰iv‰JaKaksiTuntiaTesti()
            {
                int p‰iv‰t = 8;
                int kaksiTuntia = 1;
                int osaP‰iv‰RahaHinta = 20;
                int kokoP‰iv‰RahaHinta = 43;

                var tulos = (p‰iv‰t * kokoP‰iv‰RahaHinta) + (kaksiTuntia * osaP‰iv‰RahaHinta);
                Assert.AreEqual(364, tulos);
            }
            [Test]
            public void YliYksiP‰iv‰MutteiMuutaTesti()
            {
                int p‰iv‰t = 6;
                int kokoP‰iv‰RahaHinta = 43;

                var tulos = (p‰iv‰t * kokoP‰iv‰RahaHinta);
                Assert.AreEqual(258, tulos);
            }
            [Test]
            public void AlleP‰iv‰MuttaYliKymmenenTuntiaTesti()
            {
                int kokoP‰iv‰RahaHinta = 43;
                int yliKymmenenTuntia = 1;

                var tulos = (yliKymmenenTuntia * kokoP‰iv‰RahaHinta);
                Assert.AreEqual(43, tulos);
            }
            [Test]
            public void AlleP‰iv‰MuttaYliKuusiTuntiaTest()
            {
                int osaP‰iv‰RahaHinta = 20;
                int yliKuusiTuntia = 1;

                var tulos = yliKuusiTuntia * osaP‰iv‰RahaHinta;
                Assert.AreEqual(20, tulos);
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
                int kilometrit = 12;

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
            public void P‰iv‰JaAikaJosP‰ivi‰YliYksiJaKilometrej‰Yli15Testi1()
            {
                int kilometrit = 16;
                int minuutit = 3241;
                int p‰iv‰t = 0;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            p‰iv‰t++;
                            minuutit -= 1440;
                            Assert.IsTrue(true);
                        }
                        else if (minuutit > 360 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(true);
                            break;
                        }
                        else if (minuutit > 120 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                    }
                    Assert.AreEqual(2, p‰iv‰t);
                    Assert.AreEqual(1, yliYksiP‰iv‰JaKuusiTuntiaKorvaus);
                    Assert.AreEqual(0, yliYksiP‰iv‰JaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void P‰iv‰JaAikaJosP‰ivi‰YliYksiJaKilometrej‰Yli15Testi2()
            {
                int kilometrit = 16;
                int minuutit = 7201;
                int p‰iv‰t = 0;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            p‰iv‰t++;
                            minuutit -= 1440;
                            Assert.IsTrue(true);
                        }
                        else if (minuutit > 360 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(true);
                            break;
                        }
                    }
                    Assert.AreEqual(5, p‰iv‰t);
                    Assert.AreEqual(0, yliYksiP‰iv‰JaKuusiTuntiaKorvaus);
                    Assert.AreEqual(0, yliYksiP‰iv‰JaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void P‰iv‰JaAikaJosP‰ivi‰YliYksiJaKilometrej‰Yli15Testi3()
            {
                int kilometrit = 16;
                int minuutit = 7321;
                int p‰iv‰t = 0;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            p‰iv‰t++;
                            minuutit -= 1440;
                            Assert.IsTrue(true);
                        }
                        else if (minuutit > 360 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(true);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                    }
                    Assert.AreEqual(5, p‰iv‰t);
                    Assert.AreEqual(0, yliYksiP‰iv‰JaKuusiTuntiaKorvaus);
                    Assert.AreEqual(1, yliYksiP‰iv‰JaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void P‰iv‰JaAikaJosP‰ivi‰YliYksiMuttaKilometrej‰Alle15Testi()
            {
                int kilometrit = 14;
                int minuutit = 7321;
                int p‰iv‰t = 0;
                int yliYksiP‰iv‰JaKuusiTuntiaKorvaus = 0;
                int yliYksiP‰iv‰JaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            p‰iv‰t++;
                            minuutit -= 1440;
                            Assert.IsTrue(false);
                        }
                        else if (minuutit > 360 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120 && p‰iv‰t >= 1)
                        {
                            yliYksiP‰iv‰JaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                    }
                    Assert.AreEqual(0, p‰iv‰t);
                    Assert.AreEqual(0, yliYksiP‰iv‰JaKuusiTuntiaKorvaus);
                    Assert.AreEqual(0, yliYksiP‰iv‰JaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void AikaJosP‰ivi‰AlleNollaJaKilometrej‰Yli15Testi1()
            {
                int kilometrit = 16;
                int p‰iv‰t = 0;
                int minuutit = 601;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && p‰iv‰t == 0)
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
                Assert.AreEqual(0, p‰iv‰t);
                Assert.AreEqual(1, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(0, yliKuusiTuntiaKorvaus);
            }
            [Test]
            public void AikaJosP‰ivi‰AlleNollaJaKilometrej‰Yli15Testi2()
            {
                int kilometrit = 16;
                int p‰iv‰t = 0;
                int minuutit = 368;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && p‰iv‰t == 0)
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
                Assert.AreEqual(0, p‰iv‰t);
                Assert.AreEqual(0, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(1, yliKuusiTuntiaKorvaus);
            }
            [Test]
            public void AikaJosP‰ivi‰AlleNollaJaKilometrej‰Yli15Testi3()
            {
                int kilometrit = 16;
                int p‰iv‰t = 0;
                int minuutit = 355;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && p‰iv‰t == 0)
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
                Assert.AreEqual(0, p‰iv‰t);
                Assert.AreEqual(0, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(0, yliKuusiTuntiaKorvaus);
            }
            [Test]
            public void AikaJosP‰ivi‰YliYksiEik‰NollaJaKilometrej‰Yli15Testi()
            {
                int kilometrit = 16;
                int p‰iv‰t = 4;
                int minuutit = 660;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && p‰iv‰t == 0)
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
                Assert.AreEqual(4, p‰iv‰t);
                Assert.AreEqual(0, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(0, yliKuusiTuntiaKorvaus);
            }
        }
    }
}