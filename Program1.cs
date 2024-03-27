using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Week1Practice~ Welcome~:{0}", username);

            Console.WriteLine("About the math" + "\r\n" + "Enter a math:");
            int userInputMath = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "The Table For Output Style:" + "\r\n");
            Console.WriteLine("The Coin Style: {0:C}", userInputMath);
            Console.WriteLine("The Decimal Style: {0:D}", userInputMath);
            Console.WriteLine("The Science Style: {0:E}", userInputMath);
            Console.WriteLine("The Double Style: {0:F5}", userInputMath);
            Console.WriteLine("The Normal Style: {0:G}", userInputMath);
            Console.WriteLine("The Thound's Style: {0:N}", userInputMath);
            Console.WriteLine("The Hexadecimal Style: {0:X}", userInputMath);
            
            Console.ReadLine(); //pause
        }
    }
}
