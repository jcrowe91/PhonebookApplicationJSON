using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplicationJSON
{
    public class UserInterface
    {
        public static void MainMenu(List<Contact> contacts)
        {
            ConsoleLogging.Greeting();

            Console.WriteLine();

            ConsoleLogging.PassMessage("What would you like to do?\n1: View all contacts.\n2: Create a contact.\n3: Update a contact.\n4: Delete a contact.\n5: Save and Exit.");

            var userAnswer = Console.ReadLine();

            if (userAnswer == "1") //View all
            {
                ConsoleLogging.CRUDForEachLoop(contacts);
                ConsoleLogging.PassMessage("Press ENTER to continue");
                Console.ReadLine();
                ConsoleLogging.ClearConsole();
            }
            else if (userAnswer == "2") //Create
            {
                ConsoleLogging.ClearConsole();
                var newContact = ContactCreator();
                contacts.Add(newContact);
                
            }
            else if (userAnswer == "3") //Update
            {
                Console.WriteLine("Update");
                ConsoleLogging.ClearConsole();
            }
            else if (userAnswer == "4") //Delete
            {
                Console.WriteLine("Delete");
                ConsoleLogging.ClearConsole();
            }
            else if (userAnswer == "5") //Save and Exit
            {
                FileManipulation.SaveContacts(contacts);
                ConsoleLogging.ExitMessage();
            }
            else //Not a choice
            {
                ConsoleLogging.InvalidResponse();
            }
        }

        public static Contact ContactCreator()
        {
            Console.WriteLine("Create a new contact:");
            var contact = new Contact();
            Console.WriteLine("What is the first name of the new contact?");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("What is the last name of the new contact?");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("What is this contact's phone number?");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("What is the email for the new contact?");
            contact.Email = Console.ReadLine();

            return contact;
        }
    }
}
