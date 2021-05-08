using System;
using System.Collections.Generic;
using PhonebookLibrary;
using System.Linq;

namespace PhonebookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Phonebook Application.");
            Console.WriteLine("This application is used to create, read back, update, and delete contacts in a database.");

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

            Console.WriteLine("Would you like to update a contact?");

            answer = Console.ReadLine();

            if(answer == "yes")
            {
                Phonebook.ReadBackContacts();
                Console.WriteLine("Which contact would you like to update? Enter contact ID:");
                var contactID = uint.Parse(Console.ReadLine());

                var contact = Phonebook.Contacts.Where(c => c.Key == contactID).FirstOrDefault();

                Phonebook.UpdateContact(contact.Value);                

            }
            else if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You have failed to type anything.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("You have chosen not to update a contact.");
            }

            Phonebook.ReadBackContacts();

            Console.WriteLine("Would you like to delete a contact?");

            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Phonebook.ReadBackContacts();
                Console.WriteLine("Which contact would you like to delete ID:");
                var contactID = int.Parse(Console.ReadLine());
                Phonebook.DeleteContact(contactID);

            }
            else if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You have failed to type anything.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("You have chosen not to delete a contact.");
            }

            Phonebook.ReadBackContacts();

        }
    }
}
