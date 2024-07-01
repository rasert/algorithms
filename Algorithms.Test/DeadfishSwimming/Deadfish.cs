using System;
using System.Collections.Generic;

namespace Algorithms.Test.DeadfishSwimming
{
    public class Deadfish
    {
        public static int[] Parse(string data)
        {
            List<int> result = [];
            int current = 0;

            // Return the output array, and ignore all non-op characters
            foreach (char c in data)
            {
                switch (c)
                {
                    case 'i':
                        current++;
                        break;
                    case 'd':
                        current--;
                        break;
                    case 's':
                        current = (int)Math.Pow(current, 2);
                        break;
                    case 'o':
                        result.Add(current);
                        break;
                    default:
                        break;
                }
            }

            return [.. result];
        }
    }
}
