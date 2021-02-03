using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            Assert.IsFalse("The result of RoyalWins is ".IsNullOrEmpty());
        }

        [TestMethod]
        public void TestMethod02()
        {
            string str = null;
            Assert.IsTrue(str.IsNullOrEmpty());

        }

        [TestMethod]
        public void TestMethod03()
        {
            Assert.IsFalse("a".IsNullOrEmpty());
        }
    }
}
