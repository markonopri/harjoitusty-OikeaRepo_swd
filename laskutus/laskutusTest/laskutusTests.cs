using System;
using NUnit.Framework;

namespace laskutusTests
{

    // Testit laskutusohjelmalle. Tässä esimerkki yleisestä virheestä, jossa
    // koodi tehty yhteen putkeen ja testien tekeminen mahdotonta...
    // Eli ohjelma olisi pitäny pilkkoa osiin, jotta testit olisi voinut
    // tehdä aina omaan luokkaan.

    // Mutta tämä harjoituksena.

    [TestFixture]
    public class LaskutusTests
    {

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        // Tässä testissä hinnat eivät ole vielä määritelty
        public void KunMaaritellaanTasojenHinnat()
        {
            double Pro = 0.0;
            double SemiPro = 0.0;
            double Basic = 0.0;

            Assert.AreEqual(0.0, Pro);
            Assert.AreEqual(0.0, SemiPro);
            Assert.AreEqual(0.0, Basic);
        }

        [Test]
        // Tässä testissä lasketaan kahdeksantoista prosentin alennus kun otettu pitempi tilaus.
        public void LasketaanKahdentoistaKuukaudenAlennus()
        {
            double kahdenksantoistaProsenttia = 0.82;
            int yksitoistaKuukautta = 11;

            Assert.AreEqual(8.2, Math.Round(10 * kahdenksantoistaProsenttia),2);
            Assert.AreEqual(90.2, Math.Round(yksitoistaKuukautta * 8.2),2);

        }

        [Test]
        // Tässä testissä lasketaan kymmenen prosentin alennus kun otettu pitempi tilaus.
        public void LasketaanKuudenKuukaudenAlennus()
        {
            double kymmenenProsenttia = 0.9;
            int viisiKuukautta = 5;

            Assert.AreEqual(9, 10 * kymmenenProsenttia);
            Assert.AreEqual(45, viisiKuukautta * 9);
        }
    }
}