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
    public class DepthFirstPathsTests
    {
        [TestMethod()]
        public void HasPathToTest() // Assert that given Vertices are ether in the graph or not.
        {
            Graph G = new Graph(11);
            DepthFirstPaths testObject;

            G.AddEdge(0, 1); // vertices 0 through 8 are in the graph. 9 and 10 are not. 
            G.AddEdge(0, 2);
            G.AddEdge(2, 3);
            G.AddEdge(3, 5);
            G.AddEdge(2, 4);
            G.AddEdge(4, 6);
            G.AddEdge(6, 7);
            G.AddEdge(6, 8);
            G.AddEdge(9, 10);

            testObject = new DepthFirstPaths(G, 0);

            // First assert that a graph has a path to it.
            for (int i = 0; i < 9; i++) // 0 through 8
            {
                Assert.IsTrue(testObject.HasPathTo(i), i.ToString());
            }


            // Second assert that a graph does not have a path to it.
            Assert.IsFalse(testObject.HasPathTo(9)); //9 and 10
            Assert.IsFalse(testObject.HasPathTo(10));

        }

        [TestMethod()]
        public void PathToTest()
        {
            Graph G = new Graph(11);
            DepthFirstPaths testObject;

            G.AddEdge(0, 1);
            G.AddEdge(0, 2);
            G.AddEdge(2, 3);
            G.AddEdge(3, 5);
            G.AddEdge(2, 4);
            G.AddEdge(4, 6);
            G.AddEdge(6, 7);
            G.AddEdge(6, 8);
            G.AddEdge(9, 10);

            testObject = new DepthFirstPaths(G, 0);

            // Expected Data.
            int[] ePath1 = { 0, 2, 3, 5 };


            Stack<int> sPath1 = testObject.PathTo(5);

            int[] aPath1 = sPath1.ToArray();

            for(int i = 0; i < aPath1.Length; i++)
            {
                Assert.AreEqual(ePath1[i], aPath1[i], "Expected: " + ePath1[i].ToString() + " Actual: " + aPath1[i].ToString());
            }
          
        }
    }
}