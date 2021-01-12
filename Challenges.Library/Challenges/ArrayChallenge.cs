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
        // Solution version 1
        /*public bool CheckIfExistsPairEqualTargetValue(int[] A, int targetValue)
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
        }*/

        // Challenge not from Edabit**
        // Solution version 2
        public bool CheckIfExistsPairEqualTargetValue(int[] A, int targetValue)
        {
            for (int i = A.Length - 1; i >= 0; i--)
            {
                var highValue = A[i];
                if (highValue > targetValue)
                {
                    continue;
                }

                for (int j = 0; j < i; j++)
                {
                    if (highValue + A[j] == targetValue)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Challenge not from Edabit**
        public bool CheckIfExistsSamePairEqualTargetValue(int[] A, int targetValue)
        {
            //return A.Count(x => x == targetValue) >= 2; // Solution version 1

            // Solution version 2
            for (int i = 0; i < A.Length; i++)
            {
                int currentValue = A[i];

                if (currentValue > targetValue)
                {
                    break;
                }

                if (currentValue * 2 == targetValue)
                {
                    if (currentValue + A[i + 1] != targetValue)
                    {
                        return false;
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
