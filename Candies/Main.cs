/// <summary>
/// Interview Street Candies Problem
/// https://www.interviewstreet.com/challenges/dashboard/#problem/4fe12e4cbb829
/// 
/// Submission History:
/// August 21, 2012 : Passed 10/10 Test Cases. 
/// Push to Git
/// </summary>

using System;
using System.Collections.Generic;

namespace Candies
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			var line1 = System.Console.ReadLine().Trim();
            var N = Int32.Parse(line1);

			var input = new List<Int32>();

            for (var i = 0; i < N; i++) {
				input.Add (Int32.Parse(System.Console.ReadLine().Trim()));
            }

			var result = SolveCandies(input);

			System.Console.WriteLine(result.ToString().Trim());
		}



		public static int SolveCandies (List<Int32> studentRankings)
		{

			var requiredCandies = 0;

			// Split into sub arrays.

			var previousValue = 0;
			var subArray = new List<Int32>();
			var incline = true;
			var midIndex = 0;
			var startCandiesAt = 1;

			foreach (var student in studentRankings)
			{
				if (incline)
				{
					if (previousValue <= student)
					{
						subArray.Add(student);
						previousValue = student;
						midIndex = subArray.Count - 1;
					}
					else
					{
						subArray.Add(student);
						previousValue = student;
						incline = false;
					}
				}
				else
				{
					if (student <= previousValue)
					{
						subArray.Add(student);
						previousValue = student;
					}
					else
					{
						requiredCandies += SolveSubArray(subArray, midIndex,startCandiesAt);
						startCandiesAt = 2;

						incline = true;
						midIndex = 0;
						subArray = new List<Int32>();
						subArray.Add(student);
						previousValue = student;
					}
				}
			}

			requiredCandies += SolveSubArray(subArray, midIndex,startCandiesAt);

			return requiredCandies;
		}


		public static int SolveSubArray (List<Int32> studentRankings, int middle, int startCandiesAt)
		{
			var totalCandies = 0;
			var candyToStudent = startCandiesAt;

			var lastValue = 0;
			var middleAssignedValue = 0;

			// Go up
			for (int i = 0; i <= middle; i++)
			{
				if (studentRankings [i] == lastValue)
				{
					candyToStudent = 1;
				}

				if (i == middle)
				{
					middleAssignedValue = candyToStudent;
				}

				lastValue = studentRankings [i];
				totalCandies += candyToStudent;
				candyToStudent++;
			}


			lastValue = 0;
			candyToStudent = 1;

			// Go down
			for (int i = studentRankings.Count - 1; i > middle; i--)
			{
				if (studentRankings [i] == lastValue)
				{
					candyToStudent = 1;
				}

				lastValue = studentRankings [i];
				totalCandies += candyToStudent;
				candyToStudent++;
			}

			// Check Middle
			if (candyToStudent >= middleAssignedValue)
			{
				totalCandies -= middleAssignedValue;
				totalCandies += candyToStudent;
			} 

			return totalCandies;

		}
	}
}

