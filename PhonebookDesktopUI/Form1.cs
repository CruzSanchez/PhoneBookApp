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

namespace PhonebookDesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            var jsonDataAccess = new JsonDataAccess();
            jsonDataAccess.LoadData();

            foreach (var contact in Phonebook.Contacts.Values)
            {
                contactTextBox.Text = contact.Name;
            }
        }
    }
}
