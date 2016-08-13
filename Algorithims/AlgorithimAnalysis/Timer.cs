using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.AlgorithimAnalysis
{
    public class Timer
    {
        private int mBeginTime;

        /// <summary>
        /// Returns the time in milliseconds from the beginning of the timer, to the end.
        /// </summary>
        public int mRunTime(int currentTimeInMilliseconds)
        {
            return currentTimeInMilliseconds - mBeginTime;
        }

        public Timer(int beginTimeInMilliseconds)
        {
            this.mBeginTime = beginTimeInMilliseconds;
        }


    }
}
