namespace Challenges.Library.Challenges
{
    public class ArrayChallenge
    {
        // https://edabit.com/challenge/2QvnWexKoLfcJkSsc
        // Array of Multiples
        public int[] ArrayOfMultiples(int num, int length)
        {
            int[] targetArray = new int[length];

            targetArray[0] = num;
            for (int i = 1; i < length; i++)
            {
                targetArray[i] = targetArray[i - 1] + num;
            }

            return targetArray;
        }

        // Challenge not from Edabit**
        public bool CheckIfExistsPairEqualTargetValue(int[] A, int targetValue)
        {
            int low = 0;
            int high = A.Length - 1;

            while (low <= high)
            {
                if (A[high] > targetValue)
                {
                    high -= 1;
                }
                else if (A[low] + A[high] == targetValue)
                {
                    return true;
                }
                else if (low == high)
                {
                    high -= 1;
                    low = 0;
                }
                else
                {
                    low += 1;
                }
            }

            return false;
        }
    }
}
