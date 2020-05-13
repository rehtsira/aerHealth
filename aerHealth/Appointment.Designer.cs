namespace aerHealth
{
    partial class Appointment
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
            this.appointmentButton = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentButton
            // 
            this.appointmentButton.BackColor = System.Drawing.Color.DarkOrange;
            this.appointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appointmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentButton.ForeColor = System.Drawing.Color.White;
            this.appointmentButton.Location = new System.Drawing.Point(239, 6);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(181, 34);
            this.appointmentButton.TabIndex = 1;
            this.appointmentButton.Text = "View Appointments";
            this.appointmentButton.UseVisualStyleBackColor = false;
            this.appointmentButton.Click += new System.EventHandler(this.AppointmentButton_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(26, 43);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(617, 243);
            this.dgvAppointment.TabIndex = 2;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.appointmentButton);
            this.Name = "Appointment";
            this.Size = new System.Drawing.Size(665, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.DataGridView dgvAppointment;
    }
}
