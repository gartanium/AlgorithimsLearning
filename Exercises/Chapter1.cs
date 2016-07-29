using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Chapter1
    {
        /// <summary>
        /// Inputs a value, n, and returns the largest int not larger than the base 2 logarithm of N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int lg(int n)
        {
            return 0;
        }

        public static int LogBase2(int n)
        {
            if (IsEven(n))
            {
                int power = 0;
                while((Math.Pow(2, power) != n))
                {
                    power++;
                }

                return power;
            }
            else
                throw new ArgumentException("n must be even!", n.ToString());
        }

        public static bool IsEven(int n)
        {
            if ((float)(n % 2) == 0)
            {
                return true;
            }
            else return false;
        }


        /// <summary>
        /// Returns the value of x to the power of y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y">A positive integer</param>
        /// <returns></returns>
        public static int Pow(int x, int y)
        {
            if(y == 0 && x != 0) // A number to the power of 0 is 1
            {
                return 1;
            }
            if(y < 0) // If y is not negative.
            {
                throw new ArgumentException("Make sure y is positive!");
            }
            if(x == 0)
            {
                return 0;
            }

            int returnInt = 1;
            for(int i = 0; i < y; i++)
            {
                returnInt *= x;
            }
            return returnInt;
            

        }
    }
}
