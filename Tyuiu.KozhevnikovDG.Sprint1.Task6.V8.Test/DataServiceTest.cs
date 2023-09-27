using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint1.Task6.V8.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "привет";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(str);
            Assert.AreEqual("риветп", res);


        }
    }
}
