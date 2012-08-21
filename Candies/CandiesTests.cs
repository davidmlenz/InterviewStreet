using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace Candies
{
	public class CandiesTests
	{
		private static readonly string sampleInputLocation = "/Users/davidlenz/Dropbox/InterviewStreet/InterviewStreet/Candies/sampleinputs/";

		[Test]
		public void TestBaseCase ()
		{
			var input = new List<Int32>();
			input.Add(1);

			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(1, result);
		}

		[Test]
		public void TestSimpleAscension ()
		{
			var input = new List<Int32>();
			input.Add(1);
			input.Add(2);
			input.Add(3);
			input.Add(4);
			input.Add(5);

			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(15, result);
		}

		[Test]
		public void TestSimpleDecension ()
		{
			var input = new List<Int32>();
			input.Add(5);
			input.Add(4);
			input.Add(3);
			input.Add(2);
			input.Add(1);


			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(15, result);
		}

		[Test]
		public void TestSimpleDecension1 ()
		{
			var input = new List<Int32>();
			input.Add(2);
			input.Add(1);


			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(3, result);
		}

		[Test]
		public void DuplicatesOnAscent ()
		{
			var input = new List<Int32>();
			input.Add(1);
			input.Add(2);
			input.Add(3);
			input.Add(3);
			input.Add(3);
			input.Add(4);
			input.Add(5);
			input.Add(4);
			input.Add(3);
			input.Add(2);
			input.Add(1);


			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(25, result);
		}

		[Test]
		public void DuplicatesOnMid ()
		{
			var input = new List<Int32>();
			input.Add(1);
			input.Add(2);
			input.Add(3);
			input.Add(4);
			input.Add(5);
			input.Add(5);
			input.Add(5);
			input.Add(4);
			input.Add(3);
			input.Add(2);
			input.Add(1);


			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(31, result);
		}

		[Test]
		public void DuplicatesOnDesc ()
		{
			var input = new List<Int32>();
			input.Add(1);
			input.Add(2);
			input.Add(3);
			input.Add(4);
			input.Add(5);
			input.Add(4);
			input.Add(3);
			input.Add(3);
			input.Add(3);
			input.Add(2);
			input.Add(1);


			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(25, result);
		}

		[Test]
		public void UpAndDown ()
		{
			var input = new List<Int32>();
			input.Add(1);
			input.Add(2);
			input.Add(3);
			input.Add(4);
			input.Add(5);
			input.Add(5);
			input.Add(4);
			input.Add(3);
			input.Add(2);
			input.Add(1);


			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(30, result);
		}

		[Test]
		public void WeirdSubmissionError ()
		{
			var input = new List<Int32>();
			input.Add(3);
			input.Add(1);
			input.Add(2);
			input.Add(2);



			var result = Candies.MainClass.SolveCandies(input);
			Assert.AreEqual(6, result);
		}


		[Test]
		public void TestKnownInput00 ()
		{
			var input = File.ReadAllLines (sampleInputLocation + "input00.txt");
			var output = File.ReadAllLines (sampleInputLocation + "output00.txt");
			var expected = Int32.Parse (output [0]);


			var studentRanking = new List<Int32> ();


			foreach(var s in input)
			{
				studentRanking.Add (Int32.Parse(s));
			}
			studentRanking.RemoveAt(0);

			var result = Candies.MainClass.SolveCandies(studentRanking);
			Assert.AreEqual(expected, result);

		}

		[Test]
		public void TestKnownInput01 ()
		{
			var input = File.ReadAllLines (sampleInputLocation + "input01.txt");
			var output = File.ReadAllLines (sampleInputLocation + "output01.txt");
			var expected = Int32.Parse (output [0]);


			var studentRanking = new List<Int32> ();


			foreach(var s in input)
			{
				studentRanking.Add (Int32.Parse(s));
			}
			studentRanking.RemoveAt(0);

			var result = Candies.MainClass.SolveCandies(studentRanking);
			Assert.AreEqual(expected, result);

		}
	}
}



