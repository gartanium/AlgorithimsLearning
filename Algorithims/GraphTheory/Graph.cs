using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithims.BagLearning;

namespace Algorithims.GraphTheory
{
    public class Graph
    {
        private class Node
        {
            public int X;
            public int Y;
            public int Weight;

            public Node(int x, int y, int weight)
            {
                X = x;
                Y = y;
                Weight = weight;
            }
            
        }

        private int mV; // number of vertexes

        // List of nodes
        private Node[] mNodeArray; 

        
        /// <summary>
        /// umber of nodes in the graph (Vertices).
        /// </summary>
        public int N { get { return mNodeArray.Length; } }

        /// <summary>
        /// Number of vertexes.
        /// </summary>
        public int V { get { return mV; } }

        // number of edges
        private int mE;

        /// <summary>
        /// Number of Edges.
        /// </summary>
        public int E { get { return mE; } }

        private Bag<int>[] mAdj; //Adjacency lists

        public Bag<int>[] Adj { get { return mAdj; } }

        public Bag<int> this[int i]
        {
            get
            {
                return mAdj[i];
            }
        }

        /// <summary>
        /// Create a V-vertex graph with no edges
        /// </summary>
        /// <param name="V"></param>
        public Graph(int V)
        {
            this.mV = V; this.mE = 0;
            mAdj = new Bag<int>[V];  // Create array of lists.
            for (int i = 0; i < V; i++) // Initialize the list
                mAdj[i] = new Bag<int>(); // to empty.

            this.mNodeArray = null;
        }


        /// <summary>
        /// Provides implementation for the node array.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="nodePositions"></param>
        public Graph(int v, int[] nodePositionsX, int[] nodePositionsY, int[] nodeWeight)
        {
            if (nodePositionsX.Length == v && nodePositionsY.Length == v && v > 0)
            {
                this.mNodeArray = new Node[v];
                for(int i  = 0; i < v; i++) // Assign each node a position and weight value.
                {
                    mNodeArray[i] = new Node(nodePositionsX[i], nodePositionsY[i], nodeWeight[i]);
                }

                this.mV = v; this.mE = 0;
                mAdj = new Bag<int>[v];  // Create array of lists.
                for (int i = 0; i < v; i++) // Initialize the list
                    mAdj[i] = new Bag<int>(); // to empty.
            }
            else
                throw new System.ArgumentOutOfRangeException();
         

            // For each node

        }

        /// <summary>
        /// Add edge v-w to this graph. 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="w"></param>
        public void AddEdge(int v, int w)
        {
            mAdj[v].Add(w); // Add w to v's adjaceny list.
            mAdj[w].Add(v);  // Add v to W's adjacency list.
            mE++;
        }

        // string representation.
        public override string ToString()
        {
            string stringRep = null;
            return stringRep;
        }

        /// <summary>
        // Returns a 2-Demensional array containing the x-y positions of nodes. The first element, 0, reffers to x values
        // The second, 1, reffers to y values.
        /// </summary>
        /// <param name="nodeStack"></param>
        /// <returns></returns>
        public int[,] NodePositions(Stack<int> nodeStack)
        {
            int nodeStackCount = nodeStack.Count;

            if (nodeStack.Count <= mV) // Return an error if the number of positions is greater then v...
            {
                int[,] positions = new int[2, nodeStack.Count];

                for (int i = nodeStackCount -1; i > 0; i--) // Fill each position with the node indexed by nodeStack.
                {
                    int poppedIndex = nodeStack.Pop(); // Index of the popped Node
                    Node current = this.mNodeArray[poppedIndex];
                    positions[0, i] = current.X;
                    positions[1, i] = current.Y;
                    
                }

                return positions;
            }
            else
                throw new ArgumentException("To many steps in the path! Steps: " + nodeStack.Count.ToString() + " Vertices: " + this.mV.ToString());
        }

    }
}
