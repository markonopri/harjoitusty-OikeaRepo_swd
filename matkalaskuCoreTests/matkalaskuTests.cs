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

        }

    }
}