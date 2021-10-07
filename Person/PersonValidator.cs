namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //checks to be sure firstName and lastName are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");

                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");

                return false;
            }

            return true;
        }
    }
}
