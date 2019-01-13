using DailyCodeChallenges.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodeChallenges
{
    public class Challenge1 : IChallenge
    {
        /*
         * Given an Array List of Integers and a input by user
         * If any two numbers in the list add up then return true
         * i.e = [1,2,3,4] user_input: 6 => true
         */
        public int[] array = new int[] {10, 15, 3, 7};
        public int input;
        public bool success;
        public Challenge1(int _i)
        {
            this.input = _i;
        }
        public string Run()
        {
            //This is just one easy way to solve this problem. 
            //
            for(int ind = 0; ind < array.Length; ind++)
            {
                for(int ind2 = 0; ind2 < array.Length; ind2++)
                {
                    if(ind != ind2)
                    {
                        if(array[ind] + array[ind2] == input)
                        {
                            this.success = true;
                        }
                    }
                }
            }
            return success.ToString();
        }
    }
}
