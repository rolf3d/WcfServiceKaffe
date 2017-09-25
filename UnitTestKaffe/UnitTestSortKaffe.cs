using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceKaffe;

namespace UnitTestKaffe
{
    [TestClass]
    public class UnitTestSortKaffe
    {
        [TestMethod]
        public void TestStyrke()
        {
            //Arrange
            var sortKaffe = new KaffeService();
            //Act
            string styrke = sortKaffe.GetStyrkeSortKaffe();
            //Assert
            Assert.AreEqual("stærk",styrke);
        }
    }
}
