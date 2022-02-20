namespace Functionality
{
    public class Run
    {
        public static string operation = "";
        public static void RunCalc()
        {
            decimal one = 0;
            decimal two = 0;
            decimal answer = 0;
            //string operation = "";

            try
            {
                Console.WriteLine("Write a number");
                one = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException)

            {
                Console.WriteLine($"{one} is not a valid character, you need to enter a number");
            }
            
            Console.WriteLine("Write an operation");
            operation = Console.ReadLine();
            OperationCheck.Check();

            try
            {
                Console.WriteLine("Write a second number");
                two = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"{two} is not a valid character, you need to enter a number");
            }

            History calculations = new History(one, operation, two, answer);
        }
    }
}
