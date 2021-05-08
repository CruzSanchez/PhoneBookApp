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
            Console.WriteLine("This application is used to create, read back, update, and delete contacts in a database.");
        }
    }
}
