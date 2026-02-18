namespace CapaPresentacion
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionalidadesDeAnálisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorODSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorVoluntariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaVoluntariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVoluntariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaOrganizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrganizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionalidadesDeAnálisisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionalidadesDeAnálisisToolStripMenuItem
            // 
            this.funcionalidadesDeAnálisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrarPorODSToolStripMenuItem,
            this.filtrarPorVoluntariosToolStripMenuItem,
            this.organizacionesToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.crearMatchToolStripMenuItem,
            this.estadísticasGeneralesToolStripMenuItem});
            this.funcionalidadesDeAnálisisToolStripMenuItem.Name = "funcionalidadesDeAnálisisToolStripMenuItem";
            this.funcionalidadesDeAnálisisToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.funcionalidadesDeAnálisisToolStripMenuItem.Text = "Funcionalidades De Análisis";
            // 
            // filtrarPorODSToolStripMenuItem
            // 
            this.filtrarPorODSToolStripMenuItem.Name = "filtrarPorODSToolStripMenuItem";
            this.filtrarPorODSToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.filtrarPorODSToolStripMenuItem.Text = "Filtrar por ODS";
            this.filtrarPorODSToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorODSToolStripMenuItem_Click);
            // 
            // filtrarPorVoluntariosToolStripMenuItem
            // 
            this.filtrarPorVoluntariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaVoluntariosToolStripMenuItem1,
            this.consultarVoluntariosToolStripMenuItem});
            this.filtrarPorVoluntariosToolStripMenuItem.Name = "filtrarPorVoluntariosToolStripMenuItem";
            this.filtrarPorVoluntariosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.filtrarPorVoluntariosToolStripMenuItem.Text = "Voluntarios";
            this.filtrarPorVoluntariosToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorVoluntariosToolStripMenuItem_Click);
            // 
            // altaVoluntariosToolStripMenuItem1
            // 
            this.altaVoluntariosToolStripMenuItem1.Name = "altaVoluntariosToolStripMenuItem1";
            this.altaVoluntariosToolStripMenuItem1.Size = new System.Drawing.Size(232, 26);
            this.altaVoluntariosToolStripMenuItem1.Text = "Alta Voluntarios";
            this.altaVoluntariosToolStripMenuItem1.Click += new System.EventHandler(this.altaVoluntariosToolStripMenuItem1_Click);
            // 
            // consultarVoluntariosToolStripMenuItem
            // 
            this.consultarVoluntariosToolStripMenuItem.Name = "consultarVoluntariosToolStripMenuItem";
            this.consultarVoluntariosToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.consultarVoluntariosToolStripMenuItem.Text = "Consultar Voluntarios";
            this.consultarVoluntariosToolStripMenuItem.Click += new System.EventHandler(this.consultarVoluntariosToolStripMenuItem_Click);
            // 
            // organizacionesToolStripMenuItem
            // 
            this.organizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaOrganizacionesToolStripMenuItem,
            this.consultarOrganizacionesToolStripMenuItem});
            this.organizacionesToolStripMenuItem.Name = "organizacionesToolStripMenuItem";
            this.organizacionesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.organizacionesToolStripMenuItem.Text = "Organizaciones";
            this.organizacionesToolStripMenuItem.Click += new System.EventHandler(this.organizacionesToolStripMenuItem_Click);
            // 
            // altaOrganizacionesToolStripMenuItem
            // 
            this.altaOrganizacionesToolStripMenuItem.Name = "altaOrganizacionesToolStripMenuItem";
            this.altaOrganizacionesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.altaOrganizacionesToolStripMenuItem.Text = "Alta Organizaciones";
            this.altaOrganizacionesToolStripMenuItem.Click += new System.EventHandler(this.altaOrganizacionesToolStripMenuItem_Click);
            // 
            // consultarOrganizacionesToolStripMenuItem
            // 
            this.consultarOrganizacionesToolStripMenuItem.Name = "consultarOrganizacionesToolStripMenuItem";
            this.consultarOrganizacionesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.consultarOrganizacionesToolStripMenuItem.Text = "Consultar Organizaciones";
            this.consultarOrganizacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarOrganizacionesToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearActividadToolStripMenuItem,
            this.consultarActividadesToolStripMenuItem});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            this.actividadesToolStripMenuItem.Click += new System.EventHandler(this.actividadesToolStripMenuItem_Click);
            // 
            // crearActividadToolStripMenuItem
            // 
            this.crearActividadToolStripMenuItem.Name = "crearActividadToolStripMenuItem";
            this.crearActividadToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.crearActividadToolStripMenuItem.Text = "Crear Actividad";
            this.crearActividadToolStripMenuItem.Click += new System.EventHandler(this.crearActividadToolStripMenuItem_Click);
            // 
            // consultarActividadesToolStripMenuItem
            // 
            this.consultarActividadesToolStripMenuItem.Name = "consultarActividadesToolStripMenuItem";
            this.consultarActividadesToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultarActividadesToolStripMenuItem.Text = "Consultar Actividades";
            this.consultarActividadesToolStripMenuItem.Click += new System.EventHandler(this.consultarActividadesToolStripMenuItem_Click);
            // 
            // crearMatchToolStripMenuItem
            // 
            this.crearMatchToolStripMenuItem.Name = "crearMatchToolStripMenuItem";
            this.crearMatchToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.crearMatchToolStripMenuItem.Text = "Crear Match";
            this.crearMatchToolStripMenuItem.Click += new System.EventHandler(this.crearMatchToolStripMenuItem_Click);
            // 
            // estadísticasGeneralesToolStripMenuItem
            // 
            this.estadísticasGeneralesToolStripMenuItem.Name = "estadísticasGeneralesToolStripMenuItem";
            this.estadísticasGeneralesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.estadísticasGeneralesToolStripMenuItem.Text = "Estadísticas Generales";
            this.estadísticasGeneralesToolStripMenuItem.Click += new System.EventHandler(this.estadísticasGeneralesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(164, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenid@ al panel de análisis del voluntariado4V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(278, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empiece seleccionando una opción del menú de funcionalidades";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesDeAnálisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorODSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorVoluntariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem altaVoluntariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarVoluntariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaOrganizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrganizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasGeneralesToolStripMenuItem;
    }
}