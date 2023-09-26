using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint1.Task5.V8.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task5.V8.Test
{
    [TestClass]
    public class DataSrviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 32.597;
            double d = 5;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 5;
            
        }
    }
}
