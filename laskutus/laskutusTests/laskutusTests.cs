using NUnit.Framework;
using System.Collections.Generic;

namespace laskutusTests
{
    [TestFixture]
    public class Tests
    {
      [Test]
      public void onkoListaYksiTyhjä()
      {
            List<string> asiakasNimi = new List<string>();
            if (asiakasNimi == null)
            {
                Assert.IsNull(asiakasNimi);
            }
            else
            {
                Assert.IsNotNull(asiakasNimi);
            }
      }
    }
}