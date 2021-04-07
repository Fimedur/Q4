using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dblLinear(int n)
            {

                int[] u = new int[9999999];
                int pt2 = 0, pt3 = 0;

                for (int i = 0; i <= n; i++)
                {
                    u[i] = Math.Min(2 * u[pt2] + 1, 3 * u[pt3] + 1);
                    if (u[i] == 2 * u[pt2] + 1) pt2++;
                    if (u[i] == 3 * u[pt3] + 1) pt3++;
                    //Console.WriteLine(u[i]);
                }

                return u[n];

            };
            Console.WriteLine("Value of n =");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("U(" + a + ") = " + dblLinear(a));
            Console.ReadKey();
        }
    }
}
