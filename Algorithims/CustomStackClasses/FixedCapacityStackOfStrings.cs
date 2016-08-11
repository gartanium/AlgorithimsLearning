using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.ExtraClasses
{

    /// <summary>
    /// A class containing a few methods for manipulating a stack of strings.
    /// </summary>
    public class FixedCapacityStackOfStrings
    {
        private String[] a; // stack entries
        private int N;

        public FixedCapacityStackOfStrings(int cap)
        {
            a = new string[cap];

        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }

        public int Size
        {
            get { return N; }
        }

        public void Push(string item)
        {
            a[N++] = item;

        }

        /// <summary>
        /// Removes the element from the array
        /// </summary>
        /// <returns></returns>
        public string Pop()
        {
            
            return a[--N];
        }
    }
}
