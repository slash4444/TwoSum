# TwoSum

This C# code defines a program that solves the "Two Sum" problem. The goal of the problem is to find two numbers in an array such that they add up to a specific target number. Let's break down the code step by step:

Import necessary libraries:

using System;
using System.Collections.Generic;
These statements include the required namespaces for handling input and output and working with dictionaries.

Define the Program class:

csharp
Copy code
class Program
{
    // ...
}
The entire code is encapsulated within this class.

Define the Main method:

csharp
Copy code
static void Main(string[] args)
{
    // ...
}
The Main method is the entry point of the program, where execution begins.

Initialize an integer array nums and a target integer target:

csharp
Copy code
int[] nums = { 2, 7, 11, 15 };
int target = 9;
In this example, the nums array contains [2, 7, 11, 15], and the target is set to 9.

Call the TwoSum method to find the indices of two numbers that add up to the target:

csharp
Copy code
int[] result = TwoSum(nums, target);
The TwoSum method is responsible for solving the problem and returns an array of indices if a solution is found, or null if no solution exists.

Check the result and print the output:

csharp
Copy code
if (result != null)
{
    Console.WriteLine($"Indices of the two numbers that add up to {target}: {result[0]} and {result[1]}");
}
else
{
    Console.WriteLine("No solution found.");
}
If a solution is found (i.e., result is not null), it prints the indices of the two numbers that add up to the target. Otherwise, it prints "No solution found."

Define the TwoSum method:

csharp
Copy code
static int[] TwoSum(int[] nums, int target)
{
    // ...
}
This is the heart of the code. The TwoSum method takes an array of integers (nums) and a target integer (target) as parameters and returns an array of indices of two numbers in the nums array that add up to the target.

Inside the TwoSum method, a Dictionary<int, int> called numIndices is created to store the numbers from the nums array as keys and their corresponding indices as values.

A for loop is used to iterate through the nums array:

csharp
Copy code
for (int i = 0; i < nums.Length; i++)
{
    // ...
}
Inside the loop, it calculates the complement of the current number with respect to the target:

csharp
Copy code
int complement = target - nums[i];
It checks if the complement exists in the numIndices dictionary:

csharp
Copy code
if (numIndices.ContainsKey(complement))
{
    return new int[] { numIndices[complement], i };
}
If the complement exists, it means that adding the current number to the complement will result in the target, so it returns an array containing the indices of the two numbers that add up to the target.

If no solution is found within the loop, it stores the current number and its index in the numIndices dictionary for future reference:
csharp
Copy code
numIndices[nums[i]] = i;
If the loop completes without finding a solution, it returns null to indicate that no solution was found.
In summary, this code demonstrates a simple and efficient algorithm for solving the "Two Sum" problem using a dictionary to keep track of the numbers and their indices as it iterates through the array. If a pair of numbers is found that adds up to the target, their indices are returned as the result; otherwise, it returns null to indicate that no such pair exists.





