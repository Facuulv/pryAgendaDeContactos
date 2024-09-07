namespace pryAgendaDeContactos
{
    partial class frmVentanaPrincipal
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Contactos");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nodo1");
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.scContactos = new System.Windows.Forms.SplitContainer();
            this.tvContactos = new System.Windows.Forms.TreeView();
            this.gbDatosContacto = new System.Windows.Forms.GroupBox();
            this.lblRelacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbMyE = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbCategorias = new System.Windows.Forms.ToolStripDropDownButton();
            this.agregarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdbExportar = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportarACSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarATXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbContacto = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContactos)).BeginInit();
            this.scContactos.Panel1.SuspendLayout();
            this.scContactos.Panel2.SuspendLayout();
            this.scContactos.SuspendLayout();
            this.gbDatosContacto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.OldLace;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.toolStripSeparator3,
            this.tsbMyE,
            this.toolStripSeparator2,
            this.tsbBuscar,
            this.toolStripSeparator5,
            this.tsbCategorias,
            this.toolStripSeparator4,
            this.tsdbExportar,
            this.toolStripSeparator6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(678, 47);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 47);
            // 
            // scContactos
            // 
            this.scContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scContactos.Location = new System.Drawing.Point(12, 137);
            this.scContactos.Name = "scContactos";
            // 
            // scContactos.Panel1
            // 
            this.scContactos.Panel1.Controls.Add(this.tvContactos);
            // 
            // scContactos.Panel2
            // 
            this.scContactos.Panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.scContactos.Panel2.Controls.Add(this.gbDatosContacto);
            this.scContactos.Size = new System.Drawing.Size(645, 333);
            this.scContactos.SplitterDistance = 213;
            this.scContactos.TabIndex = 11;
            // 
            // tvContactos
            // 
            this.tvContactos.BackColor = System.Drawing.Color.OldLace;
            this.tvContactos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvContactos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvContactos.HideSelection = false;
            this.tvContactos.Location = new System.Drawing.Point(0, 0);
            this.tvContactos.Name = "tvContactos";
            treeNode7.Name = "Nodo0";
            treeNode7.Text = "Contactos";
            treeNode8.Name = "Nodo1";
            treeNode8.Text = "Nodo1";
            this.tvContactos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.tvContactos.ShowNodeToolTips = true;
            this.tvContactos.Size = new System.Drawing.Size(209, 329);
            this.tvContactos.TabIndex = 2;
            this.tvContactos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvContactos_AfterSelect);
            // 
            // gbDatosContacto
            // 
            this.gbDatosContacto.Controls.Add(this.lblRelacion);
            this.gbDatosContacto.Controls.Add(this.label11);
            this.gbDatosContacto.Controls.Add(this.lblCorreo);
            this.gbDatosContacto.Controls.Add(this.label9);
            this.gbDatosContacto.Controls.Add(this.lblTelefono);
            this.gbDatosContacto.Controls.Add(this.label7);
            this.gbDatosContacto.Controls.Add(this.lblApellido);
            this.gbDatosContacto.Controls.Add(this.label5);
            this.gbDatosContacto.Controls.Add(this.lblNombre);
            this.gbDatosContacto.Controls.Add(this.label2);
            this.gbDatosContacto.Controls.Add(this.pbContacto);
            this.gbDatosContacto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosContacto.Location = new System.Drawing.Point(20, 3);
            this.gbDatosContacto.Name = "gbDatosContacto";
            this.gbDatosContacto.Size = new System.Drawing.Size(383, 319);
            this.gbDatosContacto.TabIndex = 0;
            this.gbDatosContacto.TabStop = false;
            this.gbDatosContacto.Text = "DATOS DEL CONTACTO";
            // 
            // lblRelacion
            // 
            this.lblRelacion.BackColor = System.Drawing.Color.PeachPuff;
            this.lblRelacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRelacion.Location = new System.Drawing.Point(122, 257);
            this.lblRelacion.Name = "lblRelacion";
            this.lblRelacion.Size = new System.Drawing.Size(215, 28);
            this.lblRelacion.TabIndex = 11;
            this.lblRelacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "RELACIÓN:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.BackColor = System.Drawing.Color.PeachPuff;
            this.lblCorreo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorreo.Location = new System.Drawing.Point(122, 202);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(215, 28);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "CORREO:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefono.Location = new System.Drawing.Point(122, 147);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(215, 28);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "TELÉFONO:";
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.PeachPuff;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Location = new System.Drawing.Point(204, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(133, 28);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "APELLIDO:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.PeachPuff;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(204, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 27);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 53);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agenda de Contactos";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = global::pryAgendaDeContactos.Properties.Resources.person_add_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(83, 44);
            this.tsbAgregar.Text = "AGREGAR";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbMyE
            // 
            this.tsbMyE.Image = global::pryAgendaDeContactos.Properties.Resources.settings_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbMyE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMyE.Name = "tsbMyE";
            this.tsbMyE.Size = new System.Drawing.Size(152, 44);
            this.tsbMyE.Text = "MODIFICAR/ELIMINAR";
            this.tsbMyE.Click += new System.EventHandler(this.tsbMyE_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::pryAgendaDeContactos.Properties.Resources.search_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(75, 44);
            this.tsbBuscar.Text = "BUSCAR";
            // 
            // tsbCategorias
            // 
            this.tsbCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoríasToolStripMenuItem});
            this.tsbCategorias.Image = global::pryAgendaDeContactos.Properties.Resources.category_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategorias.Name = "tsbCategorias";
            this.tsbCategorias.Size = new System.Drawing.Size(108, 44);
            this.tsbCategorias.Text = "CATEGORÍAS";
            // 
            // agregarCategoríasToolStripMenuItem
            // 
            this.agregarCategoríasToolStripMenuItem.Image = global::pryAgendaDeContactos.Properties.Resources.add_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.agregarCategoríasToolStripMenuItem.Name = "agregarCategoríasToolStripMenuItem";
            this.agregarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.agregarCategoríasToolStripMenuItem.Text = "Agregar categorías...";
            this.agregarCategoríasToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoríasToolStripMenuItem_Click);
            // 
            // tsdbExportar
            // 
            this.tsdbExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarACSVToolStripMenuItem,
            this.exportarATXTToolStripMenuItem,
            this.toolStripMenuItem1});
            this.tsdbExportar.Image = global::pryAgendaDeContactos.Properties.Resources.export_notes_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsdbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbExportar.Name = "tsdbExportar";
            this.tsdbExportar.Size = new System.Drawing.Size(95, 44);
            this.tsdbExportar.Text = "EXPORTAR";
            // 
            // exportarACSVToolStripMenuItem
            // 
            this.exportarACSVToolStripMenuItem.Name = "exportarACSVToolStripMenuItem";
            this.exportarACSVToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exportarACSVToolStripMenuItem.Text = "Exportar a CSV";
            // 
            // exportarATXTToolStripMenuItem
            // 
            this.exportarATXTToolStripMenuItem.Name = "exportarATXTToolStripMenuItem";
            this.exportarATXTToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exportarATXTToolStripMenuItem.Text = "Exportar a TXT";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "Exportar a vCard";
            // 
            // pbContacto
            // 
            this.pbContacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbContacto.Image = global::pryAgendaDeContactos.Properties.Resources.contacts_product_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.pbContacto.Location = new System.Drawing.Point(26, 26);
            this.pbContacto.Name = "pbContacto";
            this.pbContacto.Size = new System.Drawing.Size(96, 103);
            this.pbContacto.TabIndex = 0;
            this.pbContacto.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 474);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(211, 30);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "REFRESCAR ";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 509);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.scContactos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.scContactos.Panel1.ResumeLayout(false);
            this.scContactos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContactos)).EndInit();
            this.scContactos.ResumeLayout(false);
            this.gbDatosContacto.ResumeLayout(false);
            this.gbDatosContacto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbMyE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton tsbCategorias;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton tsdbExportar;
        private System.Windows.Forms.ToolStripMenuItem exportarACSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarATXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SplitContainer scContactos;
        private System.Windows.Forms.TreeView tvContactos;
        private System.Windows.Forms.GroupBox gbDatosContacto;
        private System.Windows.Forms.Label lblRelacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbContacto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrescar;
    }
}