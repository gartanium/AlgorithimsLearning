using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims
{
    public static class BinarySearch
    {
        public static int Rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;

            while (lo <= hi) // Key is in a[lo..hi] or not present.
            {
                int mid = lo + (hi - lo) / 2;
                // If key is in [lo...hi] or not present
                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if (key > a[mid])
                {
                    lo = mid + 1;
                }
                else return mid; // If I leave out the == operator, it will also return mid if there is no key inbetween [lo...hi].
            }
            throw new ArgumentException("the array int[]a must have a length greater then 0!", a.ToString());
            
        }
    }
}
