using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhonebookApplicationJSON;

namespace PhonebookApplicationJSONDesktopUI
{
    

    public partial class UpdateContactForm : Form
    {
        private readonly Contact _originalContact;
        private readonly HomeForm _homeForm;

        public UpdateContactForm(Contact originalContact)
        {
            InitializeComponent();
            _originalContact = originalContact;
            _homeForm = (HomeForm)Application.OpenForms[nameof(HomeForm)];

            FirstNameTextBox.Text = originalContact.FirstName;
            LastNameTextBox.Text = originalContact.LastName;
            EmailTextBox.Text = originalContact.Email;
            PhoneNumberTextBox.Text = originalContact.PhoneNumber;
        }

        private void UpdateContactBtn_Click(object sender, EventArgs e)
        {
            _originalContact.FirstName = FirstNameTextBox.Text;
            _originalContact.LastName = LastNameTextBox.Text;
            _originalContact.Email = EmailTextBox.Text;
            _originalContact.PhoneNumber = PhoneNumberTextBox.Text;

            MessageBox.Show("Contact Updated!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _homeForm.RefreshData();

            Close();
        }
    }
}
