using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims.StackLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.StackLearning.Tests
{
    [TestClass()]
    public class BufferTests
    {

        /// <summary>
        /// Create a buffer of characters, 0 through 99.
        /// </summary>
        /// <returns></returns>



        [TestMethod()]
        public void InsertTest()
        {
            string testString = "";
            Buffer myTestObject = new Buffer();
            for (int i = 0; i < 100; i++)
            {
                myTestObject.Insert('a');
                testString += "a";
            }

            Assert.AreEqual(100, myTestObject.Size);

        }

        [TestMethod()]
        public void GetTest()
        {
            Buffer myTestObject = new Buffer();

        }

        [TestMethod()]
        public void BufferTest()
        {
            
        }

        [TestMethod()]
        public void GetDataTest()
        {
            string expected = "";
            Buffer myTestObject = new Buffer();
            for(int i = 0; i < 9; i++)
            {
                expected += i.ToString();
                myTestObject.Insert(i.ToString().ElementAt(0));
            }

            Assert.AreEqual(expected, myTestObject.GetData());
        }


        [TestMethod()]
        public void DeleteTest()
        {
            Buffer myTestObj = new Buffer();

            for (int i = 0; i < 10; i++)
            {
                char myInsertChar = i.ToString()[0];
                myTestObj.Insert(myInsertChar);
            }

            for(int i = 9; i >= 0; i--)
            {
                Assert.AreEqual(i, int.Parse(myTestObj.Delete().ToString()), i.ToString());
            }
        }

        [TestMethod()]
        public void LeftTest()
        {
            Buffer myTestObject = new Buffer();
            for(int i = 0; i < 100; i++)
            {
                myTestObject.Insert(i.ToString().ElementAt(0));
            }

            myTestObject.Left(10);
            Assert.AreEqual(89, myTestObject.CursorPosition);
        }

        [TestMethod()]
        public void RightTest()
        {
            Buffer myTestObject = new Buffer();
            for (int i = 0; i < 100; i++)
            {
                myTestObject.Insert(i.ToString().ElementAt(0));
            }

            myTestObject.Left(10);
            myTestObject.Right(5);
            Assert.AreEqual(94, myTestObject.CursorPosition);
        }
    }
}