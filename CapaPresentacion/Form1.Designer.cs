namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrganizacionesODS = new System.Windows.Forms.Button();
            this.btnVoluntariosODS = new System.Windows.Forms.Button();
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnActividadesODS = new System.Windows.Forms.Button();
            this.btnOrganizaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbODS = new System.Windows.Forms.ListBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrganizacionesODS
            // 
            this.btnOrganizacionesODS.Location = new System.Drawing.Point(31, 104);
            this.btnOrganizacionesODS.Name = "btnOrganizacionesODS";
            this.btnOrganizacionesODS.Size = new System.Drawing.Size(250, 69);
            this.btnOrganizacionesODS.TabIndex = 19;
            this.btnOrganizacionesODS.Text = "Organizaciones que han realizado actividades con ODS seleccionadas";
            this.btnOrganizacionesODS.UseVisualStyleBackColor = true;
            // 
            // btnVoluntariosODS
            // 
            this.btnVoluntariosODS.Location = new System.Drawing.Point(31, 29);
            this.btnVoluntariosODS.Name = "btnVoluntariosODS";
            this.btnVoluntariosODS.Size = new System.Drawing.Size(250, 69);
            this.btnVoluntariosODS.TabIndex = 18;
            this.btnVoluntariosODS.Text = "Voluntarios que han participado en actividades con ODS seleccionadas";
            this.btnVoluntariosODS.UseVisualStyleBackColor = true;
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.Location = new System.Drawing.Point(572, 29);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Size = new System.Drawing.Size(217, 69);
            this.btnVoluntarios.TabIndex = 17;
            this.btnVoluntarios.Text = "Mostrar voluntarios";
            this.btnVoluntarios.UseVisualStyleBackColor = true;
            // 
            // btnActividades
            // 
            this.btnActividades.Location = new System.Drawing.Point(301, 104);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(250, 69);
            this.btnActividades.TabIndex = 16;
            this.btnActividades.Text = "Mostrar actividades";
            this.btnActividades.UseVisualStyleBackColor = true;
            // 
            // btnActividadesODS
            // 
            this.btnActividadesODS.Location = new System.Drawing.Point(301, 29);
            this.btnActividadesODS.Name = "btnActividadesODS";
            this.btnActividadesODS.Size = new System.Drawing.Size(250, 69);
            this.btnActividadesODS.TabIndex = 15;
            this.btnActividadesODS.Text = "Actividades por ODS seleccionadas";
            this.btnActividadesODS.UseVisualStyleBackColor = true;
            // 
            // btnOrganizaciones
            // 
            this.btnOrganizaciones.Location = new System.Drawing.Point(572, 104);
            this.btnOrganizaciones.Name = "btnOrganizaciones";
            this.btnOrganizaciones.Size = new System.Drawing.Size(217, 69);
            this.btnOrganizaciones.TabIndex = 14;
            this.btnOrganizaciones.Text = "Mostrar Organizaciones";
            this.btnOrganizaciones.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccionar ODS";
            // 
            // lsbODS
            // 
            this.lsbODS.FormattingEnabled = true;
            this.lsbODS.ItemHeight = 16;
            this.lsbODS.Location = new System.Drawing.Point(28, 216);
            this.lsbODS.Name = "lsbODS";
            this.lsbODS.Size = new System.Drawing.Size(282, 356);
            this.lsbODS.TabIndex = 12;
            // 
            // lblInformacion
            // 
            this.lblInformacion.BackColor = System.Drawing.Color.PaleGreen;
            this.lblInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformacion.Location = new System.Drawing.Point(325, 186);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(1008, 23);
            this.lblInformacion.TabIndex = 11;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(325, 221);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1008, 354);
            this.dgv.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 604);
            this.Controls.Add(this.btnOrganizacionesODS);
            this.Controls.Add(this.btnVoluntariosODS);
            this.Controls.Add(this.btnVoluntarios);
            this.Controls.Add(this.btnActividades);
            this.Controls.Add(this.btnActividadesODS);
            this.Controls.Add(this.btnOrganizaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbODS);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizacionesODS;
        private System.Windows.Forms.Button btnVoluntariosODS;
        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnActividadesODS;
        private System.Windows.Forms.Button btnOrganizaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbODS;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridView dgv;
    }
}

