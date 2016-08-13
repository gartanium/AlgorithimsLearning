using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims.AlgorithimAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.AlgorithimAnalysis.Tests
{
    [TestClass()]
    public class TimerTests
    {
        [TestMethod()]
        public void TimerTest()
        {

        }

        [TestMethod()]
        public void mRunTimeTest()
        {
            int expected = 1000;
            Timer testObject = new Timer(1000);
            int actual = testObject.mRunTime(2000);

            Assert.AreEqual(expected, actual);
        }
    }
}