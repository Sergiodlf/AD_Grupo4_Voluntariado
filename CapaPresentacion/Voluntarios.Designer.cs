namespace CapaPresentacion
{
    partial class Voluntarios
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
            this.txtNombreVoluntario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVoluntarios = new System.Windows.Forms.DataGridView();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.lblVoluntarios = new System.Windows.Forms.Label();
            this.lblActividades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreVoluntario
            // 
            this.txtNombreVoluntario.Location = new System.Drawing.Point(480, 25);
            this.txtNombreVoluntario.Name = "txtNombreVoluntario";
            this.txtNombreVoluntario.Size = new System.Drawing.Size(382, 22);
            this.txtNombreVoluntario.TabIndex = 5;
            this.txtNombreVoluntario.TextChanged += new System.EventHandler(this.txtNombreOrg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Voluntario:";
            // 
            // dgvVoluntarios
            // 
            this.dgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoluntarios.Location = new System.Drawing.Point(100, 86);
            this.dgvVoluntarios.Name = "dgvVoluntarios";
            this.dgvVoluntarios.RowHeadersWidth = 51;
            this.dgvVoluntarios.RowTemplate.Height = 24;
            this.dgvVoluntarios.Size = new System.Drawing.Size(975, 231);
            this.dgvVoluntarios.TabIndex = 3;
            this.dgvVoluntarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoluntarios_CellClick);
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(100, 378);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(975, 231);
            this.dgvActividades.TabIndex = 14;
            // 
            // lblVoluntarios
            // 
            this.lblVoluntarios.AutoSize = true;
            this.lblVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoluntarios.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVoluntarios.Location = new System.Drawing.Point(127, 55);
            this.lblVoluntarios.Name = "lblVoluntarios";
            this.lblVoluntarios.Size = new System.Drawing.Size(111, 22);
            this.lblVoluntarios.TabIndex = 18;
            this.lblVoluntarios.Text = "Voluntarios";
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblActividades.Location = new System.Drawing.Point(127, 337);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(0, 22);
            this.lblActividades.TabIndex = 19;
            // 
            // Voluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 641);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.lblVoluntarios);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.txtNombreVoluntario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVoluntarios);
            this.Name = "Voluntarios";
            this.Text = "Voluntarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreVoluntario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVoluntarios;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label lblVoluntarios;
        private System.Windows.Forms.Label lblActividades;
    }
}