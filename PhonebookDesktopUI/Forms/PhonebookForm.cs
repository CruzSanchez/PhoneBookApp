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
using PhonebookDesktopUI.Forms;
using System.Diagnostics;

namespace PhonebookDesktopUI
{
    public partial class PhonebookForm : Form
    {
        public PhonebookForm()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (Phonebook.Contacts.Count == 0)
            {
                var jsonDataAccess = new JsonDataAccess();
                jsonDataAccess.LoadData();
            }

            phonebookGridView.DataSource = Phonebook.Contacts;

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var createContact = new CreateContactForm();
            createContact.Show();
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            var dataAccess = new JsonDataAccess();
            Phonebook.Contacts = new List<Contact>();
            dataAccess.LoadData();
            phonebookGridView.DataSource = null;
            phonebookGridView.DataSource = Phonebook.Contacts;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow viewRow = phonebookGridView.SelectedRows[0];
            var contact = Phonebook.Contacts.Where(c => c.Id == int.Parse(viewRow.Cells["Id"].Value.ToString())).FirstOrDefault();
            var updateContact = new UpdateContactForm(contact);
            updateContact.Show();
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are about to delete a contact. This is a permanent action.\nAre you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow viewRow = phonebookGridView.SelectedRows[0];
                var contact = Phonebook.Contacts.Where(c => c.Id == int.Parse(viewRow.Cells["Id"].Value.ToString())).FirstOrDefault();
                Phonebook.Contacts.Remove(contact);
                var dataAccess = new JsonDataAccess();
                dataAccess.SaveData();
                MessageBox.Show("Contact deleted.");
            }
            else
            {
                MessageBox.Show("Delete aborted.");
            }
            RefreshContactList();
        }


        internal void RefreshContactList()
        {
            phonebookGridView.DataSource = null;
            phonebookGridView.DataSource = Phonebook.Contacts;
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\truec\Desktop\repos\PhonebookApp\PhonebookConsoleUI\bin\Debug\net5.0\PhonebookConsoleUI.exe");
        }

        private void ApiButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\truec\Desktop\repos\PhonebookApp\PhonebookApi\bin\Debug\net5.0\PhonebookApi.exe");
        }
    }
}
