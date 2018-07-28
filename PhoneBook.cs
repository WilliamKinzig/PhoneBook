using System;
using System.Collections.Generic;

class PhoneBook
{
    public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

    static void Main()
    {
        Console.WriteLine("MAIN MENU");
        Console.WriteLine("Would you like to add a new contact to you phone book?");
        Console.WriteLine("[Enter 'Y' for yes or 'Enter' for no]");
        string answer = Console.ReadLine();

        if (answer == "Y" ||answer == "y")
        {
            AddContact();
        }
        else
        {
            Console.WriteLine("Would you like to lookup a number in your phone book?");
            Console.WriteLine("[Enter 'Y' for yes or 'Enter' for no]");
        }

        string lookUpAnswer = Console.ReadLine();

        if (lookUpAnswer == "Y" || lookUpAnswer == "y")
        {
            LookUpContact();
        }
        else
        {
            Console.WriteLine("Are you finished with this program?");
            Console.WriteLine("[Enter 'Y' for yes or 'Enter' for no]");

            string finishedAnswer = Console.ReadLine();
            if (finishedAnswer == "Y" || finishedAnswer == "y")
            {
                Console.WriteLine("Alrighty then. Byebye.");
            }
            else
            {
                Main();
            }
        }
    }

    /*********************************************************************/

    static void AddContact()
    {
        Console.WriteLine("NEW CONTACT");
        Console.WriteLine("Enter a new contacts name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter a new contacts phone number");
        string number = Console.ReadLine();

//check to see if contact is already logged
        if (phoneNumbers.ContainsKey(name))
        {
            Console.WriteLine( "That person is already in your phonebook. Their number is " + phoneNumbers[name]);
        }
        else
        {
            phoneNumbers.Add(name, number);
            Console.WriteLine("Your contact has been added to the phonebook.");
        }
        Main();
    }

    /*********************************************************************/

    static void LookUpContact()
    {
        Console.WriteLine("CONTACT LOOKUP");
        Console.WriteLine("Whose number would you like to look up?");
        string contact = Console.ReadLine();

        if (phoneNumbers.ContainsKey(contact))
        {
            string phoneNumber = phoneNumbers[contact];
            Console.WriteLine();
            Console.WriteLine(contact + "\'s phone number is: " + phoneNumber);
            Console.WriteLine();
        }
        else
        {
          Console.WriteLine("That person is not in your phone book.");
        }
        Main();
    }
}
