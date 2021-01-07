using System.Collections.Generic;

namespace Challenges.Library.Challenges
{
    public class AlgorithmChallenge
    {
        // https://edabit.com/challenge/PyLwHawLofXKZWw4i
        // The Collatz Conjecture
        public int CollatzConjecture(int num)
        {
            // n is even -> n / 2
            // n is odd -> n * 3 + 1

            int step = 0;

            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = num * 3 + 1;
                }

                step++;
            }

            return step;
        }

        // https://edabit.com/challenge/ccZBsRp6pX869gyqx
        // The Karaca's Encryption Algorithm
        public string KaracaEncrypt(string word)
        {
            //reverse
            //replace all vowels
            //add aca to end word

            const string endWord = "aca";
            Dictionary<char, int> vowelsReplaceNumberDict = new Dictionary<char, int>
            {
                { 'a', 0 },
                { 'e', 1 },
                { 'i', 2 },
                { 'o', 2 },
                { 'u', 3 }
            };

            string encrypt = string.Empty;
            for (int i = word.Length - 1; i > -1; i--)
            {
                char letter = word[i];
                if (vowelsReplaceNumberDict.ContainsKey(letter))
                {
                    encrypt += vowelsReplaceNumberDict[letter];
                    continue;
                }
                encrypt += letter;
            }

            return encrypt + endWord;
        }
    }
}
