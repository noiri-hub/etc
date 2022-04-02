using System;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {0,1,0,3,12};
            Solution.MoveZeroes(ref a);
            Console.WriteLine(string.Join(",", a));
        }
    }
}
