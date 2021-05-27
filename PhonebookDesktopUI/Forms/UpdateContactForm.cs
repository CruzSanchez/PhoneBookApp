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
    public partial class UpdateContactForm : Form
    {
        public Contact OriginalContact { get; set; }
        public UpdateContactForm(Contact c)
        {
            InitializeComponent();
            OriginalContact = c;

            UpdatedNameTextbox.Text = c.Name;
            UpdatedNumberTextbox.Text = c.Number;
            UpdatedEmailTextbox.Text = c.Email;
            UpdatedDobPicker.Value = c.DOB;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            OriginalContact.Name = UpdatedNameTextbox.Text;
            OriginalContact.Number = UpdatedNumberTextbox.Text;
            OriginalContact.Email = UpdatedEmailTextbox.Text;
            OriginalContact.DOB = UpdatedDobPicker.Value.Date;

            MessageBox.Show("Contact updated.");

            Close();
        }
    }
}
