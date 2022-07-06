using System;
using System.Collections.Generic;

namespace PhonebookApplicationJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();

            var jake = new Contact();
            var cruz = new Contact();
            cruz.FirstName = "Cruz";
            cruz.LastName = "Sanchez";
            cruz.Email = "csanchez@email.com";
            cruz.PhoneNumber = "5555555";
            jake.FirstName = "Jake";
            jake.LastName = "Crowe";
            jake.PhoneNumber = "2055146112";
            jake.Email = "jcrowe@email.com";
            contacts.Add(cruz);
            contacts.Add(jake);


            ConsoleLogging.MainConsole(contacts);
        }
    }
}
