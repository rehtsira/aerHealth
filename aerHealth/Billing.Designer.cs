namespace aerHealth
{
    partial class Billing
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
            this.buttonBilling = new System.Windows.Forms.Button();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBilling
            // 
            this.buttonBilling.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonBilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBilling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBilling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBilling.ForeColor = System.Drawing.Color.White;
            this.buttonBilling.Location = new System.Drawing.Point(269, 2);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Size = new System.Drawing.Size(146, 40);
            this.buttonBilling.TabIndex = 2;
            this.buttonBilling.Text = "Check Billing";
            this.buttonBilling.UseVisualStyleBackColor = false;
            this.buttonBilling.Click += new System.EventHandler(this.ButtonBilling_Click);
            // 
            // dgvBilling
            // 
            this.dgvBilling.BackgroundColor = System.Drawing.Color.White;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(78, 46);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.Size = new System.Drawing.Size(517, 240);
            this.dgvBilling.TabIndex = 3;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.buttonBilling);
            this.Name = "Billing";
            this.Size = new System.Drawing.Size(665, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBilling;
        private System.Windows.Forms.DataGridView dgvBilling;
    }
}
