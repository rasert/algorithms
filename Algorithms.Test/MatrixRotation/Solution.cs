using System;

namespace Algorithms.Test.MatrixRotation
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int lastIndex = matrix.Length - 1;
            // Layers = square radius
            for (int layer = 0; layer < matrix.Length / 2; layer++)
            {
                int low = layer;
                int high = lastIndex - layer;
                // 'i' cannot be used as an index
                for (int i = 0; i < high - low; i++)
                {
                    Console.WriteLine($"Layer: {layer} Iteration: {i}");
                    int temp = matrix[low][i + layer];
                    matrix[low][i + layer] = matrix[high - i][low];
                    Console.WriteLine($"[{low},{i + layer}]={matrix[high - i][low]}");
                    matrix[high - i][low] = matrix[high][high - i];
                    Console.WriteLine($"[{high - i},{low}]={matrix[high][high - i]}");
                    matrix[high][high - i] = matrix[i + layer][high];
                    Console.WriteLine($"[{high},{high - i}]={matrix[i + layer][high]}");
                    matrix[i + layer][high] = temp;
                    Console.WriteLine($"[{i + layer},{high}]={temp}");
                }
            }
            Console.WriteLine("Finished!");
        }
    }
}