using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint3.Task1.V10.Lib;

namespace Tyuiu.KolchakovDR.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 17;
            int value = 5;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.168;
            Assert.AreEqual(wait, res);

            
        }
    }
}
