using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincetonUniversity.Algorithms.Part1.Week1.Union_Find.QuickFind
{
    public class QuickFindUF
    {
        private int[] id;

        //In the constructor, we initialize the main array with the starting index
        public QuickFindUF(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
                id[i] = i;

        }

        //Two elements are connected if the ids of the elements are the same 
        public bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

        //to union two elements, we change the value of all the elements that have the value of the first
        //with the value of the second element
        public void Union(int p, int q)
        {
            if (Connected(p, q))
                return;

            int valueP = id[p];
            int valueQ = id[q];

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == valueP)
                    id[i] = valueQ;
            }

        }

    }
}
