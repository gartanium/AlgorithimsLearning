using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims.BagLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.BagLearning.Tests
{
    [TestClass()]
    public class BagTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Bag<int> myTestObject = new Bag<int>();
            myTestObject.Add(0);
            myTestObject.Add(1);
            myTestObject.Add(2);

            List<int> expected = new List<int>();
            expected.Add(2); expected.Add(1); expected.Add(0);
            List<int> actual = new List<int>();

            foreach (int i in myTestObject)
            {
                actual.Add(i);
            }


            for(int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "Expected: " + expected[i].ToString() + ", Actual: " + actual[i].ToString());
            }
            
        }

    }
}