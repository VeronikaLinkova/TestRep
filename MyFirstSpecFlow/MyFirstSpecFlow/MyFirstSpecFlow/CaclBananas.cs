using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace MyFirstSpecFlow
{
    [Binding]
    public sealed class CaclBananas
    {
        private int firstMonkeyBananas;
        private int secondMonkeyBananas;

        [Given("^First monkey have (\\d+) banana")]
        public void initFirstMonkey(int numberOfBananas)
        {
            firstMonkeyBananas = numberOfBananas;
        }

        [Given("^Second monkey have (\\d+) banana")]
        public void initSecondMonkey(int numberOfBananas)
        {
            secondMonkeyBananas = numberOfBananas;
        }

        [When("^First monkey give (\\d+) banana to second monkey")]
        public void bananaTransfer(int numberOfBananas)
        {
            secondMonkeyBananas += numberOfBananas;
            firstMonkeyBananas -= numberOfBananas;
        }

        [Then("^First monkey have (\\d+) banana and second monkey have (\\d+) banana")]
        public void bananaTest(int firstBananaExpected, int secondBananaExpected)
        {
            Assert.AreEqual(firstMonkeyBananas, firstBananaExpected);
            Assert.AreEqual(secondMonkeyBananas, secondBananaExpected);
        }

        [Then("^have error message$")]
        public void bananaErrorTest()
        {
            if(firstMonkeyBananas < 0 || secondMonkeyBananas < 0)
            {
                Assert.IsTrue(true);
            } else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
