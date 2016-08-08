using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims.ExtraClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.ExtraClasses.Tests
{
    [TestClass()]
    public class FixedCapacityStackOfStringsTests
    {
        [TestMethod()]
        public void FixedCapacityStackOfStringsTest()
        {
            FixedCapacityStackOfStrings testObject = new FixedCapacityStackOfStrings(100);

            Stack<string> myStringStack = new Stack<string>();
            for(int i = 0; i < 100; i++)
            {
                myStringStack.Push(i.ToString());
                testObject.Push(i.ToString());
                Assert.AreEqual(myStringStack.Pop(), testObject.Pop(), i.ToString());
            }

            for(int i = 0; i < 100; i++)
            {
                myStringStack.Push(i.ToString());
                testObject.Push(i.ToString());
                if((float)i % 2.0 == 0)
                {
                    Assert.AreEqual(myStringStack.Pop(), testObject.Pop(), i.ToString());
                }
            }

            


        }
    }
}