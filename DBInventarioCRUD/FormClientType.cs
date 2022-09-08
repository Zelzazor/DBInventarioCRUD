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
    }
}
