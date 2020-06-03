using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var job4 = new Smallest_Difference();
            var dhjdd = job4.SmallestDifference(new int[] { -1,5,10,20,28,3 }, new int[] {26,134,135,15,17 });

            var job3 = new Three_Number_Sum();
            var result3 = job3.ThreeNumberSum2(new int[] {12,3,1,2,-6,5,-8,6 }, 18);

            var job = new Two_Number_Sum();
            var outp = job.TwoNumberSum3(new int[] { 3, 5, -4, 8, 11, 1, -1, 8, 6 }, 10);
            Console.WriteLine("Hello World!");
        }
    }
}
