using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.StackLearning
{
    public class GenericStackResizing <T>
    {
        private T[] mArray;
        private int mIndex;

        public bool IsEmpty
        {
            get { return mIndex == 0; }
        }

        public int Count
        {
            get { return mIndex; }
        }

        public GenericStackResizing(int maxCapacity)
        {
            this.mIndex = 0;
            this.mArray = new T[maxCapacity];
        }

        public T Pop()
        {
            return this.mArray[--mIndex];
        }


        /// <summary>
        /// Returns the last element in the stack with out popping it.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return this.mArray[mIndex];
        }

        public void Push(T item)
        {
            mIndex++;
            if(mArray.Length <= mIndex)
            {
                this.Resize(mArray.Length * 2);
            }
            mArray[mIndex] = item;
            
        }

        private void Resize(int maxCapacity)
        {
            T[] resizedArray = new T[maxCapacity];
            for(int i = 0; i < this.mArray.Length; i++)
            {
                resizedArray[i] = this.mArray[i];
            }

            this.mArray = resizedArray;
        }
    }
}
