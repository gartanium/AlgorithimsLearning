using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class Chapter1Tests
    {
        [TestMethod()]
        public void IsEvenTest()
        {
            // Create a list of integers, which are even, to determine if the function (IsEven) truly tests if an integer is even or odd.
            int[] evenIntList = new int[100];
            for (int i = 0; i < evenIntList.Length; i++)
            {
                evenIntList[i] = 2 * i;
            }

            for (int i = 0; i < evenIntList.Length; i++)
            {
                int actualEven = evenIntList[i];
                Assert.IsTrue(Chapter1.IsEven(actualEven), actualEven.ToString());

                int actualOdd = evenIntList[i] + 1;
                Assert.IsFalse(Chapter1.IsEven(actualOdd), actualOdd.ToString());
            }



        }

        [TestMethod()]
        public void LogBase2Test()
        {
            int actual = Chapter1.LogBase2(8);
            Assert.AreEqual(3, actual, actual.ToString());
        }

        [TestMethod()]
        public void PowTest()
        {


            double y = 3;

            for(int i = 0; i < 1000; i++)
            {
                int expected = (int)Math.Pow((double)i, y);
                int actual = Chapter1.Pow(i, (int)y);
                string message = "expected :" + expected.ToString() + " actual: " + actual.ToString();
                Assert.AreEqual(expected, actual, message);
            }
        }
    }
}