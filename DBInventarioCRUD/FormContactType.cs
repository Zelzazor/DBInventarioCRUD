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

        private void dataGridContactType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridContactType.Rows[e.RowIndex].Cells[0].Value == null) return;

            bool parse = int.TryParse(dataGridContactType.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);
            if (!parse) return;

            var contactType = db.ContactType.Where(x => x.id == id).FirstOrDefault();

            txtName.Text = contactType.Name;
            txtDescription.Text = contactType.Description;

            this.id = id;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var contactType = db.ContactType.FirstOrDefault(x => x.id == this.id);
            if (contactType == null) return;
            contactType.Name = txtName.Text;
            contactType.Description = txtDescription.Text;

            db.SaveChanges();

            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.ContactType.Remove(db.ContactType.SingleOrDefault(x => x.id == this.id));
            db.SaveChanges();

            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
