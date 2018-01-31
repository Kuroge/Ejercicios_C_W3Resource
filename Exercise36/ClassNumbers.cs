using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36
{
    class ClassNumbers
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public ClassNumbers(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public bool CheckNumbers()
        {
            if(Num1 <= 10 && Num1 >= -10 || Num2 <= 10 && Num2 >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
