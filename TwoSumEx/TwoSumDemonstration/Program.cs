using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);

        if (result != null)
        {
            Console.WriteLine($"Indices of the two numbers that add up to {target}: {result[0]} and {result[1]}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            // Store the current number and its index in the map
            // Armazena o número atual e o índice no map

            numIndices[nums[i]] = i;
        }

        // No solution found
        // Retorna alguma coisa como null
        return null;
    }
}
