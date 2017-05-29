using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algorithims.GraphTheory
{

    /// <summary>
    /// Class takes an array of integers as an input, and translates it into a rectangular graph.
    /// </summary>
    public static class RectangularGraphFactory
    {
        
        /// <summary>
        /// Generates a rectangular graph, with appropriatly connected vertices. Each vertex contains data for width and height.
        /// </summary>
        /// <param name="width">Width of the Rectangle.</param>
        /// <param name="height">Height of the Rectangle.</param>
        /// <param name="columns">Number of Columns.</param>
        /// <param name="rows">Number of Rows.</param>
        /// <returns></returns>
        public static Graph GenerateGraph(int width, int height, int columns, int rows)
        {
            
            Point[] positions = new Point[columns * rows];
            Point[] dimensions = new Point[columns * rows];
            int[] weight = new int[columns * rows];
            int vertexCount = columns * rows; // Number of vertices in the graph

            // Provide appropriate data for the positions....
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    int cursor = (i * columns) + j; // Cursor to translate from 2D to 1D.
                    dimensions[cursor] = new Point(width, height);// Set each cell to have a dimension accordint to the template.
                    positions[cursor] = new Point(i * width, j * height); // Each position is based off of the itteration, and the dimensions
                    weight[cursor] = 1; // No deviating weight necissary (for now). 
                }
            }

            Graph g = new Graph(vertexCount, positions, dimensions, weight);


            return ConnectVertices(g, columns, rows);
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
