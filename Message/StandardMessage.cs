using System;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessage() 
        {
            Console.WriteLine("Welcome to my application\n\n");
        }

        public static void EndApplication()
        {
            Console.WriteLine("\n\nPress 'Enter' to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName} !");
        }
    }
}
