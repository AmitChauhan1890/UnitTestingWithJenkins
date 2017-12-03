using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompleteTestProject
{
    [TestClass]
    public class TestString
    {
        [TestMethod]
        public void TestEqual()
        {
            Assert.AreEqual("HELLO", "HELLO", "Strings are not equal.");
        }

        [TestMethod]
        public void TestContains()
        {
            Assert.IsTrue("Hello India".Contains("Hello"), "Enter word doesn't found in String.");
        }
    }
}
