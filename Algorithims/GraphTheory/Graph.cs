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

        private int mV; // number of vertexes

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



        /// <summary>
        /// Returns a list of all vertices adjacent to v.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public List<int> Adj(int v)
        {
            List<int> adjacentToV = new List<int>();
            return adjacentToV;

        }

        // string representation.
        public override string ToString()
        {
            string stringRep = null;
            return stringRep;
        }
    }
}
