namespace aerHealth
{
    partial class PhysicianUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicianUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogOff = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonBilling = new System.Windows.Forms.Button();
            this.buttonPhysicians = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.buttonTreatments = new System.Windows.Forms.Button();
            this.buttonPatients = new System.Windows.Forms.Button();
            this.patientControl = new aerHealth.PatientList();
            this.treatmentsControl = new aerHealth.Treatments();
            this.appointmentControl = new aerHealth.Appointment();
            this.physiciansControl = new aerHealth.PhysiciansList();
            this.billingControl = new aerHealth.Billing();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 77);
            this.panel2.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(256, 80);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(10, 13);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 81);
            this.label1.TabIndex = 13;
            this.label1.Text = "aerHealth";
            // 
            // buttonLogOff
            // 
            this.buttonLogOff.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOff.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogOff.Location = new System.Drawing.Point(26, 236);
            this.buttonLogOff.Name = "buttonLogOff";
            this.buttonLogOff.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOff.TabIndex = 11;
            this.buttonLogOff.Text = "Log Off";
            this.buttonLogOff.UseVisualStyleBackColor = false;
            this.buttonLogOff.Click += new System.EventHandler(this.ButtonLogOff_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.SidePanel.Location = new System.Drawing.Point(7, 83);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 36);
            this.SidePanel.TabIndex = 4;
            // 
            // buttonBilling
            // 
            this.buttonBilling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonBilling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBilling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBilling.ForeColor = System.Drawing.Color.White;
            this.buttonBilling.Location = new System.Drawing.Point(-18, 194);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Size = new System.Drawing.Size(150, 36);
            this.buttonBilling.TabIndex = 6;
            this.buttonBilling.Text = "Billing";
            this.buttonBilling.UseVisualStyleBackColor = true;
            this.buttonBilling.Click += new System.EventHandler(this.billingButtonClick);
            // 
            // buttonPhysicians
            // 
            this.buttonPhysicians.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPhysicians.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPhysicians.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPhysicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhysicians.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhysicians.ForeColor = System.Drawing.Color.White;
            this.buttonPhysicians.Location = new System.Drawing.Point(0, 169);
            this.buttonPhysicians.Name = "buttonPhysicians";
            this.buttonPhysicians.Size = new System.Drawing.Size(150, 36);
            this.buttonPhysicians.TabIndex = 7;
            this.buttonPhysicians.Text = "Physicians";
            this.buttonPhysicians.UseVisualStyleBackColor = true;
            this.buttonPhysicians.Click += new System.EventHandler(this.physicianButtonClick);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointments.ForeColor = System.Drawing.Color.White;
            this.buttonAppointments.Location = new System.Drawing.Point(26, 142);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Size = new System.Drawing.Size(127, 36);
            this.buttonAppointments.TabIndex = 8;
            this.buttonAppointments.Text = "Appointments";
            this.buttonAppointments.UseVisualStyleBackColor = true;
            this.buttonAppointments.Click += new System.EventHandler(this.appointmentButtonClick);
            // 
            // buttonTreatments
            // 
            this.buttonTreatments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonTreatments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonTreatments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTreatments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTreatments.ForeColor = System.Drawing.Color.White;
            this.buttonTreatments.Location = new System.Drawing.Point(6, 111);
            this.buttonTreatments.Name = "buttonTreatments";
            this.buttonTreatments.Size = new System.Drawing.Size(150, 36);
            this.buttonTreatments.TabIndex = 9;
            this.buttonTreatments.Text = "Treatments";
            this.buttonTreatments.UseVisualStyleBackColor = true;
            this.buttonTreatments.Click += new System.EventHandler(this.buttonTreatmentsClick);
            // 
            // buttonPatients
            // 
            this.buttonPatients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPatients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatients.ForeColor = System.Drawing.Color.White;
            this.buttonPatients.Location = new System.Drawing.Point(-7, 83);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(150, 36);
            this.buttonPatients.TabIndex = 10;
            this.buttonPatients.Text = "Patients";
            this.buttonPatients.UseVisualStyleBackColor = true;
            this.buttonPatients.Click += new System.EventHandler(this.patientButtonClick);
            // 
            // patientControl
            // 
            this.patientControl.Location = new System.Drawing.Point(154, 80);
            this.patientControl.Name = "patientControl";
            this.patientControl.Size = new System.Drawing.Size(665, 294);
            this.patientControl.TabIndex = 12;
            // 
            // treatmentsControl
            // 
            this.treatmentsControl.Location = new System.Drawing.Point(154, 80);
            this.treatmentsControl.Name = "treatmentsControl";
            this.treatmentsControl.Size = new System.Drawing.Size(665, 294);
            this.treatmentsControl.TabIndex = 13;
            // 
            // appointmentControl
            // 
            this.appointmentControl.Location = new System.Drawing.Point(154, 80);
            this.appointmentControl.Name = "appointmentControl";
            this.appointmentControl.Size = new System.Drawing.Size(665, 294);
            this.appointmentControl.TabIndex = 14;
            // 
            // physiciansControl
            // 
            this.physiciansControl.Location = new System.Drawing.Point(154, 80);
            this.physiciansControl.Name = "physiciansControl";
            this.physiciansControl.Size = new System.Drawing.Size(665, 294);
            this.physiciansControl.TabIndex = 15;
            // 
            // billingControl
            // 
            this.billingControl.Location = new System.Drawing.Point(154, 80);
            this.billingControl.Name = "billingControl";
            this.billingControl.Size = new System.Drawing.Size(665, 294);
            this.billingControl.TabIndex = 16;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(343, 374);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(10, 13);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = " ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PhysicianUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(819, 396);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.buttonLogOff);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.buttonBilling);
            this.Controls.Add(this.buttonPhysicians);
            this.Controls.Add(this.buttonAppointments);
            this.Controls.Add(this.buttonTreatments);
            this.Controls.Add(this.buttonPatients);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.physiciansControl);
            this.Controls.Add(this.appointmentControl);
            this.Controls.Add(this.treatmentsControl);
            this.Controls.Add(this.patientControl);
            this.Controls.Add(this.billingControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhysicianUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogOff;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonBilling;
        private System.Windows.Forms.Button buttonPhysicians;
        private System.Windows.Forms.Button buttonAppointments;
        private System.Windows.Forms.Button buttonTreatments;
        private System.Windows.Forms.Button buttonPatients;
        private PatientList patientControl;
        private Treatments treatmentsControl;
        private Appointment appointmentControl;
        private PhysiciansList physiciansControl;
        private Billing billingControl;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
    }
}