namespace FirstProgram
{
    public class Program
    {
        static void Main()
        {
            Arithmetic arithmetic = new Arithmetic();
            int sum = arithmetic.Add(1,2);
            Console.WriteLine($"sum: {sum}");
            Multiplication mult = new Multiplication();
            mult.Divide(1,2);
        }
    }
}
