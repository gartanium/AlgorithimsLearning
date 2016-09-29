using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsInterface
{
    public class GUI
    {
        protected int width;
        protected int height;
        protected int cursorX;
        protected int cursorY;

        public GUI(int width, int height, int cursorX, int cursorY)
        {
            this.width = width;
            this.height = height;
            this.cursorX = cursorX;
            this.cursorY = cursorY;
        }
        


        public string GetGui()
        {
            string myReturnString = "";
            for(int i = 0; i < width; i++)
            {
                
                for (int j = 0; j < height; j++)
                {
                    myReturnString += "c";                           
                }

                myReturnString += "\n";
            }

            return myReturnString;
        }

    }
}
