using System;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            //create a username for the person
            Console.WriteLine($"\nYour username is {person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}
