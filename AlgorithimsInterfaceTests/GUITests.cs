using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithimsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsInterface.Tests
{
    [TestClass()]
    public class GUITests
    {
        [TestMethod()]
        public void DrawGUITest()
        {
            string myString = "ccccc\n";
            myString += "ccccc\n";
            myString += "ccccc\n";
            myString += "ccccc\n";
            myString += "ccccc\n";

            GUI myTestObject = new GUI(5, 5, 0, 0);
            Assert.AreEqual(myString.Count(), myTestObject.GetGui().Count());

        }
    }
}
