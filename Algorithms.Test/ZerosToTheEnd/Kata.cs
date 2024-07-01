namespace Algorithms.Test.ZerosToTheEnd
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    continue;

                arr[j] = arr[i];
                j++;
            }

            while (j < arr.Length)
            {
                arr[j] = 0;
                j++;
            }

            return arr;
        }
    }
}
