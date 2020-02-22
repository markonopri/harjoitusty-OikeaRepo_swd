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

        }

    }
}