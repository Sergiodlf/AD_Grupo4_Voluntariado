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
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.lblOrganizaciones = new System.Windows.Forms.Label();
            this.lblActividades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizacion
            // 
            this.dgvOrganizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizacion.Location = new System.Drawing.Point(120, 96);
            this.dgvOrganizacion.Name = "dgvOrganizacion";
            this.dgvOrganizacion.RowHeadersWidth = 51;
            this.dgvOrganizacion.RowTemplate.Height = 24;
            this.dgvOrganizacion.Size = new System.Drawing.Size(975, 239);
            this.dgvOrganizacion.TabIndex = 0;
            this.dgvOrganizacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganizacion_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Organización:";
            // 
            // txtNombreOrg
            // 
            this.txtNombreOrg.Location = new System.Drawing.Point(500, 22);
            this.txtNombreOrg.Name = "txtNombreOrg";
            this.txtNombreOrg.Size = new System.Drawing.Size(382, 22);
            this.txtNombreOrg.TabIndex = 2;
            this.txtNombreOrg.TextChanged += new System.EventHandler(this.txtNombreOrg_TextChanged);
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(120, 402);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(975, 231);
            this.dgvActividades.TabIndex = 16;
            // 
            // lblOrganizaciones
            // 
            this.lblOrganizaciones.AutoSize = true;
            this.lblOrganizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizaciones.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrganizaciones.Location = new System.Drawing.Point(140, 63);
            this.lblOrganizaciones.Name = "lblOrganizaciones";
            this.lblOrganizaciones.Size = new System.Drawing.Size(148, 22);
            this.lblOrganizaciones.TabIndex = 17;
            this.lblOrganizaciones.Text = "Organizaciones";
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblActividades.Location = new System.Drawing.Point(140, 366);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(0, 22);
            this.lblActividades.TabIndex = 18;
            // 
            // Organizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 688);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.lblOrganizaciones);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.txtNombreOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrganizacion);
            this.Name = "Organizaciones";
            this.Text = "Organizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreOrg;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label lblOrganizaciones;
        private System.Windows.Forms.Label lblActividades;
    }
}