using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWebAPI.Controllers;

namespace MSTUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [TestMethod]
        public void GetReturnByName()
        {

            var returnValue = controller.Get(1);
            Assert.AreEqual("Ananth Subramoniam", returnValue.ToString());
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
