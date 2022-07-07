using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhonebookApplicationJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();

            contacts = FileManipulation.LoadContacts(contacts);

            ConsoleLogging.MainConsole(contacts);
        }


    }
}

