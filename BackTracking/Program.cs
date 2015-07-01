using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackTracking
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Subset s = new Subset (3);
			List<int> list = new List<int>(){1,2,3};
			Permutation p = new Permutation(list);

			Console.WriteLine ("Hello World!");
		}
	}
}
