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
    public class GraphTests
    {
        [TestMethod()]
        public void GraphTest()
        {
            // Ok. Let me square with you. The purpose of this test is to test the ability of the Graph method to use
            // A foreach statement in returning everysingle vertex that is adjacent to a given vertex. Thank you.

            // Creates like a circle graph. All the edges are connected to the first vertex. YAY!
            Graph myTestGraph = new Graph(10);
            for (int i = 0; i < 10; i++)
            {
                myTestGraph.AddEdge(0, i);
            }

            int counter = 0;
            // Now, were going to assert that this assumption is true.
            for (int i = 0; i < 10; i++) // For each bag array...
            {

                foreach (int j in myTestGraph[i])
                {
                    // Assert that the list is the same as the control list.
                    if (j == 0)
                    {
                        counter++;
                    }

                }
            }

            Assert.AreEqual(11, counter, counter.ToString()); // WE assume that the graph is going to be connected to it's self.
                                                              // If wondering why, it's because at addedge, we do 0 and 0 in the
                                                              // First itteration.


        }

        [TestMethod()]
        public void AddEdgeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NodePositionsTest()
        {
            int[] xPos = { 0, 1, 2, 3, 4 };
            int[] yPos = { 0, 1, 2, 3, 4 };
            int[] weight = { 1, 1, 1, 1, 1 };
            Stack<int> nodeStack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                nodeStack.Push(i);
            }
            Graph g = new Graph(5, xPos, yPos, weight);

            int[,] positions = g.NodePositions(nodeStack);

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(xPos[i], positions[0, i]);
            }


        }

        [TestMethod()]
        public void GraphTest1() // Tests the overload method
        {
            int[] xPos = { 0, 1, 2, 3, 4 };
            int[] yPos = { 0, 1, 2, 3, 4 };
            int[] weight = { 1, 1, 1, 1, 1 };
            Stack<int> nodeStack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                nodeStack.Push(i);
            }
            Graph g = new Graph(5, xPos, yPos, weight);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(0, 4);

            Assert.AreEqual(4, g.E);
            Assert.AreEqual(5, g.V);
            Assert.AreEqual(g.V, g.N); // Make sure the amount of nodes is equal to the number of vertices.
            
           
        }
    }
}