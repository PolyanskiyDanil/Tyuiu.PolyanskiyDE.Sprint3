using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint3.Task1.V8.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = -309059.536;

            Assert.AreEqual(wait, res);

        }
    }
}
