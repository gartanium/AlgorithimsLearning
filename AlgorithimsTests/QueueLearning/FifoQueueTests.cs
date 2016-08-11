using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims.QueueLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.QueueLearning.Tests
{
    [TestClass()]
    public class FifoQueueTests
    {
        [TestMethod()]
        public void FifoQueueTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EnqueueTest()
        {
            FifoQueue<int> myTestObject = new FifoQueue<int>();
            for(int i = 0; i < 100; i++)
            {
                myTestObject.Enqueue(i);
            }
            Assert.AreEqual(100, myTestObject.Size);
        }

        [TestMethod()]
        public void DequeueTest()
        {
            Queue<int> expected = new Queue<int>();
            FifoQueue<int> myTestObject = new FifoQueue<int>();
            for (int i = 0; i < 100; i++)
            {
                expected.Enqueue(i);
                myTestObject.Enqueue(i);
            }
            
            for(int i = 0; i < 100; i++)
            {
                Assert.AreEqual(expected.Dequeue(), myTestObject.Dequeue(), i.ToString());
            }
            
           
        }
    }
}