using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovaMV.Sprint1.Task0.V18.Lib;

namespace Tyuiu.KomarovaMV.Sprint1.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
