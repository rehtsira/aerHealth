namespace aerHealth
{
    partial class PatientList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPatientList = new System.Windows.Forms.Button();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.patientAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPatientList
            // 
            this.buttonPatientList.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPatientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPatientList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPatientList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientList.ForeColor = System.Drawing.Color.White;
            this.buttonPatientList.Location = new System.Drawing.Point(132, 2);
            this.buttonPatientList.Name = "buttonPatientList";
            this.buttonPatientList.Size = new System.Drawing.Size(181, 37);
            this.buttonPatientList.TabIndex = 1;
            this.buttonPatientList.Text = "Check Patient List";
            this.buttonPatientList.UseVisualStyleBackColor = false;
            this.buttonPatientList.Click += new System.EventHandler(this.patientListButtonClick);
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.AllowUserToResizeColumns = false;
            this.dgvPatientList.AllowUserToResizeRows = false;
            this.dgvPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Location = new System.Drawing.Point(3, 44);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.Size = new System.Drawing.Size(474, 238);
            this.dgvPatientList.TabIndex = 2;
            // 
            // fName
            // 
            this.fName.BackColor = System.Drawing.Color.White;
            this.fName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fName.Location = new System.Drawing.Point(500, 44);
            this.fName.Margin = new System.Windows.Forms.Padding(2);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(142, 18);
            this.fName.TabIndex = 58;
            this.fName.Text = "First Name";
            this.fName.Click += new System.EventHandler(this.FName_Click);
            // 
            // lName
            // 
            this.lName.BackColor = System.Drawing.Color.White;
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lName.Location = new System.Drawing.Point(500, 66);
            this.lName.Margin = new System.Windows.Forms.Padding(2);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(142, 18);
            this.lName.TabIndex = 59;
            this.lName.Text = "Last Name";
            this.lName.Click += new System.EventHandler(this.LName_Click);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.White;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.phone.Location = new System.Drawing.Point(500, 88);
            this.phone.Margin = new System.Windows.Forms.Padding(2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(142, 18);
            this.phone.TabIndex = 60;
            this.phone.Text = "Phone";
            this.phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // birth
            // 
            this.birth.BackColor = System.Drawing.Color.White;
            this.birth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birth.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.birth.Location = new System.Drawing.Point(500, 110);
            this.birth.Margin = new System.Windows.Forms.Padding(2);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(142, 18);
            this.birth.TabIndex = 61;
            this.birth.Text = "Birthday";
            this.birth.Click += new System.EventHandler(this.Birth_Click);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.WindowText;
            this.address.Location = new System.Drawing.Point(500, 132);
            this.address.Margin = new System.Windows.Forms.Padding(2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(142, 18);
            this.address.TabIndex = 62;
            this.address.Text = "Address";
            this.address.Click += new System.EventHandler(this.Address_Click);
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.city.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.SystemColors.WindowText;
            this.city.Location = new System.Drawing.Point(500, 154);
            this.city.Margin = new System.Windows.Forms.Padding(2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(142, 18);
            this.city.TabIndex = 63;
            this.city.Text = "City";
            this.city.Click += new System.EventHandler(this.City_Click);
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.White;
            this.state.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.state.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.SystemColors.WindowText;
            this.state.Location = new System.Drawing.Point(500, 176);
            this.state.Margin = new System.Windows.Forms.Padding(2);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(142, 18);
            this.state.TabIndex = 64;
            this.state.Text = "State";
            this.state.Click += new System.EventHandler(this.State_Click);
            // 
            // zip
            // 
            this.zip.BackColor = System.Drawing.Color.White;
            this.zip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zip.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.zip.Location = new System.Drawing.Point(500, 198);
            this.zip.Margin = new System.Windows.Forms.Padding(2);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(142, 18);
            this.zip.TabIndex = 65;
            this.zip.Text = "Zip Code";
            this.zip.Click += new System.EventHandler(this.Zip_Click);
            // 
            // patientAddButton
            // 
            this.patientAddButton.BackColor = System.Drawing.Color.DarkOrange;
            this.patientAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.patientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patientAddButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddButton.ForeColor = System.Drawing.Color.White;
            this.patientAddButton.Location = new System.Drawing.Point(481, 245);
            this.patientAddButton.Name = "patientAddButton";
            this.patientAddButton.Size = new System.Drawing.Size(181, 37);
            this.patientAddButton.TabIndex = 66;
            this.patientAddButton.Text = "Add Patient";
            this.patientAddButton.UseVisualStyleBackColor = false;
            this.patientAddButton.Click += new System.EventHandler(this.PatientAddButton_Click);
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientAddButton);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.buttonPatientList);
            this.Name = "PatientList";
            this.Size = new System.Drawing.Size(665, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPatientList;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Button patientAddButton;
    }
}
