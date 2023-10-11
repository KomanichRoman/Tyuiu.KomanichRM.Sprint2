using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KomanichRM.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindDateOfNextDay(1));
            Assert.AreEqual("Февраль", ds.FindDateOfNextDay(2));
            Assert.AreEqual("Март", ds.FindDateOfNextDay(3));
            Assert.AreEqual("Апрель", ds.FindDateOfNextDay(4));
            Assert.AreEqual("Май", ds.FindDateOfNextDay(5));
            Assert.AreEqual("Июнь", ds.FindDateOfNextDay(6));
            Assert.AreEqual("Июль", ds.FindDateOfNextDay(7));
            Assert.AreEqual("Август", ds.FindDateOfNextDay(8));
            Assert.AreEqual("Сентябрь", ds.FindDateOfNextDay(9));
            Assert.AreEqual("Октябрь", ds.FindDateOfNextDay(10));
            Assert.AreEqual("Ноябрь", ds.FindDateOfNextDay(11));
            Assert.AreEqual("Декабрь", ds.FindDateOfNextDay(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(13);
            });
            
        }
    }
}
