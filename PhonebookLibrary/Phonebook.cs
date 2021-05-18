using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLibrary
{
    public static class Phonebook
    {
        public static int ID { get; set; } = 0;

        public static Dictionary<int, Contact> Contacts { get; private set; } = new Dictionary<int, Contact>(); 
        //{
        //    { ID, new Contact(){Name = "John Smith", Number = "(555)555-5555", Email = "johnsmith@email.com", DOB = new DateTime(1950,01,10)} }        
        //};

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

            ID++;
            AddContactToList(contact);
        }

        private static void AddContactToList(Contact contact)
        {
            Contacts.Add(ID, contact);
        }

        public static void ReadBackContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"ID: {contact.Key} | Name : {contact.Value.Name} | Phone #: {contact.Value.Number} " +
                    $"| E-Mail: {contact.Value.Email} | DOB: {contact.Value.DOB.ToShortDateString()}");
            }
        }

        public static void UpdateContact(Contact contact)
        {            
            Console.WriteLine("Please enter the new name of your contact:");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Now enter the new number of your contact:");
            contact.Number = Console.ReadLine();
            Console.WriteLine("Please enter the new email for your contact:");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Now enter the new DOB of your contact:");
            contact.DOB = DateTime.Parse(Console.ReadLine());            
            
        }


        public static void DeleteContact(int contactID)
        {
            Contacts.Remove(contactID);
        }

    }
}
