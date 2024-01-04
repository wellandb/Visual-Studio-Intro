using System.ComponentModel;

namespace FunctionBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Function to add two numbers
            int a = 5;
            int b = 4;
            int sum = 0;

            sum = Add(a, b);
            Console.WriteLine("sum: {0}", sum);
            Console.WriteLine("Square of sum: {0}", Square(sum));
            Console.ReadLine();
        }
        // Function to add two numbers
        public static int Add(int a, int b) {  return a + b; }

        public static int Square(int a) { return a * a; }
    }
}
