using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompleteTestProject
{
    [TestClass]
    public class TestNumbers
    {
        [TestMethod]
        public void TestPrimeNumber()
        {
            Assert.IsTrue(isPrimeNumber(5), "Entered number is not prime number.");
        }

        [TestMethod]
        public void TestPrimeNumber2()
        {
            Assert.IsTrue(isPrimeNumber(6), "Entered number is not prime number.");
        }

        [TestMethod]
        public void TestNumberEquality()
        {
            Assert.AreEqual(10, 10.0, "Entered numbers are not equal.");
        }

        private Boolean isPrimeNumber(int number)
        {
            bool flag = true;
            for(int i=2; i<number/2; i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                    return flag;
                }
            }
            return flag;
        }
    }
}
