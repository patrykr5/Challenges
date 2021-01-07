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
    }
}
