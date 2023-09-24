﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.KozhevnikovDG.Sprint1.Task1.V28.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 7.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}