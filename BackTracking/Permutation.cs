using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackTracking
{
	public class Permutation
	{
		public List<string> results;

		public Permutation (List<int> text)
		{
			results = new List<string> ((int)Math.Pow(2,text.Count));
			int[] a = new int[5];
			GeneratePerms (a,0,text);
		}

		void GeneratePerms(int[] a,int k,List<int> input)
		{
			List<int> candidates = new List<int> ();
			if (is_solution(a,k,input)) {
				process_solution (a,k,input);
			} else {
				k += 1;
				construct_candidates (a, k, input, candidates);
				foreach (var item in candidates) {
					a [k] = item;
					GeneratePerms (a,k,input);
				}
			}
		}

		bool is_solution(int[] a,int k,List<int> input)
		{
			return input.Count == k;
		}

		void process_solution(int[] a,int k,List<int> input)
		{
			string r = "";
			for (int i = 1; i < k + 1; i++) {
				r += a [i];
			}
			results.Add (r);
		}

		void construct_candidates(int[] a,int k,List<int> input,List<int> c)
		{
			input.ForEach(s => c.Add(s)); 
			for (int i = 1; i < k ; i++) {
				c.Remove (a [i]);
			}
		}
	}
}

