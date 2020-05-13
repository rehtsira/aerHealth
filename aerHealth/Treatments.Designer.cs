namespace aerHealth
{
    partial class Treatments
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
            this.buttonTreatment = new System.Windows.Forms.Button();
            this.dgvTreatment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTreatment
            // 
            this.buttonTreatment.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTreatment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTreatment.ForeColor = System.Drawing.Color.White;
            this.buttonTreatment.Location = new System.Drawing.Point(222, 3);
            this.buttonTreatment.Name = "buttonTreatment";
            this.buttonTreatment.Size = new System.Drawing.Size(210, 26);
            this.buttonTreatment.TabIndex = 1;
            this.buttonTreatment.Text = "View Patient Treatments";
            this.buttonTreatment.UseVisualStyleBackColor = false;
            this.buttonTreatment.Click += new System.EventHandler(this.ButtonTreatment_Click);
            // 
            // dgvTreatment
            // 
            this.dgvTreatment.BackgroundColor = System.Drawing.Color.White;
            this.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatment.Location = new System.Drawing.Point(131, 35);
            this.dgvTreatment.Name = "dgvTreatment";
            this.dgvTreatment.Size = new System.Drawing.Size(394, 246);
            this.dgvTreatment.TabIndex = 2;
            // 
            // Treatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTreatment);
            this.Controls.Add(this.buttonTreatment);
            this.Name = "Treatments";
            this.Size = new System.Drawing.Size(665, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTreatment;
        private System.Windows.Forms.DataGridView dgvTreatment;
    }
}
