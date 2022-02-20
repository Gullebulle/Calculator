namespace Functionality
{
    public class OperationCheck
    {
        public static void Check()
        {
            if (Run.operation == "xyzzy"){
                Console.WriteLine("Nothing happens");
            } 
            else if (Run.operation == "+") {
            }
            else if (Run.operation == "-"){
            }
            else if (Run.operation == "/"){
            }
            else if(Run.operation == "*"){
            }
            else{
                Console.WriteLine("You need to enter a valid operator: + - * /");
            }
        }
    }
}
