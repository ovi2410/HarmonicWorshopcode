// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace HarmonicNo
{
    class Program
    {
        static double NthHarmonic(int N)
        {
            float harmonic = 1;
            int i;
            for(i = 2;i <=N;i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;
        }
        //driver code
        static public void Main()
        {
            int N = 8;
            Console.WriteLine(NthHarmonic (N));
        }
    }
}