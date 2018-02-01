using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53
{
    public class ClasArrayOdd
    {
        public int[] Array { get; set; }

        public ClasArrayOdd(int[] array)
        {
            Array = array;
        }
        public bool CheckOdd()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i]%2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
