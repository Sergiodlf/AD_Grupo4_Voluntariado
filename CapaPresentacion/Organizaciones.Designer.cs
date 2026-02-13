namespace CapaPresentacion
{
    partial class Organizaciones
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
            this.dgvOrganizacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreOrg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizacion
            // 
            this.dgvOrganizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizacion.Location = new System.Drawing.Point(120, 245);
            this.dgvOrganizacion.Name = "dgvOrganizacion";
            this.dgvOrganizacion.RowHeadersWidth = 51;
            this.dgvOrganizacion.RowTemplate.Height = 24;
            this.dgvOrganizacion.Size = new System.Drawing.Size(975, 362);
            this.dgvOrganizacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Organización:";
            // 
            // txtNombreOrg
            // 
            this.txtNombreOrg.Location = new System.Drawing.Point(500, 145);
            this.txtNombreOrg.Name = "txtNombreOrg";
            this.txtNombreOrg.Size = new System.Drawing.Size(382, 22);
            this.txtNombreOrg.TabIndex = 2;
            // 
            // Organizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 688);
            this.Controls.Add(this.txtNombreOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrganizacion);
            this.Name = "Organizaciones";
            this.Text = "Organizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreOrg;
    }
}