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
            var jsonDataAccess = new JsonDataAccess();
            jsonDataAccess.LoadData();

            phonebookGridView.DataSource = Phonebook.Contacts;

            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var createContact = new CreateContactForm();
            createContact.Show();
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            phonebookGridView.DataSource = null;
            phonebookGridView.DataSource = Phonebook.Contacts;
        }
    }
}
