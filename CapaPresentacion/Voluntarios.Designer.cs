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
            this.dgvVoluntario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreVoluntario
            // 
            this.txtNombreVoluntario.Location = new System.Drawing.Point(480, 89);
            this.txtNombreVoluntario.Name = "txtNombreVoluntario";
            this.txtNombreVoluntario.Size = new System.Drawing.Size(382, 22);
            this.txtNombreVoluntario.TabIndex = 5;
            this.txtNombreVoluntario.TextChanged += new System.EventHandler(this.txtNombreOrg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Voluntario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvVoluntario
            // 
            this.dgvVoluntario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoluntario.Location = new System.Drawing.Point(100, 189);
            this.dgvVoluntario.Name = "dgvVoluntario";
            this.dgvVoluntario.RowHeadersWidth = 51;
            this.dgvVoluntario.RowTemplate.Height = 24;
            this.dgvVoluntario.Size = new System.Drawing.Size(975, 362);
            this.dgvVoluntario.TabIndex = 3;
            this.dgvVoluntario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganizacion_CellContentClick);
            // 
            // Voluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 641);
            this.Controls.Add(this.txtNombreVoluntario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVoluntario);
            this.Name = "Voluntarios";
            this.Text = "Voluntarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreVoluntario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVoluntario;
    }
}