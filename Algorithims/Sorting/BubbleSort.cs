using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithims.Sorting
{
    public class BubbleSort
    {
        private int[] mArray;
        public int[] Array { get { return mArray; } }

        public BubbleSort(int[] arg)
        {
            arg = Sort(arg);
            mArray = arg;
        }

        protected int[] Sort(int[] arg)
        {
            bool swapped = true;
            

            while(swapped)
            {
                swapped = false;
                for(int i = 0; i < arg.Length - 1; i++)
                {
                    if (arg[i] > arg[i + 1])
                    {
                        int temp = arg[i + 1]; // Swap
                        arg[i + 1] = arg[i];
                        arg[i] = temp;
                        swapped = true;
                        Console.WriteLine("Swapping element {0} with {1}", i.ToString(), (i + 1).ToString());
                    }
                }
            }

            return arg;
        }

     
    }
}
