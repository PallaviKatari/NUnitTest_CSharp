using System;
namespace UnitTest
{
    public class Program
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public static void Main()
        {
            Program program = new Program();
            int result = program.Add(10, 20);
            Console.WriteLine(result);
        }
    }
}