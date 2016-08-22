using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_BusinessLogic;

namespace WNG_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAllSequence()
        {
            string strResult=cls_SequenceGenerator.getAllSequence(10);
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10", strResult);

            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15", cls_SequenceGenerator.getAllSequence(15));
        }

        [TestMethod]
        public void TestOddSequence()
        {
            string strResult = cls_SequenceGenerator.getOddSequence(10);
            Assert.AreEqual("1, 3, 5, 7, 9, 10", strResult);
        }

        [TestMethod]
        public void TestEvenSequence()
        {
            string strResult = cls_SequenceGenerator.getEvenSequence(10);
            Assert.AreEqual("0, 2, 4, 6, 8, 10", strResult);
        }

        [TestMethod]
        public void TestAllLogicSequence()
        {
            string strResult = cls_SequenceGenerator.getAllLogicSequence(15);
            Assert.AreEqual("0, 1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z", strResult);
        }

        [TestMethod]
        public void TestFibonacciSequence()
        {
            string strResult = cls_SequenceGenerator.getFibonacciSequence(10);
            Assert.AreEqual("0,1, 1, 2, 3, 5, 8, 10", strResult);
        }
    }
}
