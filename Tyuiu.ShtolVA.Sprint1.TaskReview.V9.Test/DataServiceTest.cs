using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint1.TaskReview.V9.Lib;

namespace Tyuiu.ShtolVA.Sprint1.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.975;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);

        }
    }
}
