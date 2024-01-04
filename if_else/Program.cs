namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber) {
                Console.WriteLine("First number is larger than second number");
            }
            else if(firstNumber == secondNumber) 
            {
                Console.WriteLine("Second number is equal to first number");
            } else
            {
                Console.WriteLine("Second number is larger than first number");
            }

        }
    }
}
