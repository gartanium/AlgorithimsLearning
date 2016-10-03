using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims.GraphTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.GraphTheory.Tests
{
    [TestClass()]
    public class DepthFirstSearchTests
    {
        [TestMethod()]
        public void DepthFirstSearchTest()
        {
            
            // We want to assert that the method truly processes through every single path.
            Graph myTestObject = new Graph(12);
            myTestObject.AddEdge(0, 1);
            myTestObject.AddEdge(1, 4);
            myTestObject.AddEdge(1, 5);
            myTestObject.AddEdge(1, 6);
            myTestObject.AddEdge(6, 8);
            myTestObject.AddEdge(6, 9);
            myTestObject.AddEdge(1, 7);
            myTestObject.AddEdge(0, 3);
            myTestObject.AddEdge(0, 2);
            myTestObject.AddEdge(2, 10);
            myTestObject.AddEdge(2, 11);
            DepthFirstSearch myTestAlg = new DepthFirstSearch(myTestObject, 1);
            Assert.AreEqual(12, myTestAlg.Count);


        }
    }
}