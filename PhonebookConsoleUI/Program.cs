using System;
using System.Collections.Generic;
using PhonebookLibrary;

namespace PhonebookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Phonebook Application.");
            Console.WriteLine("This application is used to create, update, delete, and read back contacts in a database.");

            Console.WriteLine("Would you like to create a contact?");
            var answer = Console.ReadLine();
            if(answer == "yes")
            {
                Phonebook.CreateContact();
                
            }
            else if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You failed to type anything.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("You've chosen not to create a contact.");
            }


            Console.WriteLine("Would you like to look at your contact list?");

            answer = Console.ReadLine();

            if(answer == "yes")
            {
                Phonebook.ReadBackContacts();
            }
            else if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You failed to type anything.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("You have chosen not to read back your contact list.");
            }

            Console.WriteLine();


            
        }
    }
}
