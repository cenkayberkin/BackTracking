using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackTracking
{
	public class Subset
	{
		bool finished;
		List<string> results;
		public Subset (int n)
		{
			finished = false;
			int[] A = new int[100];
			results = new List<string> ();
			SolveSubset (A,0,n);
		}

		void SolveSubset(int[] a,int k, int input)
		{
			int[] c= new int[100];
			int nCandidates;

			if (is_a_solution (a, k, input)) {
				process_solution (a, k);
			} else {
				k = k + 1;
				construct_candidates (a,k,input,c,out nCandidates);
				for (int i = 0; i < nCandidates; i++) {
					a[k] = c[i];
					SolveSubset (a,k,input);
					if (finished) {
						return;
					}
				}
			}
		}

		void construct_candidates(int[] a,int k,int input,int[] c,out int nCandidates)
		{
			c [0] = 0;
			c [1] = 1;
			nCandidates = 2;
		}

		bool is_a_solution(int[] a, int k, int n)
		{
			return (k == n);
		}

		void process_solution(int[] a, int k)
		{
			string s = string.Empty;
			for (int i = 1; i < k + 1; i++) {
				if (a[i] == 1) {
					s += i.ToString();
				}
			}
			results.Add (s);
		}
	}
}

