//Ruth Bar Dagan ID:208317735
//Yael Suisa ID:318905114
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] A = new int[20];
                int[] B = new int[20];
                int[] C = new int[20];
                Random r = new Random();
                for (int i = 0; i < 20; i++)
                {
                    int tempA = r.Next(18, 123);
                    A[i] = tempA;
                    int tempB = r.Next(18, 123);
                    B[i] = tempB;
                    C[i] = tempA - tempB;
                    if (C[i] < 0)
                        C[i] = C[i] * -1;
                }
                for (int i = 0; i < 20; i++)
                    Console.Write("{0 ,-3} ", A[i]);
                Console.WriteLine();
                for (int i = 0; i < 20; i++)
                    Console.Write("{0 ,-3} ", B[i]);
                Console.WriteLine();
                for (int i = 0; i < 20; i++)
                    Console.Write("{0 ,-3} ", C[i]);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
