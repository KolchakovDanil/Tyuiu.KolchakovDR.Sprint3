using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint3.Task2.V25.Lib;

namespace Tyuiu.KolchakovDR.Sprint3.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 13;
            int value = 5;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 16.016;
            Assert.AreEqual(wait, res);
        }
    }
}
