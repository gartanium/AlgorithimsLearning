using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.AlgorithimAnalysis
{
    public class StopWatch
    {
        private int mBeginTime;

        /// <summary>
        /// Returns the time in milliseconds from the beginning of the timer, to the end.
        /// </summary>
        public int ElapsedTime(int currentTimeInMilliseconds)
        {
            return currentTimeInMilliseconds - mBeginTime;
        }

        public StopWatch(int beginTimeInMilliseconds)
        {
            this.mBeginTime = beginTimeInMilliseconds;
        }
        

    }
}
