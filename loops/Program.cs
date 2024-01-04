namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double count = 0;
            do
            {
                sum = sum + Math.Pow(count, 2);
                Console.WriteLine("count: {0}, sum: {1}", count, sum);
                count++;
            } while (count != 10);
            Console.ReadLine();

            sum = 0;
            count = 0;
            while (count != 10)
            {
                sum = sum + Math.Pow(count, 2);
                Console.WriteLine("count: {0}, sum: {1}", count, sum);
                count++;
            }
            Console.ReadLine();

            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
