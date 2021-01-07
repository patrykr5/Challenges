using Challenges.Library.Challenges;
using NUnit.Framework;

namespace Challenges.Library.Tests.Challenges
{
    [TestFixture]
    public class AlgorithmChallengeTest
    {
        private AlgorithmChallenge algorithmChallenge;

        [SetUp]
        public void Setup()
        {
            algorithmChallenge = new AlgorithmChallenge();
        }

        [TearDown]
        public void Cleanup()
        {
            algorithmChallenge = null;
        }

        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 7)]
        [TestCase(10, ExpectedResult = 6)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(345, ExpectedResult = 125)]
        [TestCase(72, ExpectedResult = 22)]
        public int CollatzConjecture_Test(int num)
        {
            return algorithmChallenge.CollatzConjecture(num);
        }

        [TestCase("karaca", ExpectedResult = "0c0r0kaca")]
        [TestCase("burak", ExpectedResult = "k0r3baca")]
        [TestCase("alpaca", ExpectedResult = "0c0pl0aca")]
        [TestCase("banana", ExpectedResult = "0n0n0baca")]
        [TestCase("hello", ExpectedResult = "2ll1haca")]
        public string KaracaEncrypt_Test(string word)
        {
            return algorithmChallenge.KaracaEncrypt(word);
        }
    }
}
