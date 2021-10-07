using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            //create a username for the person
            Console.WriteLine($"Your username is {person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}
