using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint1.Task3.V2.Lin;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int amountNotebook = 2;
            int amountPencil = 4;
            double priceNotebook = 3.80;
            double pricePencil = 1.50;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(13.6, res);
        }
    }
}
