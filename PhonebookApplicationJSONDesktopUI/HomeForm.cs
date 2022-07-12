using PhonebookApplicationJSON;
using System.ComponentModel;

namespace PhonebookApplicationJSONDesktopUI
{
    public partial class HomeForm : Form
    {
        public static BindingList<Contact> contacts;

        public HomeForm()
        {
            InitializeComponent();
            ContactsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contacts = FileManipulation.LoadContacts(contacts);
            RefreshData();
        }

        private void ReadContactsBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            ContactsGridView.DataSource = contacts;
        }

        private void CreateContactBtn_Click(object sender, EventArgs e)
        {
            var createContactForm = new CreateContactForm();
            createContactForm.Show();
        }

        private void UpdateContactBtn_Click(object sender, EventArgs e)
        {
            var row = ContactsGridView.SelectedRows[0];

            Contact c = contacts.Where(x => x.Email == row.Cells["Email"].Value.ToString()).FirstOrDefault();

            var updateContactForm = new UpdateContactForm(c);

            updateContactForm.Show();
        }

        private void DeleteContactBtn_Click(object sender, EventArgs e)
        {
            var row = ContactsGridView.SelectedRows[0];

            Contact c = contacts.Where(x => x.Email == row.Cells["Email"].Value.ToString()).FirstOrDefault();

            var result = MessageBox.Show("You are about to delete a contact. This is a permanent action. \nDo you wish to continue?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.No)
            {
                MessageBox.Show("Delete aborted.", "", MessageBoxButtons.OK);
                return;
            }

            contacts.Remove(c);

            MessageBox.Show("Contact deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshData();


        }
    }
}