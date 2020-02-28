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
            public void YliYksiPäiväJaKuusiTuntiaTesti()
            {
                int päivät = 3;
                int kuusiTuntia = 1;
                int kokoPäiväRahaHinta = 43;

                var tulos = (päivät * kokoPäiväRahaHinta) + (kuusiTuntia * kokoPäiväRahaHinta);
                Assert.AreEqual(172, tulos);
            }
            [Test]
            public void YliYksiPäiväJaKaksiTuntiaTesti()
            {
                int päivät = 8;
                int kaksiTuntia = 1;
                int osaPäiväRahaHinta = 20;
                int kokoPäiväRahaHinta = 43;

                var tulos = (päivät * kokoPäiväRahaHinta) + (kaksiTuntia * osaPäiväRahaHinta);
                Assert.AreEqual(364, tulos);
            }
            [Test]
            public void YliYksiPäiväMutteiMuutaTesti()
            {
                int päivät = 6;
                int kokoPäiväRahaHinta = 43;

                var tulos = (päivät * kokoPäiväRahaHinta);
                Assert.AreEqual(258, tulos);
            }
            [Test]
            public void AllePäiväMuttaYliKymmenenTuntiaTesti()
            {
                int kokoPäiväRahaHinta = 43;
                int yliKymmenenTuntia = 1;

                var tulos = (yliKymmenenTuntia * kokoPäiväRahaHinta);
                Assert.AreEqual(43, tulos);
            }
            [Test]
            public void AllePäiväMuttaYliKuusiTuntiaTest()
            {
                int osaPäiväRahaHinta = 20;
                int yliKuusiTuntia = 1;

                var tulos = yliKuusiTuntia * osaPäiväRahaHinta;
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
            public void PäiväJaAikaJosPäiviäYliYksiJaKilometrejäYli15Testi1()
            {
                int kilometrit = 16;
                int minuutit = 3241;
                int päivät = 0;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            päivät++;
                            minuutit -= 1440;
                            Assert.IsTrue(true);
                        }
                        else if (minuutit > 360 && päivät >= 1)
                        {
                            yliYksiPäiväJaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(true);
                            break;
                        }
                        else if (minuutit > 120 && päivät >= 1)
                        {
                            yliYksiPäiväJaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                    }
                    Assert.AreEqual(2, päivät);
                    Assert.AreEqual(1, yliYksiPäiväJaKuusiTuntiaKorvaus);
                    Assert.AreEqual(0, yliYksiPäiväJaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void PäiväJaAikaJosPäiviäYliYksiJaKilometrejäYli15Testi2()
            {
                int kilometrit = 16;
                int minuutit = 7201;
                int päivät = 0;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            päivät++;
                            minuutit -= 1440;
                            Assert.IsTrue(true);
                        }
                        else if (minuutit > 360 && päivät >= 1)
                        {
                            yliYksiPäiväJaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120 && päivät >= 1)
                        {
                            yliYksiPäiväJaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(true);
                            break;
                        }
                    }
                    Assert.AreEqual(5, päivät);
                    Assert.AreEqual(0, yliYksiPäiväJaKuusiTuntiaKorvaus);
                    Assert.AreEqual(0, yliYksiPäiväJaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void PäiväJaAikaJosPäiviäYliYksiJaKilometrejäYli15Testi3()
            {
                int kilometrit = 16;
                int minuutit = 7321;
                int päivät = 0;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            päivät++;
                            minuutit -= 1440;
                            Assert.IsTrue(true);
                        }
                        else if (minuutit > 360 && päivät >= 1)
                        {
                            yliYksiPäiväJaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120 && päivät >= 1)
                        {
                            yliYksiPäiväJaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(true);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                    }
                    Assert.AreEqual(5, päivät);
                    Assert.AreEqual(0, yliYksiPäiväJaKuusiTuntiaKorvaus);
                    Assert.AreEqual(1, yliYksiPäiväJaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void PäiväJaAikaJosPäiviäYliYksiMuttaKilometrejäAlle15Testi()
            {
                int kilometrit = 14;
                int minuutit = 7321;
                int päivät = 0;
                int yliYksiPäiväJaKuusiTuntiaKorvaus = 0;
                int yliYksiPäiväJaKaksiTuntiaKorvaus = 0;

                if (kilometrit > 15)
                {
                    while (true)
                    {
                        if (minuutit > 1440)
                        {
                            päivät++;
                            minuutit -= 1440;
                            Assert.IsTrue(false);
                        }
                        else if (minuutit > 360 && päivät >= 1)
                        {
                            yliYksiPäiväJaKuusiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else if (minuutit > 120 && päivät >= 1)
                        {
                            yliYksiPäiväJaKaksiTuntiaKorvaus += 1;
                            Assert.IsTrue(false);
                            break;
                        }
                        else
                        {
                            Assert.IsTrue(false);
                            break;
                        }
                    }
                    Assert.AreEqual(0, päivät);
                    Assert.AreEqual(0, yliYksiPäiväJaKuusiTuntiaKorvaus);
                    Assert.AreEqual(0, yliYksiPäiväJaKaksiTuntiaKorvaus);
                }
            }
            [Test]
            public void AikaJosPäiviäAlleNollaJaKilometrejäYli15Testi1()
            {
                int kilometrit = 16;
                int päivät = 0;
                int minuutit = 601;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && päivät == 0)
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
                Assert.AreEqual(0, päivät);
                Assert.AreEqual(1, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(0, yliKuusiTuntiaKorvaus);
            }
            [Test]
            public void AikaJosPäiviäAlleNollaJaKilometrejäYli15Testi2()
            {
                int kilometrit = 16;
                int päivät = 0;
                int minuutit = 368;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && päivät == 0)
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
                Assert.AreEqual(0, päivät);
                Assert.AreEqual(0, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(1, yliKuusiTuntiaKorvaus);
            }
            [Test]
            public void AikaJosPäiviäAlleNollaJaKilometrejäYli15Testi3()
            {
                int kilometrit = 16;
                int päivät = 0;
                int minuutit = 355;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && päivät == 0)
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
                Assert.AreEqual(0, päivät);
                Assert.AreEqual(0, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(0, yliKuusiTuntiaKorvaus);
            }
            [Test]
            public void AikaJosPäiviäYliYksiEikäNollaJaKilometrejäYli15Testi()
            {
                int kilometrit = 16;
                int päivät = 4;
                int minuutit = 660;
                int yliKymmenenTuntiaKorvaus = 0;
                int yliKuusiTuntiaKorvaus = 0;

                if (kilometrit > 15 && päivät == 0)
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
                Assert.AreEqual(4, päivät);
                Assert.AreEqual(0, yliKymmenenTuntiaKorvaus);
                Assert.AreEqual(0, yliKuusiTuntiaKorvaus);
            }
        }
    }
}