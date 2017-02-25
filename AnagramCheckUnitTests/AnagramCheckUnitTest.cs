using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramCheck;

namespace AnagramCheckUnitTests
{
    [TestClass]
    public class AnagramCheckUnitTest
    {
        CheckAnagram testobj = null;
        [TestInitialize]
        public void Initialize()
        {
            testobj = new CheckAnagram();
        }

        [TestMethod]
        public void Test_CheckAnagramData()
        {
            string data1 = "listen";
            string data2 = "silent";
            //testobj.CheckAnagramData(data1,data2);

            Assert.IsTrue(testobj.CheckAnagramData(data1, data2));
            //Assert.Equals(,true);


        }

        [TestMethod]
        public void Null_CheckAnagramData()
        {
            Assert.IsFalse(testobj.CheckAnagramData(null, null));
        }

        [TestMethod]
        public void NegativeTest_CheckAnagramData()
        {
            string data1 = "listen";
            string data2 = "sil";
            //testobj.CheckAnagramData(data1,data2);

            Assert.IsFalse(testobj.CheckAnagramData(data1, data2));
            //Assert.Equals(,true);


        }
    }
}
