using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithims.BagLearning;
using System.Drawing;


namespace Algorithims.GraphTheory
{
    public class Graph
    {
        private class Node
        {
            public Rectangle BoundingBox;
            public int X;
            public int Y;
            public int Weight;

            public Point mPosition;
            public Point Position { get {return mPosition;} }

            public Node(int x, int y, int weight, int length, int width)
            {
                X = x;
                Y = y;
                Weight = weight;

                this.mPosition = new Point(x, y);

                BoundingBox = new Rectangle(x, y, width, length);
            }
            
        }

        private int mV; // number of vertexes

        // List of nodes
        private Node[] mNodeArray; 

        
        /// <summary>
        /// umber of nodes in the graph (Vertices).
        /// </summary>
        public int N { get { if (mNodeArray != null) { return mNodeArray.Length; } else return 0 ; } }

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
        public Graph(int v, int[] nodePositionsX, int[] nodePositionsY, int[] nodeWeight, int width, int length)
        {
            if (nodePositionsX.Length == v && nodePositionsY.Length == v && v > 0)
            {
                this.mNodeArray = new Node[v];
                for(int i  = 0; i < v; i++) // Assign each node a position and weight value.
                {
                    mNodeArray[i] = new Node(nodePositionsX[i], nodePositionsY[i], nodeWeight[i], width, length);
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

        // <summary>
        /// Provides implementation for the node array.
        // </summary>
        // <param name="v">number of vertices</param>
        // <param name="nodePositions"></param>
        public Graph(int v, Point[] positions, Point[] dimensions, int[] nodeWeight)
        {
            if (positions.Length == v)
            {
                this.mNodeArray = new Node[v];
                for (int i = 0; i < v; i++) // Assign each node a position and weight value.
                {
                    mNodeArray[i] = new Node((int)positions[i].X, (int)positions[i].Y, nodeWeight[i], (int)dimensions[i].X, (int)dimensions[i].Y);
                }

                this.mV = v; this.mE = 0;
                mAdj = new Bag<int>[v];  // Create array of lists.
                for (int i = 0; i < v; i++) // Initialize the list
                    mAdj[i] = new Bag<int>(); // to empty.
            }
            else
                throw new System.ArgumentOutOfRangeException();
        }


            // For each node

            //}

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
            if (mNodeArray != null)
            {
                int nodeStackCount = nodeStack.Count;

                if (nodeStack.Count <= mV) // Return an error if the number of positions is greater then v...
                {
                    int[,] positions = new int[2, nodeStack.Count];

                    for (int i = nodeStackCount - 1; i > 0; i--) // Fill each position with the node indexed by nodeStack.
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
            throw new ArgumentNullException("Graph was never generated with a list of nodes!");
        }


        /// <summary>
        /// Returns the position of a given vertex.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public Point GetVertexPosition(int v)
        {
            return mNodeArray[v].Position;
        }



        // <summary>
        // Returns the first vertex that is associated with a point.
        // </summary>
        // <param name="x"></param>
        // <param name="y"></param>
        // <returns></returns>
        public int GetVertex(int x, int y)
        {
            Point p = new Point(x, y);
            for (int i = 0;  i < mNodeArray.Length; i++)
            {
                if (mNodeArray[i].BoundingBox.Contains(p))
                {
                    return i;
                }

            }

            throw new ArgumentOutOfRangeException("param x and y are out of range! X: " + x.ToString() + " Y: " + y.ToString());
        }

        // Input a stack of nodes, output a stack of positions.
        public Queue<Point> PositionOrder(Stack<int> nodeStack)
        {
            // Soooooooo
            // Take the vertex's position.
            // Add it to the new Queue
            // Profit???

            if (nodeStack.Count <= this.V)
            {
                Queue<Point> result = new Queue<Point>();

                while(nodeStack.Count > 0)
                {
                    int vertex = nodeStack.Pop();
                    if (vertex <= this.mV) // Make sure that the vertex exists...
                    {
                        // Get it's position, then queue it up.
                        Point position = this.GetVertexPosition(vertex);
                        result.Enqueue(position);
                    }
                    else
                        throw new ArgumentOutOfRangeException();
                }

                return result;
            }
            else
                throw new ArgumentOutOfRangeException("nodeStack must be less then the amount of vertices! (" + this.V.ToString() + ").");

        }

    }
}
