using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestTwo
{
    class Program
    {
        static void Main(string[] args)
        {
           var intetest = solution(91);
        }
        public static int solution(int n)
        {
            int[] d = new int[30];
            int L = 0;
            int p;
            while (n > 0)
            {
                d[L] = n % 2;
                n /= 2;
                L++;
                //L elements in array
            }
            // p is binary period
            // d is binary array
            for (p = 1; p <=L/2; p++)
             //loop over elements in array (d)
            {
                int i;
                bool ok = true;
                for (i = 0; i < L - p; i++)
                {
                    if (d[i] != d[i + p])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    return p;
                }
            }
            return -1;
        }
    }
}
