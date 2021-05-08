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
            //ToDo: Anywhere there is a parse() the application can Break. Research TryParse() Hint while(!something){}
            //ToDo: when the user sees the contacts DOB in the list, only show the ShortDateString, no time should be seen
            //ToDo: think about where you have duplicated code below and how to abstract it into a method. Perhaps think about 
            // redoing the whole UI, Look at the doc to get an idea of what I mean.

            UserInteraction.Intro();

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
                
                int contactID = UserInteraction.CheckNumberFromUser(Console.ReadLine());

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
                int contactID = UserInteraction.CheckNumberFromUser(Console.ReadLine());
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
