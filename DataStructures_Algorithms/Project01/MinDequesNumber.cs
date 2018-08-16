using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructures_Algorithms.Project01
{
    public class MinDequesNumber
    {
        public int Solve(int[] data)
        {
            int numberOfDeques = 1;

            // loop to decide each element
            for (int element = 1; element < data.Length; element++)
            {
                bool makeNewDeque = true;

                // loop to check if it belongs to any deques already created.
                // check only upto the current element in question
                for (int range = 0; range < element; range++)
                {         
                    bool hasBetween = false;

                    // loop to check if intermediates exist
                    for (int iterator = 0; iterator < data.Length; iterator++)
                    {
                        // No need to check if it's element or range
                        if (iterator == element || iterator == range) continue;                        

                        if (compareRange(data[range], data[element], data[iterator]))
                        {
                            // there are values inbetween range and element, 
                            // so not possible to create deque that can be combined later
                            hasBetween = true;
                            break;
                        }
                    }

                    // This deque ~ element combination doesnt belong together
                    // continue to check next deque ~ element combination
                    if (hasBetween) continue;                    
                    else
                    {
                        // This deque ~ element combination can be joined together 
                        // as there are no elements that can go inbetween
                        // so no need to make new deque
                        makeNewDeque = false;
                        break;
                    }                  
                }

                // Judgement
                if (makeNewDeque) numberOfDeques++;                
            }
            return numberOfDeques;
        }

        private bool compareRange(int left, int right, int val)
        {      
            if (left > right)
            {
                int temp = left;
                left = right;
                right = temp;
            }  
            return (val > left && val < right);
        }        
    }  
}
