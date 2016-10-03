using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.GraphTheory
{
    public class DepthFirstPaths // Expands upon Depth First Search
    {
        private bool[] mMarked; // Has dfs() been called for this vertex?
        private int[] mEdgeTo; // Last vertex on known path to this vertex. Or in other words,
                                //The parent edge of a given vertex... where edgeto[w] = v. 
        private int mS; // source (Start position).
                
        /// <summary>
        /// Find paths in G from source s
        /// </summary>
        /// <param name="G"></param>
        /// <param name="s">Source of Path (Or start position)</param>
        public DepthFirstPaths(Graph G, int s)
        {
            mMarked = new bool[G.V];
            mEdgeTo = new int[G.V];
            this.mS = s;
            DFS(G, s);

        }

        private void DFS(Graph G, int v)
        {
            // First mark the vertex
            mMarked[v] = true;
            foreach(int w in G[v])
            {
                if(!mMarked[w])
                {
                    mEdgeTo[w] = v; // Set the parent vertex (or edge) of w to be v. It's origin. 
                    DFS(G, w); // Recursion.
                }
            }
        }

        /// <summary>
        /// Returns true if there is a path from s to v.    
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool HasPathTo(int v)
        {
            return mMarked[v];
        }

        public Stack<int> PathTo(int v) // Returns a stack containing the path of a given vertex to the source. 
        {
            Stack<int> path = new Stack<int>();
            if (HasPathTo(v))
            {
                for (int i = v; i != mS; i = mEdgeTo[i])
                    path.Push(i);
                path.Push(mS);
            }
            else
                return null;

            return path;
        }
        
    }
}
