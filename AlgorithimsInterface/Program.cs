using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithims;

namespace AlgorithimsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();

         
            GUI myAlgorithimGUI = new GUI(10, 10, 0, 0);
            Console.WriteLine(myAlgorithimGUI.GetGui());
            
         

        }
    }
}
