using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhonebookLibrary;

namespace PhonebookDesktopUI.Forms
{
    public partial class CreateContactForm : Form
    {
        public CreateContactForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var id = Phonebook.Contacts.OrderByDescending(c => c.Id).First().Id;
           
            var contact = new Contact(++id, nameTextbox.Text, emailTextbox.Text, dobPicker.Value.Date, numberTextbox.Text);
            Phonebook.AddContactToList(contact);
            var reader = new JsonDataAccess();
            reader.SaveData();
            MessageBox.Show("Contact created.");
            Close();
        }

       
    }
}
