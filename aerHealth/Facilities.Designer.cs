namespace aerHealth
{
    partial class Facilities
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
            this.aerButton = new System.Windows.Forms.Button();
            this.risButton = new System.Windows.Forms.Button();
            this.dgvAer = new System.Windows.Forms.DataGridView();
            this.dgvRis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRis)).BeginInit();
            this.SuspendLayout();
            // 
            // aerButton
            // 
            this.aerButton.BackColor = System.Drawing.Color.DarkOrange;
            this.aerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aerButton.ForeColor = System.Drawing.Color.White;
            this.aerButton.Location = new System.Drawing.Point(115, 3);
            this.aerButton.Name = "aerButton";
            this.aerButton.Size = new System.Drawing.Size(107, 37);
            this.aerButton.TabIndex = 1;
            this.aerButton.Text = "Aer";
            this.aerButton.UseVisualStyleBackColor = false;
            this.aerButton.Click += new System.EventHandler(this.AerButton_Click);
            // 
            // risButton
            // 
            this.risButton.BackColor = System.Drawing.Color.DarkOrange;
            this.risButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.risButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risButton.ForeColor = System.Drawing.Color.White;
            this.risButton.Location = new System.Drawing.Point(457, 3);
            this.risButton.Name = "risButton";
            this.risButton.Size = new System.Drawing.Size(104, 37);
            this.risButton.TabIndex = 2;
            this.risButton.Text = "Ris";
            this.risButton.UseVisualStyleBackColor = false;
            this.risButton.Click += new System.EventHandler(this.RisButton_Click);
            // 
            // dgvAer
            // 
            this.dgvAer.BackgroundColor = System.Drawing.Color.White;
            this.dgvAer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAer.Location = new System.Drawing.Point(16, 46);
            this.dgvAer.Name = "dgvAer";
            this.dgvAer.Size = new System.Drawing.Size(308, 232);
            this.dgvAer.TabIndex = 3;
            // 
            // dgvRis
            // 
            this.dgvRis.BackgroundColor = System.Drawing.Color.White;
            this.dgvRis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRis.Location = new System.Drawing.Point(345, 46);
            this.dgvRis.Name = "dgvRis";
            this.dgvRis.Size = new System.Drawing.Size(308, 232);
            this.dgvRis.TabIndex = 4;
            // 
            // Facilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRis);
            this.Controls.Add(this.dgvAer);
            this.Controls.Add(this.risButton);
            this.Controls.Add(this.aerButton);
            this.Name = "Facilities";
            this.Size = new System.Drawing.Size(665, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aerButton;
        private System.Windows.Forms.Button risButton;
        private System.Windows.Forms.DataGridView dgvAer;
        private System.Windows.Forms.DataGridView dgvRis;
    }
}
