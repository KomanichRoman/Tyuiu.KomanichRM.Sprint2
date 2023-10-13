using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint2.Task7.V15.Lib;

namespace Tyuiu.KomanichRM.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
