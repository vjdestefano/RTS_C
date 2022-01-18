using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsoleApp1
{
    public class RTS
    {

        public RTS() { 
        
        }
        public object aboveBelow(List<int> unsortedListRTS, int compValue){

            int above = 0;
            int below = 0;
 
            for(var i = 0; i< unsortedListRTS.Count; i++)
            {
                int valueInList = unsortedListRTS[i];
                if(valueInList > compValue)
                {
                    above++;
                }
                if (valueInList < compValue)
                {
                    below ++;
                }

            }
            dynamic aboveBelowRTS = new
            {
                above = above,
                below = below
            };
            return aboveBelowRTS;
        }


        public string stringRotation(string randomString, int rightRotation)
        {
            string leftValue = randomString.Substring(randomString.Length - rightRotation);
            string rightValue = randomString.Substring(0, randomString.Length - rightRotation);

            string reOrderString = leftValue + rightValue;

            return reOrderString;
        }

    }
}
