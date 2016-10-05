using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.GraphTheory
{

    /// <summary>
    /// Class takes an array of integers as an input, and translates it into a rectangular graph.
    /// </summary>
    public static class RectangularGraphFactory
    {
        
        public static Graph GenerateGraph(int width, int height)
        {
            return ConnectVertices(new Graph(width * height), width, height);
        }

        private static Graph ConnectVertices(Graph graph, int width, int height)
        {
            // Attach every vertice to their neighbor
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    int cursorPosition = (width * i) + j;
                   // Add the left vertice.
                   if(j > 0) // Left vertice applys to the left column, or i.
                    {
                        int leftVertice = cursorPosition - 1;
                        graph.AddEdge(cursorPosition, leftVertice);
                    }
                   // Add the right vertice.
                   if( j < width - 1)
                    {
                        int rightVertice = cursorPosition + 1;
                        graph.AddEdge(cursorPosition, rightVertice);
                    }
                   // Add the top vertice
                   if ( i > 0)
                    {
                        int topVertice = cursorPosition - width;
                        graph.AddEdge(cursorPosition, topVertice);
                    }
                    if (i < height - 1)
                    {
                        int bottumVertice = cursorPosition + width;
                        graph.AddEdge(cursorPosition, bottumVertice);
                    }


                }
            }

            return graph;
        }
    }
}
