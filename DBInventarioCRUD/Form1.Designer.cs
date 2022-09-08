namespace DBInventarioCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCRUD = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblClientType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.cbContactType = new System.Windows.Forms.ComboBox();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.dataGridPerson = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClientType = new System.Windows.Forms.Button();
            this.btnContactType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCRUD
            // 
            this.lblCRUD.AutoSize = true;
            this.lblCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblCRUD.Location = new System.Drawing.Point(12, 9);
            this.lblCRUD.Name = "lblCRUD";
            this.lblCRUD.Size = new System.Drawing.Size(212, 29);
            this.lblCRUD.TabIndex = 0;
            this.lblCRUD.Text = "CRUD EXAMPLE";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(14, 88);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Location = new System.Drawing.Point(14, 139);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(60, 13);
            this.lblClientType.TabIndex = 4;
            this.lblClientType.Text = "Client Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact Type";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(374, 64);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(35, 13);
            this.lblStaff.TabIndex = 6;
            this.lblStaff.Text = "Staff?";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(331, 87);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(336, 113);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 8;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 571);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(551, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(713, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(89, 84);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(121, 20);
            this.txtMiddleName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(89, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // cbClientType
            // 
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.ItemHeight = 13;
            this.cbClientType.Location = new System.Drawing.Point(89, 136);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(121, 21);
            this.cbClientType.TabIndex = 16;
            // 
            // cbContactType
            // 
            this.cbContactType.FormattingEnabled = true;
            this.cbContactType.Location = new System.Drawing.Point(89, 164);
            this.cbContactType.Name = "cbContactType";
            this.cbContactType.Size = new System.Drawing.Size(121, 21);
            this.cbContactType.TabIndex = 17;
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.Location = new System.Drawing.Point(415, 64);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(15, 14);
            this.chkStaff.TabIndex = 18;
            this.chkStaff.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(415, 84);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(415, 110);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(121, 20);
            this.txtEmailAddress.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(358, 136);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 21;
            this.lblCompany.Text = "Company";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(347, 162);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "Department";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(415, 133);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(121, 21);
            this.cbCompany.TabIndex = 23;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(415, 159);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbDepartment.TabIndex = 24;
            // 
            // dataGridPerson
            // 
            this.dataGridPerson.AllowUserToAddRows = false;
            this.dataGridPerson.AllowUserToDeleteRows = false;
            this.dataGridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerson.Location = new System.Drawing.Point(12, 191);
            this.dataGridPerson.Name = "dataGridPerson";
            this.dataGridPerson.ReadOnly = true;
            this.dataGridPerson.Size = new System.Drawing.Size(776, 374);
            this.dataGridPerson.TabIndex = 25;
            this.dataGridPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPerson_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(632, 571);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClientType
            // 
            this.btnClientType.Location = new System.Drawing.Point(17, 571);
            this.btnClientType.Name = "btnClientType";
            this.btnClientType.Size = new System.Drawing.Size(75, 23);
            this.btnClientType.TabIndex = 27;
            this.btnClientType.Text = "Client Type";
            this.btnClientType.UseVisualStyleBackColor = true;
            this.btnClientType.Click += new System.EventHandler(this.btnClientType_Click);
            // 
            // btnContactType
            // 
            this.btnContactType.Location = new System.Drawing.Point(99, 570);
            this.btnContactType.Name = "btnContactType";
            this.btnContactType.Size = new System.Drawing.Size(93, 23);
            this.btnContactType.TabIndex = 28;
            this.btnContactType.Text = "Contact Type";
            this.btnContactType.UseVisualStyleBackColor = true;
            this.btnContactType.Click += new System.EventHandler(this.btnContactType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btnContactType);
            this.Controls.Add(this.btnClientType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridPerson);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.chkStaff);
            this.Controls.Add(this.cbContactType);
            this.Controls.Add(this.cbClientType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClientType);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCRUD);
            this.Name = "Form1";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRUD;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbClientType;
        private System.Windows.Forms.ComboBox cbContactType;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.DataGridView dataGridPerson;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClientType;
        private System.Windows.Forms.Button btnContactType;
    }
}

