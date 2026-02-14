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
            this.lblActividades = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInformacionOrganizacion = new System.Windows.Forms.Label();
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblNombreOrg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmailOrg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVoluntarios = new System.Windows.Forms.Label();
            this.dgvVoluntarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(344, 25);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(255, 22);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(704, 25);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(249, 22);
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
            this.label1.Location = new System.Drawing.Point(256, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Fin:";
            // 
            // lblActividades
            // 
            this.lblActividades.BackColor = System.Drawing.Color.PaleGreen;
            this.lblActividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividades.Location = new System.Drawing.Point(128, 66);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(975, 23);
            this.lblActividades.TabIndex = 14;
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
            // lblInformacionOrganizacion
            // 
            this.lblInformacionOrganizacion.BackColor = System.Drawing.Color.PaleGreen;
            this.lblInformacionOrganizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformacionOrganizacion.Location = new System.Drawing.Point(128, 320);
            this.lblInformacionOrganizacion.Name = "lblInformacionOrganizacion";
            this.lblInformacionOrganizacion.Size = new System.Drawing.Size(975, 23);
            this.lblInformacionOrganizacion.TabIndex = 16;
            // 
            // lblCIF
            // 
            this.lblCIF.BackColor = System.Drawing.Color.PaleGreen;
            this.lblCIF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCIF.Location = new System.Drawing.Point(177, 349);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(96, 23);
            this.lblCIF.TabIndex = 17;
            // 
            // lblNombreOrg
            // 
            this.lblNombreOrg.BackColor = System.Drawing.Color.PaleGreen;
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
            this.lblEmailOrg.BackColor = System.Drawing.Color.PaleGreen;
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
            // lblVoluntarios
            // 
            this.lblVoluntarios.BackColor = System.Drawing.Color.PaleGreen;
            this.lblVoluntarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVoluntarios.Location = new System.Drawing.Point(128, 390);
            this.lblVoluntarios.Name = "lblVoluntarios";
            this.lblVoluntarios.Size = new System.Drawing.Size(975, 23);
            this.lblVoluntarios.TabIndex = 22;
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
            this.btnBuscar.Location = new System.Drawing.Point(1002, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Voluntariados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvVoluntarios);
            this.Controls.Add(this.lblVoluntarios);
            this.Controls.Add(this.lblEmailOrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombreOrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCIF);
            this.Controls.Add(this.lblInformacionOrganizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblActividades);
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
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInformacionOrganizacion;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblNombreOrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmailOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVoluntarios;
        private System.Windows.Forms.DataGridView dgvVoluntarios;
        private System.Windows.Forms.Button btnBuscar;
    }
}