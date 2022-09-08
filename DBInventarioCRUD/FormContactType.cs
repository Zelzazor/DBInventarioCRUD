using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBInventarioCRUD
{
    public partial class FormContactType : Form
    {
        private int id = 0;
        private readonly INTECEntities db = new INTECEntities();
        public FormContactType()
        {
            InitializeComponent();
            var contactTypeList = db.ContactType.ToList();
            dataGridContactType.DataSource = contactTypeList;
        }

        public void UpdateForm()
        {
            var contactTypeList = db.ContactType.ToList();
            dataGridContactType.DataSource = contactTypeList;
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void AddContactType(ContactType contactType)
        {
            if (Utils.IsAnyNullOrEmpty(contactType))
            {
                MessageBox.Show("Fields are required", "Info");
                return;
            }

            db.ContactType.Add(contactType);
            db.SaveChanges();

            UpdateForm();


            MessageBox.Show("Contact type added successfully.", "Info");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var contactType = new ContactType
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                CreatedAt = DateTime.Now
            };

            AddContactType(contactType);
        }
    }
}
