using System;
using System.Collections.Generic;

namespace GetAllPermutationsForGivenSetOfIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = new List<int>() { 1, 2, 3 };

			var output = get_permutations(input);
			Console.Write("Output: ");
			foreach (var item in output)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("There are " + output.Count + " permutations.");


		}
		public static List<List<int>> get_permutations(List<int> arr)
		{
			List<List<int>> result = new List<List<int>>();
			result = helper(arr, 0, result);
			return result;
		}
		public static List<List<int>> helper(List<int> arr, int i, List<List<int>> result)
		{
			if (i  >= arr.Count)
			{

				result.Add(new List<int>(arr));

			} else
			{
				for (int x = i; x < arr.Count; x++)
				{
					//swap
					int temp1 = arr[i];
					arr[i] = arr[x];
					arr[x] = temp1;

					helper(arr, i + 1, result);

					int temp = arr[x];
					arr[x] = arr[i];
					arr[i] = temp;
				}
			}
			return result;
		}
	}
}
