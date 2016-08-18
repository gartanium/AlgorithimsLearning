using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.StackLearning
{
    public class Buffer
    {
        private Stack<char> mLeftToRightStack;
        private Stack<char> mRightToLeftStack;
        

        
        public int CursorPosition
        {
            get { return mLeftToRightStack.Count - 1; }
        }
        /// <summary>
        /// Number of characters in the buffer.
        /// </summary>
        public int Size
        {
            get { return mLeftToRightStack.Count + mRightToLeftStack.Count; }
        }

        public Buffer()
        {
            mLeftToRightStack = new Stack<char>();
            mRightToLeftStack = new Stack<char>();
        }


        /// <summary>
        /// Generate a string from the buffer. 
        /// </summary>
        /// <returns></returns>
        public string GetData()
        {
            // Create an inversed string from the left to right stack.
            string inversedReturnValue = "";
            while (mLeftToRightStack.Count > 0)
            {
                inversedReturnValue += mLeftToRightStack.Pop();
            }
            // Flip it because it's backwords.
            inversedReturnValue.Reverse();
            // The right to left stack is not backwords, add it to the return string. It is the second half of the line.
            while (mRightToLeftStack.Count > 0)
            {
                inversedReturnValue += mRightToLeftStack.Pop();
            }

            string myReturnString = "";
            for(int i = (inversedReturnValue.Length - 1); i >= 0; i--)
            {
                myReturnString += inversedReturnValue.ElementAt(i);
            }
            return myReturnString;

        }


        /// <summary>
        /// insert c at the cursor position. 
        /// </summary>
        /// <param name="c"></param>
        public void Insert(char c) 
        {
            mLeftToRightStack.Push(c);
        }


        /// <summary>
        /// character at the cursor position.
        /// </summary>
        /// <returns></returns>
        public char Get()
        {
            return mLeftToRightStack.Peek();
        }


        /// <summary>
        /// Delete and return the character at the cursor. 
        /// </summary>
        /// <returns></returns>
        public char Delete() 
        {
            return mLeftToRightStack.Pop();
        }


        /// <summary>
        /// move the cursor k positions to the left
        /// </summary>
        /// <param name="k"></param>
        public void Left(int k) 
        {
            while(k > 0)
            {
                mRightToLeftStack.Push(mLeftToRightStack.Pop());
                k--;
            }
        }


        /// <summary>
        /// move the cursor k positions to the right 
        /// </summary>
        /// <param name="k"></param>
        public void Right(int k) 
        {
            while( k > 0)
            {
                mLeftToRightStack.Push(mRightToLeftStack.Pop());
                k--;
            }

        }

        
    }
}
