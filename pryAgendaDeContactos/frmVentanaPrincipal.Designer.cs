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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo1");
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.scContactos = new System.Windows.Forms.SplitContainer();
            this.tvContactos = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContactos)).BeginInit();
            this.scContactos.Panel1.SuspendLayout();
            this.scContactos.Panel2.SuspendLayout();
            this.scContactos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolStrip2.Size = new System.Drawing.Size(757, 44);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 44);
            // 
            // scContactos
            // 
            this.scContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scContactos.Location = new System.Drawing.Point(12, 129);
            this.scContactos.Name = "scContactos";
            // 
            // scContactos.Panel1
            // 
            this.scContactos.Panel1.Controls.Add(this.tvContactos);
            // 
            // scContactos.Panel2
            // 
            this.scContactos.Panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.scContactos.Panel2.Controls.Add(this.groupBox1);
            this.scContactos.Size = new System.Drawing.Size(727, 344);
            this.scContactos.SplitterDistance = 241;
            this.scContactos.TabIndex = 11;
            // 
            // tvContactos
            // 
            this.tvContactos.BackColor = System.Drawing.Color.OldLace;
            this.tvContactos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvContactos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvContactos.HideSelection = false;
            this.tvContactos.HotTracking = true;
            this.tvContactos.Location = new System.Drawing.Point(5, 3);
            this.tvContactos.Name = "tvContactos";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Nodo0";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Nodo1";
            this.tvContactos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tvContactos.ShowNodeToolTips = true;
            this.tvContactos.Size = new System.Drawing.Size(226, 334);
            this.tvContactos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CONTACTO";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.PeachPuff;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(82, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PeachPuff;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(82, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PeachPuff;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(82, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(219, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(219, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 50);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
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
            this.tsbAgregar.Size = new System.Drawing.Size(83, 41);
            this.tsbAgregar.Text = "AGREGAR";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbMyE
            // 
            this.tsbMyE.Image = global::pryAgendaDeContactos.Properties.Resources.settings_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbMyE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMyE.Name = "tsbMyE";
            this.tsbMyE.Size = new System.Drawing.Size(152, 41);
            this.tsbMyE.Text = "MODIFICAR/ELIMINAR";
            this.tsbMyE.Click += new System.EventHandler(this.tsbMyE_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::pryAgendaDeContactos.Properties.Resources.search_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(75, 41);
            this.tsbBuscar.Text = "BUSCAR";
            // 
            // tsbCategorias
            // 
            this.tsbCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoríasToolStripMenuItem});
            this.tsbCategorias.Image = global::pryAgendaDeContactos.Properties.Resources.category_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategorias.Name = "tsbCategorias";
            this.tsbCategorias.Size = new System.Drawing.Size(108, 41);
            this.tsbCategorias.Text = "CATEGORÍAS";
            // 
            // agregarCategoríasToolStripMenuItem
            // 
            this.agregarCategoríasToolStripMenuItem.Name = "agregarCategoríasToolStripMenuItem";
            this.agregarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            this.tsdbExportar.Size = new System.Drawing.Size(95, 41);
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 481);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.scContactos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}