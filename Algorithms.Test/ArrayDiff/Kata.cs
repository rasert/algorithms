using System.Collections.Generic;

namespace Algorithms.Test.ArrayDiff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            HashSet<int> set = new();

            foreach (int item in b)
            {
                set.Add(item);
            }

            List<int> result = new();
            foreach (int item in a)
            {
                if (!set.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
