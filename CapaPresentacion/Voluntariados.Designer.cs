namespace CapaPresentacion
{
    partial class Voluntariados
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblNombreOrg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmailOrg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvVoluntarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.lblVoluntarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(289, 27);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(267, 22);
            this.dtpInicio.TabIndex = 0;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(649, 27);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(262, 22);
            this.dtpFin.TabIndex = 1;
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(128, 98);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(975, 208);
            this.dgvActividades.TabIndex = 4;
            this.dgvActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "CIF: ";
            // 
            // lblCIF
            // 
            this.lblCIF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCIF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCIF.Location = new System.Drawing.Point(177, 349);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(96, 23);
            this.lblCIF.TabIndex = 17;
            // 
            // lblNombreOrg
            // 
            this.lblNombreOrg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreOrg.Location = new System.Drawing.Point(381, 349);
            this.lblNombreOrg.Name = "lblNombreOrg";
            this.lblNombreOrg.Size = new System.Drawing.Size(289, 23);
            this.lblNombreOrg.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre:";
            // 
            // lblEmailOrg
            // 
            this.lblEmailOrg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmailOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmailOrg.Location = new System.Drawing.Point(756, 349);
            this.lblEmailOrg.Name = "lblEmailOrg";
            this.lblEmailOrg.Size = new System.Drawing.Size(347, 23);
            this.lblEmailOrg.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email:";
            // 
            // dgvVoluntarios
            // 
            this.dgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoluntarios.Location = new System.Drawing.Point(128, 425);
            this.dgvVoluntarios.Name = "dgvVoluntarios";
            this.dgvVoluntarios.RowHeadersWidth = 51;
            this.dgvVoluntarios.RowTemplate.Height = 24;
            this.dgvVoluntarios.Size = new System.Drawing.Size(975, 208);
            this.dgvVoluntarios.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnBuscar.Location = new System.Drawing.Point(928, 26);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 26);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(592, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 25;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblActividades.Location = new System.Drawing.Point(134, 63);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(113, 22);
            this.lblActividades.TabIndex = 26;
            this.lblActividades.Text = "Actividades";
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizacion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrganizacion.Location = new System.Drawing.Point(134, 309);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(0, 22);
            this.lblOrganizacion.TabIndex = 27;
            // 
            // lblVoluntarios
            // 
            this.lblVoluntarios.AutoSize = true;
            this.lblVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoluntarios.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVoluntarios.Location = new System.Drawing.Point(134, 390);
            this.lblVoluntarios.Name = "lblVoluntarios";
            this.lblVoluntarios.Size = new System.Drawing.Size(0, 22);
            this.lblVoluntarios.TabIndex = 28;
            // 
            // Voluntariados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.lblVoluntarios);
            this.Controls.Add(this.lblOrganizacion);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvVoluntarios);
            this.Controls.Add(this.lblEmailOrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombreOrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Name = "Voluntariados";
            this.Text = "Voluntariados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblNombreOrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmailOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvVoluntarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.Label lblVoluntarios;
    }
}