using DailyCodeChallenges.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodeChallenges.Challenges
{
    public class Challenge2 : IChallenge
    {
        /*
         * Given an array of integers, 
         * return a new array such that each element at index i of the new array
         * is the product of all the numbers in the original array 
         * except the one at i.
         */
        public int[] array = new int[] {1, 2, 3, 4, 5};
        public string result;
        public Challenge2(int[] _arr) {
            this.array = _arr;
        }
        public string Run()
        {
            
            result = "[";
            for(int ind =0; ind < array.Length; ind++)
            {
                int total = 1;
                for (int prodInd = 0; prodInd < array.Length; prodInd++)
                {
                    if(ind != prodInd)
                    {
                        total *= array[prodInd];
                    }
                }
                result += "" + total;
                if(ind + 1 < array.Length)
                {
                    result += ",";
                }
            }
            result += "]";
            return result;
        }
    }
}
