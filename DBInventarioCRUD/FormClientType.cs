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
    public partial class FormClientType : Form
    {
        private int id = 0;
        private readonly INTECEntities db = new INTECEntities();
        public FormClientType()
        {
            InitializeComponent();
            var clientTypeList = db.ClientType.ToList();
            dataGridClientType.DataSource = clientTypeList;
        }

        public void UpdateForm()
        {
            var clientTypeList = db.ClientType.ToList();
            dataGridClientType.DataSource = clientTypeList;
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void AddClientType(ClientType clientType)
        {
            if (Utils.IsAnyNullOrEmpty(clientType))
            {
                MessageBox.Show("Fields are required", "Info");
                return;
            }

            db.ClientType.Add(clientType);
            db.SaveChanges();

            UpdateForm();


            MessageBox.Show("Client type added successfully.", "Info");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var clientType = new ClientType
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                CreatedAt = DateTime.Now
            };

            AddClientType(clientType);
        }

        private void dataGridClientType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridClientType.Rows[e.RowIndex].Cells[0].Value == null) return;

            bool parse = int.TryParse(dataGridClientType.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);
            if (!parse) return;

            var clientType = db.ClientType.Where(x => x.id == id).FirstOrDefault();

            txtName.Text = clientType.Name;
            txtDescription.Text = clientType.Description;

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
            var clientType = db.ClientType.FirstOrDefault(x => x.id == this.id);
            if (clientType == null) return;
            clientType.Name = txtName.Text;
            clientType.Description = txtDescription.Text;

            db.SaveChanges();

            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.ClientType.Remove(db.ClientType.SingleOrDefault(x => x.id == this.id));
            db.SaveChanges();

            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
