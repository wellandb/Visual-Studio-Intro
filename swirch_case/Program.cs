namespace swirch_case
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("Enter a positive number: ");
            x = Convert.ToInt16(Console.ReadLine());
            if(x>=0)
            {
                switch(x) 
                {
                    case 0:
                        Console.WriteLine("The value is zero");
                        break;
                    case 1:
                        Console.WriteLine("The value is one");
                        break;
                    case 2:
                        Console.WriteLine("The value is two");
                        break;
                    case 3:
                        Console.WriteLine("The value is three");
                        break;
                    case 4:
                        Console.WriteLine("The value is four");
                        break;
                    case 5:
                        Console.WriteLine("The value is five");
                        break;
                    default:
                        Console.WriteLine("The value is greater than five");
                        break;
                        
                }
            }
            else
            {
                Console.WriteLine("Negative Numbers not allowed");
            }
            Console.ReadLine();
            // Break can be used in a data structure like if, case or a loop and is used to leave the data structure without executing the rest of the code
            // Continue can be used in a loop to continue to the next loop without executing the rest of the code in that loop
            // goto can be used to skip a part of the code and go to a specific line
        }
    }
}
