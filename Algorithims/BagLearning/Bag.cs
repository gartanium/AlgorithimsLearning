using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.BagLearning
{
    public class Bag<Item> : IEnumerable
    {
        Node<Item> mFirst; // first node in list.
        protected int mSize;
        public int Size { get { return mSize; } } 

        public Bag()
        {
            mSize = 0;
            mFirst = null;
        }


        // Adds a new node, containing item. 
        // The new node will be the first in the bag, while the others will fall behind.
        public void Add(Item item)
        {
            Node<Item> oldFirst = mFirst;
            mFirst = new Node<Item>();
            mFirst.Item = item;
            mFirst.Next = oldFirst;
            mSize++;
        }

        public bool IsEmpty()
        {
            if (mFirst == null) return true;
            else return false;
            
        }



        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public BagEnum GetEnumerator()
        {
            return new BagEnum(mFirst);
        }

        // When you implement IEnumerable, you must also implement IEnumerator.
        public class BagEnum : IEnumerator
        {
            private Node<Item> mMFirst;
            private Node<Item> mCurrent;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.

            public BagEnum(Node<Item> first)
            {
                mMFirst = first;
                mCurrent = null;
            }

            public bool HasNext()
            { return mCurrent != null; }  // The last item in the bag will not have a next.

            public bool MoveNext() // Iterates the nodes and determines if it has a next item.
            {
                if(mCurrent == null) { mCurrent = mMFirst; } // Allows for the enumerator 
                                                             // to be positioned before the first element.
                else { mCurrent = mCurrent.Next; }
                return HasNext();
            }

            public void Reset()
            {
                mCurrent = null;
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public Item Current
            {
                get
                {
                    try
                    {
                        return mCurrent.Item;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
