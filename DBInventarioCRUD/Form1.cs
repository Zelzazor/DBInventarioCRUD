using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using System.Data.Entity.Migrations;

namespace DBInventarioCRUD
{
    public partial class Form1 : Form
    {

        private readonly INTECEntities db = new INTECEntities();
        private int id = 0;
        public Form1()
        {
            InitializeComponent();
            var contactTypeList = db.ContactType.ToList();
            var clientTypeList = db.ClientType.ToList();
            var companyTypeList = db.Company.ToList();
            var departmentTypeList = db.Department.ToList();
            var personList = db.People.Select(x => new 
            {
                x.id,
                x.FirstName,
                x.MiddleName,
                x.LastName,
                x.SupportStaff,
                x.ClientType,
                x.ContactType,
                x.Company,
                x.Department,
                x.EmailAddress,
                x.PhoneNumber
            }).ToList();
            dataGridPerson.DataSource = personList;
            cbClientType.DataSource = clientTypeList;
            cbContactType.DataSource = contactTypeList;
            cbCompany.DataSource = companyTypeList;
            cbDepartment.DataSource = departmentTypeList;
            
        } 

        private void UpdateForm()
        {
            var personList = db.People.Select(x => new
            {
                x.id,
                x.FirstName,
                x.MiddleName,
                x.LastName,
                x.SupportStaff,
                x.ClientType,
                x.ContactType,
                x.Company,
                x.Department,
                x.EmailAddress,
                x.PhoneNumber
            }).ToList();
            dataGridPerson.DataSource = personList;

            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            chkStaff.Checked = false;
        }

        private void AddPerson(People person)
        {
            if (Utils.IsAnyNullOrEmpty(person))
            {
                MessageBox.Show("Fields are required", "Info");
                return;
            }

            db.People.Add(person);
            db.SaveChanges();

            UpdateForm();

            
            MessageBox.Show("Person added successfully.", "Info");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var person = new People
            {
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                ClientType = (ClientType)cbClientType.SelectedItem,
                ContactType = (ContactType)cbContactType.SelectedItem,
                SupportStaff = chkStaff.Checked,
                PhoneNumber = txtPhoneNumber.Text,
                EmailAddress = txtEmailAddress.Text,
                Company = (Company)cbCompany.SelectedItem,
                Department = (Department)cbDepartment.SelectedItem,
                CreatedAt = DateTime.Now,

            };

            AddPerson(person);
            

        }

        private void dataGridPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridPerson.Rows[e.RowIndex].Cells[0].Value == null) return;

            bool parse = int.TryParse(dataGridPerson.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);
            if (!parse) return;

            var person = db.People.Where(x => x.id == id).FirstOrDefault();

            txtFirstName.Text = person.FirstName;
            txtMiddleName.Text = person.MiddleName;
            txtLastName.Text = person.LastName;
            cbClientType.SelectedItem = person.ClientType;
            cbContactType.SelectedItem = person.ContactType;
            cbCompany.SelectedItem = person.Company;
            cbDepartment.SelectedItem = person.Department;
            txtEmailAddress.Text = person.EmailAddress;
            txtPhoneNumber.Text = person.PhoneNumber;
            chkStaff.Checked = person.SupportStaff;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            db.People.Remove(db.People.SingleOrDefault(x => x.id == this.id));
            db.SaveChanges();

            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = db.People.FirstOrDefault(x => x.id == this.id);
            if (person == null) return;
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.MiddleName = txtMiddleName.Text;
            person.Department = (Department)cbDepartment.SelectedItem;
            person.ClientType = (ClientType)cbClientType.SelectedItem;
            person.ContactType = (ContactType)cbContactType.SelectedItem;
            person.Company = (Company)cbCompany.SelectedItem;
            person.EmailAddress = txtEmailAddress.Text;
            person.PhoneNumber = txtPhoneNumber.Text;
            person.SupportStaff = chkStaff.Checked;

            db.SaveChanges();
            
            UpdateForm();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
