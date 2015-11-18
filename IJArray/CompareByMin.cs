using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJArray
{
    class CompareByMin : IComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            if (a.Min() > b.Min())
                return 1;
            else if (a.Min() < b.Min())
                return -1;
            else
                return 0;
        }
    }
}
