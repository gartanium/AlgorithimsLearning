using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.QueueLearning
{
    public class FifoQueue<T>
    {
        private class Node // Nested class to define nodes.
        {
            public T Item;
            public Node Next;
        }

        


        private Node mFirst; // link to least recnetly added node
        private Node mLast; // Link to most recnetly added node
        private int mN; // Number ofi tems on the queue

        public Boolean IsEmpty { get { return mFirst == null; } }
        public int Size { get { return mN; } }

        


        public FifoQueue()
        {

        }

        public void Enqueue(T newItem)
        {
            Node oldLast = mLast;
            // Add the object t to the node.
            mLast = new Node();
            mLast.Item = newItem;
            mLast.Next = null; // The  chain ends here

            if (IsEmpty) { mFirst = mLast; } // Case if there is no elements in the Queue
            else { oldLast.Next = mLast; }
            mN++;
        }


        /// <summary>
        /// Removes item from the beginning of the list.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T item = mFirst.Item;
            // Set the first item in the queue equal to the next item in the list.
            mFirst = mFirst.Next;
            mN--;
            if (IsEmpty) { mLast = null; }
            return item;
        }

    }
}
