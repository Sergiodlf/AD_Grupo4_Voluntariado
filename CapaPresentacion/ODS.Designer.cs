namespace CapaPresentacion
{
    partial class ODS
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
            this.btnActividadesODS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbODS = new System.Windows.Forms.ListBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrganizacionesODS
            // 
            this.btnOrganizacionesODS.Location = new System.Drawing.Point(22, 282);
            this.btnOrganizacionesODS.Name = "btnOrganizacionesODS";
            this.btnOrganizacionesODS.Size = new System.Drawing.Size(282, 69);
            this.btnOrganizacionesODS.TabIndex = 19;
            this.btnOrganizacionesODS.Text = "Organizaciones que han realizado actividades con ODS seleccionadas";
            this.btnOrganizacionesODS.UseVisualStyleBackColor = true;
            this.btnOrganizacionesODS.Click += new System.EventHandler(this.btnOrganizacionesODS_Click);
            // 
            // btnVoluntariosODS
            // 
            this.btnVoluntariosODS.Location = new System.Drawing.Point(22, 372);
            this.btnVoluntariosODS.Name = "btnVoluntariosODS";
            this.btnVoluntariosODS.Size = new System.Drawing.Size(282, 69);
            this.btnVoluntariosODS.TabIndex = 18;
            this.btnVoluntariosODS.Text = "Voluntarios que han participado en actividades con ODS seleccionadas";
            this.btnVoluntariosODS.UseVisualStyleBackColor = true;
            this.btnVoluntariosODS.Click += new System.EventHandler(this.btnVoluntariosODS_Click);
            // 
            // btnActividadesODS
            // 
            this.btnActividadesODS.Location = new System.Drawing.Point(22, 468);
            this.btnActividadesODS.Name = "btnActividadesODS";
            this.btnActividadesODS.Size = new System.Drawing.Size(282, 69);
            this.btnActividadesODS.TabIndex = 15;
            this.btnActividadesODS.Text = "Actividades por ODS seleccionadas";
            this.btnActividadesODS.UseVisualStyleBackColor = true;
            this.btnActividadesODS.Click += new System.EventHandler(this.btnActividadesODS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccionar ODS";
            // 
            // lsbODS
            // 
            this.lsbODS.FormattingEnabled = true;
            this.lsbODS.ItemHeight = 16;
            this.lsbODS.Location = new System.Drawing.Point(22, 60);
            this.lsbODS.Name = "lsbODS";
            this.lsbODS.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbODS.Size = new System.Drawing.Size(282, 180);
            this.lsbODS.TabIndex = 12;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(339, 138);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1016, 399);
            this.dgv.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(335, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 20;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ODS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrganizacionesODS);
            this.Controls.Add(this.btnVoluntariosODS);
            this.Controls.Add(this.btnActividadesODS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbODS);
            this.Controls.Add(this.dgv);
            this.Name = "ODS";
            this.Text = "Informes del voluntariado cuatrovientos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizacionesODS;
        private System.Windows.Forms.Button btnVoluntariosODS;
        private System.Windows.Forms.Button btnActividadesODS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbODS;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
    }
}

