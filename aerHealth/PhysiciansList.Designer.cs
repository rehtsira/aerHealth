namespace aerHealth
{
    partial class PhysiciansList
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
            this.buttonPhysicianList = new System.Windows.Forms.Button();
            this.dgvPhysicianList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhysicianList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPhysicianList
            // 
            this.buttonPhysicianList.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPhysicianList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPhysicianList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPhysicianList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhysicianList.ForeColor = System.Drawing.Color.White;
            this.buttonPhysicianList.Location = new System.Drawing.Point(239, 3);
            this.buttonPhysicianList.Name = "buttonPhysicianList";
            this.buttonPhysicianList.Size = new System.Drawing.Size(181, 37);
            this.buttonPhysicianList.TabIndex = 1;
            this.buttonPhysicianList.Text = "Physician List";
            this.buttonPhysicianList.UseVisualStyleBackColor = false;
            this.buttonPhysicianList.Click += new System.EventHandler(this.physicianListButtonClick);
            // 
            // dgvPhysicianList
            // 
            this.dgvPhysicianList.AllowUserToAddRows = false;
            this.dgvPhysicianList.AllowUserToDeleteRows = false;
            this.dgvPhysicianList.AllowUserToResizeColumns = false;
            this.dgvPhysicianList.AllowUserToResizeRows = false;
            this.dgvPhysicianList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhysicianList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhysicianList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhysicianList.Location = new System.Drawing.Point(28, 43);
            this.dgvPhysicianList.Name = "dgvPhysicianList";
            this.dgvPhysicianList.Size = new System.Drawing.Size(607, 244);
            this.dgvPhysicianList.TabIndex = 2;
            // 
            // PhysiciansList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPhysicianList);
            this.Controls.Add(this.buttonPhysicianList);
            this.Name = "PhysiciansList";
            this.Size = new System.Drawing.Size(665, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhysicianList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPhysicianList;
        private System.Windows.Forms.DataGridView dgvPhysicianList;
    }
}
