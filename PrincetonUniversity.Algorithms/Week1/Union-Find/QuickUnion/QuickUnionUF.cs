using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincetonUniversity.Algorithms.Part1.Week1.Union_Find.QuickUnion
{
    public class QuickUnionUF
    {
        private int[] id;

        //In the constructor, we initialize the main array with the starting index
        public QuickUnionUF(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
                id[i] = i;

        }

        //Two elements are connected if the ids of the elements are the same 
        public bool Connected(int p, int q)
        {
            return GetRoot(p) == GetRoot(q);
        }

        private int GetRoot(int node)
        {
            if (id[node] == node)
                return node;
            else
                return GetRoot(id[node]);
        }

        //to union two elements, we change the pointer of the root of P to point to the root of Q
        public void Union(int p, int q)
        {

            //We don't check that because the find in the quick union needs N operations
            if (Connected(p, q))
                return;

            int rootP = GetRoot(p);
            int rootQ = GetRoot(q);
            
            id[rootP] = rootQ;
        }
    }
}