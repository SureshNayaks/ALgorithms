using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace edabit
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(XO("xoxoxooooxo"));
		}
		public static Boolean XO(string txt)
		{
			string s = txt.ToLower();
			string x = "";
			string o = "";
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'x')
				{
					x += s[i];
				}
				else if (s[i] == 'o')
				{
					o += s[i];
				}
			}
			if (x.Length == 0 && o.Length == 0)
			{
				return true;
			}
			else if (x.Length == o.Length)
			{
				return true;
			}

			else
			{
				return false;
			}
		}
		public static Boolean checkcase(char a,char b)
		{

			if(char.IsUpper(a) && char.IsUpper(b))
			{
				return true;
			}
			return false;
		}

		public static int DuplicateCount(string str)
		{
			Hashtable hashtable = new Hashtable();
			int count = 0;
			for(int i = 0; i < str.Length; i++)
			{
				if (hashtable.Contains(str[i]))
				{
					count++;
				}
				else
				{
					hashtable.Add(str[i], 1);
				}
			}
			return count;
		} 
		public static double[] UniqueSort(double[] arr)
		{
			Array.Sort(arr);
			var stuff = arr.Distinct();
			return stuff.ToArray();
		}

		public static int Solve(int[] boxes)
		{
			int n = boxes.Length;
			int[,] mul = new int[n, n];
			for (int i = 0; i < n; i++)
			{
				mul[i, i] = boxes[i];
				if (i != n - 1)
					mul[i, i + 1] = (boxes[i] > boxes[i + 1]) ? boxes[i] : boxes[i + 1];
			}
			for (int i = 2; i < n; i++)
				for (int j = 0, k = i; k < n; j++, k++)
					mul[j, k] = Math.Max(boxes[j] + Math.Min(mul[j + 2, k], mul[j + 1, k - 1]), boxes[k] + Math.Min(mul[j + 1, k - 1], mul[j, k - 2]));
			return mul[0, n - 1] * 2 - boxes.Sum();
		}

		public static string FormatPhoneNumber(int[] numbers)
		{
			StringBuilder b = new StringBuilder(string.Concat(numbers.Select(n => n.ToString())));
			b.Insert(0, "(");
			b.Insert(4, ") ");
			b.Insert(9, "-");
			return b.ToString();
		}

		public static int[] FilterArray(object[] arr)
		{
			var ints = new List<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] is Int32)
				{
					ints.Add((int)arr[i]);
				}
			}
			return ints.ToArray();
		}
		public static int MajorSum(int[] arr)
		{
			int[] sums = { arr.Where(x => x > 0)
					.Sum(), arr.Where(x => x < 0).Sum(), arr.Where(x => x == 0).Count() };
			return sums.OrderByDescending(x => Math.Abs(x)).First();
		}




	}
	
   
}
