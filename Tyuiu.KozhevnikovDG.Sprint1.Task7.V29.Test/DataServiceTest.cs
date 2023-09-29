using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint1.Task7.V29.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 3.108;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
