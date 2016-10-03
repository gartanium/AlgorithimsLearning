using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.GraphTheory
{
    public class DepthFirstSearch
    {
        private bool[] mMarked; // Array of vertices that are marked, or have been visited.
        public bool[] Marked { get { return mMarked; } }

        private int mCount;
        public int Count { get { return mCount; } }

        public DepthFirstSearch(Graph G, int s)
        {
            mMarked = new bool[G.V];
            DFS(G, s); // Recursive method, depth first search
        }

        private void DFS(Graph G, int v)
        {
            mMarked[v] = true; // sets the vertice v as being marked
            mCount++;
            foreach(int w in G[v])
            {
                if(!mMarked[w]) // 
                {
                    DFS(G, w);
                }
            }
        }

    }
}
