namespace PhonebookApplicationJSONDesktopUI
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ReadContactsBtn = new System.Windows.Forms.Button();
            this.ContactsGridView = new System.Windows.Forms.DataGridView();
            this.CreateContactBtn = new System.Windows.Forms.Button();
            this.UpdateContactBtn = new System.Windows.Forms.Button();
            this.DeleteContactBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadContactsBtn
            // 
            this.ReadContactsBtn.Location = new System.Drawing.Point(605, 76);
            this.ReadContactsBtn.Name = "ReadContactsBtn";
            this.ReadContactsBtn.Size = new System.Drawing.Size(133, 34);
            this.ReadContactsBtn.TabIndex = 0;
            this.ReadContactsBtn.Text = "Read Contacts";
            this.ReadContactsBtn.UseVisualStyleBackColor = true;
            this.ReadContactsBtn.Click += new System.EventHandler(this.ReadContactsBtn_Click);
            // 
            // ContactsGridView
            // 
            this.ContactsGridView.AllowUserToAddRows = false;
            this.ContactsGridView.AllowUserToDeleteRows = false;
            this.ContactsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsGridView.Location = new System.Drawing.Point(36, 76);
            this.ContactsGridView.MultiSelect = false;
            this.ContactsGridView.Name = "ContactsGridView";
            this.ContactsGridView.ReadOnly = true;
            this.ContactsGridView.RowTemplate.Height = 25;
            this.ContactsGridView.Size = new System.Drawing.Size(505, 362);
            this.ContactsGridView.TabIndex = 1;
            // 
            // CreateContactBtn
            // 
            this.CreateContactBtn.Location = new System.Drawing.Point(605, 144);
            this.CreateContactBtn.Name = "CreateContactBtn";
            this.CreateContactBtn.Size = new System.Drawing.Size(133, 34);
            this.CreateContactBtn.TabIndex = 2;
            this.CreateContactBtn.Text = "Create Contact";
            this.CreateContactBtn.UseVisualStyleBackColor = true;
            this.CreateContactBtn.Click += new System.EventHandler(this.CreateContactBtn_Click);
            // 
            // UpdateContactBtn
            // 
            this.UpdateContactBtn.Location = new System.Drawing.Point(605, 212);
            this.UpdateContactBtn.Name = "UpdateContactBtn";
            this.UpdateContactBtn.Size = new System.Drawing.Size(133, 34);
            this.UpdateContactBtn.TabIndex = 3;
            this.UpdateContactBtn.Text = "Update Contact";
            this.UpdateContactBtn.UseVisualStyleBackColor = true;
            this.UpdateContactBtn.Click += new System.EventHandler(this.UpdateContactBtn_Click);
            // 
            // DeleteContactBtn
            // 
            this.DeleteContactBtn.Location = new System.Drawing.Point(605, 281);
            this.DeleteContactBtn.Name = "DeleteContactBtn";
            this.DeleteContactBtn.Size = new System.Drawing.Size(133, 34);
            this.DeleteContactBtn.TabIndex = 4;
            this.DeleteContactBtn.Text = "Delete Contact";
            this.DeleteContactBtn.UseVisualStyleBackColor = true;
            this.DeleteContactBtn.Click += new System.EventHandler(this.DeleteContactBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteContactBtn);
            this.Controls.Add(this.UpdateContactBtn);
            this.Controls.Add(this.CreateContactBtn);
            this.Controls.Add(this.ContactsGridView);
            this.Controls.Add(this.ReadContactsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Phonebook App";
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ReadContactsBtn;
        private DataGridView ContactsGridView;
        private Button CreateContactBtn;
        private Button UpdateContactBtn;
        private Button DeleteContactBtn;
    }
}