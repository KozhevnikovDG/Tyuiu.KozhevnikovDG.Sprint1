using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint1.Task4.V1.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 0.062;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res); 

        }
    }
}
