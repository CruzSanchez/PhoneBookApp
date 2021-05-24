using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLibrary
{
    public static class UserInteraction
    {
        public static int CheckNumberFromUser(string stringID)
        {
            int contactID;
            while (!int.TryParse(stringID, out contactID))
            {
                Console.WriteLine("Could not update contact with information given. Try again.");
                stringID = Console.ReadLine();
            }
            
            return contactID;
           
        }

        public static void Intro()
        {
            Console.WriteLine("Welcome to the Phonebook Application.");
            NewLine();           
           
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }

        public static void GetMainAction()
        {
            PromptUserForAction();
            ConsoleKey userAction = GetKeyPress();
            int contactID;
            switch (userAction)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ClearConsole();
                    Phonebook.CreateContact();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ClearConsole();
                    Phonebook.ReadBackContacts();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    ClearConsole();
                    Phonebook.ReadBackContacts();
                    Console.WriteLine("Which contact would you like to update? Enter contact ID:");
                    contactID = CheckNumberFromUser(Console.ReadLine());
                    var contact = Phonebook.Contacts.Where(c => c.Id == contactID).FirstOrDefault();
                    Phonebook.UpdateContact(contact);
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    ClearConsole();
                    Phonebook.ReadBackContacts();
                    Console.WriteLine("Which contact would you like to delete? Enter Contact ID:");
                    contactID = CheckNumberFromUser(Console.ReadLine());
                    contact = Phonebook.Contacts.Where(c => c.Id == contactID).FirstOrDefault();
                    Phonebook.DeleteContact(contact);
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    ClearConsole();
                    Outro();
                    var jsonDataAccess = new JsonDataAccess();
                    jsonDataAccess.SaveData();
                    Environment.Exit(0);
                    break;
                default:
                    SetConsoleColor(ConsoleColor.Red);
                    Console.WriteLine("That was an incorrect selection. Please try again.");
                    ResetConsoleColor();
                    break;
            }
        }

        internal static void NoFile()
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("The file does not exist.");
            ResetConsoleColor();
        }

        private static void Outro()
        {
            Console.WriteLine("Thank you for using the Phonebook Application. Goodbye.");
        }

        private static ConsoleKey GetKeyPress()
        {
            return Console.ReadKey(true).Key;
        }

        private static void ClearConsole()
        {
            Console.Clear();
        }

        private static void PromptUserForAction()
        {
            Console.WriteLine("Which action would you like to perform?");
            NewLine();
            Console.WriteLine("1 - Create a Contact\n2 - Read Contact List\n3 - Update a Contact\n" +
                "4 - Delete a Contact\n5 - End Application");
            NewLine();
        }

        private static void SetConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        private static void ResetConsoleColor()
        {
            Console.ResetColor();
        }
    }
}
