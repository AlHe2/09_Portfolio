using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Portfolio
{
    //Now things are getting trickier. Be sure to follow along in the index.html file, to see the purpose of the different tests
    //we will be creating here.

    //THESE ARE THE SECOND TESTS YOU SHOULD DO 

    [TestClass]
    public class PolymorphismTests
    {
        private Stock stockHP;
        private Stock stockIBM;

        [TestInitialize]
        public void SetUpForTest() {
            stockHP = new Stock("HPQ", 60.03, 120);
            stockIBM = new Stock("IBM", 32.11, 50);
        }


        [TestMethod]
        public void InstanceOf() {
            Assert.IsTrue(stockHP is IAsset);
        }

        [TestMethod]
        public void CD() {
            SavingsAccount cd = new SavingsAccount("Account 55555", 1000, 4.2);
            Assert.IsTrue(cd is IAsset);
            Assert.AreEqual("SavingsAccount[value=1000,interestRate=4,2]", cd.ToString());
            Assert.AreEqual(1000, cd.GetValue());
            Assert.AreEqual(4.2, cd.InterestRate);
        }

        [TestMethod]
        public void CDInterest() {
            SavingsAccount cd = new SavingsAccount("Account 55555", 1000, 4.2);
            Assert.AreEqual(1000, cd.GetValue());
            cd.ApplyInterest();
            Assert.AreEqual(1042, cd.GetValue());
        }

        [TestMethod]
        public void PolymorphismArray() {
            SavingsAccount cd = new SavingsAccount("Account 55555", 1000, 3.2);

            IAsset[] portfolio = new IAsset[3];
            portfolio[0] = stockHP;
            portfolio[1] = stockIBM;
            portfolio[2] = cd;
            Assert.AreEqual(9809.1, Portfolio.TotalValue(portfolio));
        }


    }
}
