using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void RankTest()
        {
            
            int[] mySortedIntArray;
            List<int> mySortedIntList = new List<int>();
            List<int> myWhiteList = new List<int>();
            List<int> myRankList = new List<int>();

             

            // Add 1,000 numbers to the list
            // The number is etherr added to the white list or to the sorted int list.
            for(int i = 0; i < 1000; i++)
            {
                if ((float)i % 10 == 0)
                {
                    myWhiteList.Add(i);
                    continue;
                }
                else
                    mySortedIntList.Add(i);
            }

            // Now convert the list into an array.
            mySortedIntArray = new int[mySortedIntList.Count];
            for(int i = 0; i < mySortedIntList.Count; i++)
            {
                mySortedIntArray[i] = mySortedIntList[i];
            }



            // Use rank to discover which keyes are missing.
            for(int i = 0; i < mySortedIntArray[mySortedIntArray.Length - 1]; i++)
            {
                 if(!(BinarySearch.Rank(i, mySortedIntArray) == i))
                {
                    myRankList.Add(i);
                }
            }

            Assert.AreEqual(myWhiteList, myRankList);

        }
    }
}