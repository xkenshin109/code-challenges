using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyCodeChallenges.Interfaces;

namespace DailyCodeChallenges
{
    class Program
    {
        public List<IChallenge> _challenges = new List<IChallenge>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
