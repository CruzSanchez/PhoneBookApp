using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLibrary
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string name, string email, DateTime dob, string number)
        {
            Id = id;
            Name = name;
            Email = email;
            DOB = dob;
            Number = number;
        }


    }
}
