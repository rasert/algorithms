using System;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace Algorithms.Test.SimilarCars
{
    public static class Solution
    {
        // O(n*m)

        // 1. Given cars = ["100", "110", "010", "011", "100"], the answer should be [2, 3, 2, 1, 2].
        // 2. Given cars = ["0011", "0111", "0111", "0110", "0000"], the answer should be [2, 3, 3, 2, 0].
        public static int[] solution(ITestOutputHelper output, string[] cars)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Dictionary<string, int> similar = new Dictionary<string, int>();
            Dictionary<string, int> count = new Dictionary<string, int>();
            int[] result = new int[cars.Length];

            foreach (string car in cars)
            {
                if (!similar.TryAdd(car, 0))
                    similar[car]++;

                if (!count.TryAdd(car, 1))
                    count[car]++;
            }

            foreach (string car in cars)
            {
                output.WriteLine($"Car: {car}");

                if (similar[car] >= count[car])
                    continue;

                for (int i = 0; i < car.Length; i++)
                {
                    bool feature = car[i] == '1';
                    string similarCar = car.Remove(i, 1).Insert(i, $"{Convert.ToInt32(!feature)}");
                    output.WriteLine($"Checking similar car: {similarCar}");
                    if (similar.ContainsKey(similarCar))
                    {
                        similar[car] += count[similarCar];
                        output.WriteLine($"Similar Car Matched: {similarCar}");
                    }
                }
            }

            for (int i = 0; i < cars.Length; i++)
            {
                string car = cars[i];
                result[i] = similar[car];
            }

            return result;
        }
    }
}

