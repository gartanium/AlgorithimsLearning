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
            get { return 0; }
        }

        public Buffer()
        {
             
        }
        // Generate the string from the buffer.
        public string GetData()
        {
            // Create an inversted string from the left to right stack.
            string returnValue = "";
            while (mLeftToRightStack.Count > 0)
            {
                returnValue += mLeftToRightStack.Pop();
            }
            // Flip it because it's backwords.
            returnValue.Reverse();
            // The right to left stack is not backwords, add it to the return string. It is the second half of the line.
            while (mRightToLeftStack.Count > 0)
            {
                returnValue += mRightToLeftStack.Pop();
            }

            return returnValue;

        }
        
        public void insert(char c) // insert c at the cursor position.
        {
            mLeftToRightStack.Push(c);
        }

        public char get() // character at the cursor position.
        {
            return mLeftToRightStack.Peek();
        }

        public char delete() // Delete and return the character at the cursor.
        {
            return mLeftToRightStack.Pop();
        }

        public void left(int k) // move the cursor k positions to the left
        {
            while(k > 0)
            {
                mRightToLeftStack.Push(mLeftToRightStack.Pop());
                k--;
            }
        }

        public void right(int k) // move the kursor k positions to the right
        {
            while( k > 0)
            {
                mLeftToRightStack.Push(mRightToLeftStack.Pop());
                k--;
            }

        }

        
    }
}
