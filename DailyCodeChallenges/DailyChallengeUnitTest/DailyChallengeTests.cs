using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyCodeChallenges.Interfaces;
using DailyCodeChallenges;
using DailyCodeChallenges.Challenges;

namespace DailyChallengeUnitTest
{
    [TestClass]
    public class DailyChallengeTests
    {
        [TestMethod]
        public void DailyChallenge1()
        {
            IChallenge _interface = new Challenge1(17);
            Assert.AreEqual("True",_interface.Run());
        }
        [TestMethod]
        public void DailyChallenge2()
        {
            IChallenge _interface = new Challenge2(new int[]{1, 2, 3, 4, 5});
            Assert.AreEqual("[120,60,40,30,24]",_interface.Run());
        }
    }
}
