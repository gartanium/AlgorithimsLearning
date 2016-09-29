using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsTests.GraphTheory
{
    class Graph
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


        /// <summary>
        /// Create a V-vertex graph with no edges
        /// </summary>
        /// <param name="V"></param>
        public Graph(int V)
        {

        }


        /// <summary>
        /// Add edge v-w to this graph.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="w"></param>
        public void AddEdge(int v, int w)
        {

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
