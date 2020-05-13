namespace aerHealth
{
    partial class PatientUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonBilling = new System.Windows.Forms.Button();
            this.buttonFacilities = new System.Windows.Forms.Button();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.billingControl = new aerHealth.Billing();
            this.appointmentControl = new aerHealth.Appointment();
            this.welcomeControl = new aerHealth.Welcome();
            this.facilitiesControl = new aerHealth.Facilities();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 76);
            this.panel2.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(261, 82);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(10, 13);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 81);
            this.label2.TabIndex = 13;
            this.label2.Text = "aerHealth";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkOrange;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(14, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Log Off";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.logOffClick);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.SidePanel.Location = new System.Drawing.Point(5, 82);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 36);
            this.SidePanel.TabIndex = 6;
            // 
            // buttonBilling
            // 
            this.buttonBilling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonBilling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBilling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBilling.ForeColor = System.Drawing.Color.White;
            this.buttonBilling.Location = new System.Drawing.Point(14, 208);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Size = new System.Drawing.Size(65, 36);
            this.buttonBilling.TabIndex = 8;
            this.buttonBilling.Text = "Billing";
            this.buttonBilling.UseVisualStyleBackColor = true;
            this.buttonBilling.Click += new System.EventHandler(this.billingButtonClick);
            // 
            // buttonFacilities
            // 
            this.buttonFacilities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonFacilities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonFacilities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacilities.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacilities.ForeColor = System.Drawing.Color.White;
            this.buttonFacilities.Location = new System.Drawing.Point(14, 166);
            this.buttonFacilities.Name = "buttonFacilities";
            this.buttonFacilities.Size = new System.Drawing.Size(86, 36);
            this.buttonFacilities.TabIndex = 9;
            this.buttonFacilities.Text = "Facilities";
            this.buttonFacilities.UseVisualStyleBackColor = true;
            this.buttonFacilities.Click += new System.EventHandler(this.facilitiesButtonClick);
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointment.ForeColor = System.Drawing.Color.White;
            this.buttonAppointment.Location = new System.Drawing.Point(14, 124);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(127, 36);
            this.buttonAppointment.TabIndex = 10;
            this.buttonAppointment.Text = "Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = true;
            this.buttonAppointment.Click += new System.EventHandler(this.appointmentButtonClick);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(-24, 82);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(150, 36);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.homeButtonClick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(383, 379);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(10, 13);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = " ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // billingControl
            // 
            this.billingControl.BackColor = System.Drawing.Color.White;
            this.billingControl.Location = new System.Drawing.Point(154, 82);
            this.billingControl.Name = "billingControl";
            this.billingControl.Size = new System.Drawing.Size(665, 294);
            this.billingControl.TabIndex = 16;
            // 
            // appointmentControl
            // 
            this.appointmentControl.Location = new System.Drawing.Point(154, 82);
            this.appointmentControl.Name = "appointmentControl";
            this.appointmentControl.Size = new System.Drawing.Size(665, 294);
            this.appointmentControl.TabIndex = 15;
            // 
            // welcomeControl
            // 
            this.welcomeControl.BackColor = System.Drawing.Color.White;
            this.welcomeControl.Location = new System.Drawing.Point(154, 82);
            this.welcomeControl.Name = "welcomeControl";
            this.welcomeControl.Size = new System.Drawing.Size(653, 294);
            this.welcomeControl.TabIndex = 14;
            // 
            // facilitiesControl
            // 
            this.facilitiesControl.Location = new System.Drawing.Point(154, 82);
            this.facilitiesControl.Name = "facilitiesControl";
            this.facilitiesControl.Size = new System.Drawing.Size(665, 294);
            this.facilitiesControl.TabIndex = 17;
            // 
            // PatientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(819, 396);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.billingControl);
            this.Controls.Add(this.appointmentControl);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonAppointment);
            this.Controls.Add(this.buttonFacilities);
            this.Controls.Add(this.buttonBilling);
            this.Controls.Add(this.welcomeControl);
            this.Controls.Add(this.facilitiesControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonBilling;
        private System.Windows.Forms.Button buttonFacilities;
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonHome;
        private Welcome welcomeControl;
        private Appointment appointmentControl;
        private Billing billingControl;
        private Facilities facilitiesControl;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
    }
}