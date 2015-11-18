using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJArray
{
    public class CompareByMax : IComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            if (a.Max() > b.Max())
                return 1;
            else if (a.Max() < b.Max())
                return -1;
            else
                return 0;
        }
    }
}
