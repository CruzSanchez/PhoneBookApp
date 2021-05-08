using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLibrary
{
    public static class Phonebook
    {
        public static List<Contact> Contacts { get; private set; } = new List<Contact>();

        public static void CreateContact()
        {
            var contact = new Contact();
            Console.WriteLine("Please enter the name of your contact:");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Now enter the number of your contact:");
            contact.Number = Console.ReadLine();
            Console.WriteLine("Please enter the email for your contact:");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Now enter the DOB of your contact:");
            contact.DOB = DateTime.Parse(Console.ReadLine());

            AddContactToList(contact);
        }

        private static void AddContactToList(Contact contact)
        {
            Contacts.Add(contact);
        }

        public static void ReadBackContacts()
        {
            foreach (var contact in Phonebook.Contacts)
            {
                Console.WriteLine($"Name :{contact.Name} | Phone #: {contact.Number} | E-Mail: {contact.Email} | DOB: {contact.DOB}");
            }
        }
    }
}
