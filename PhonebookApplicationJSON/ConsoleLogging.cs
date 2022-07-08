using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplicationJSON
{
    public class ConsoleLogging
    {
        public static void Greeting()
        {
            Console.WriteLine("Welcome to your phonebook app!");
        }

        public static void PassMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void MainConsole(List<Contact> contacts)
        {
            while (true)
            {
                UserInterface.MainMenu(contacts);
            }
        }

        public static void ExitMessage()
        {
            ConsoleLogging.PassMessage("Your contacts have been saved! Have a nice day!");
            Environment.Exit(0);
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void InvalidResponse()
        {
            ConsoleLogging.PassMessage("Please enter a valid response");
        }

        public static void CRUDForEachLoop(List<Contact> contacts)
        {
            ConsoleLogging.ClearConsole();
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}\nEmail: {contact.Email}\nPhone Number: {contact.PhoneNumber}");
                Console.WriteLine("-----------------------");
            }
        }

        public static void CRUDForLoop(List<Contact> contacts)
        {
            //used in update and delete methods
            for (int i = 0; i < contacts.Count; i++)
            {
                //loop through each contact, assign an ID number, and display the properties of each
                Console.WriteLine($"ID: {i + 1} {contacts[i].FirstName} {contacts[i].LastName}\nPhone Number: {contacts[i].PhoneNumber}\nEmail Address: {contacts[i].Email}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
