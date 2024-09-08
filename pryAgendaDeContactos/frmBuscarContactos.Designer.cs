namespace pryAgendaDeContactos
{
    partial class frmBuscarContactos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCorreo = new System.Windows.Forms.GroupBox();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.btnNombre = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTelefono = new System.Windows.Forms.GroupBox();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optCorreo = new System.Windows.Forms.RadioButton();
            this.optTelefono = new System.Windows.Forms.RadioButton();
            this.optNombre = new System.Windows.Forms.RadioButton();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbCorreo.SuspendLayout();
            this.gbNombre.SuspendLayout();
            this.gbTelefono.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Bisque;
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpiar);
            this.splitContainer1.Panel1.Controls.Add(this.btnListar);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Bisque;
            this.splitContainer1.Panel2.Controls.Add(this.dgvContactos);
            this.splitContainer1.Size = new System.Drawing.Size(630, 504);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(105, 451);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 45);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListar.Location = new System.Drawing.Point(4, 451);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(95, 45);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryAgendaDeContactos.Properties.Resources.search_24dp_5F6368_FILL0_wght400_GRAD0_opsz241;
            this.pictureBox1.Location = new System.Drawing.Point(110, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 94);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbCorreo);
            this.panel1.Controls.Add(this.gbNombre);
            this.panel1.Controls.Add(this.gbTelefono);
            this.panel1.Location = new System.Drawing.Point(4, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 328);
            this.panel1.TabIndex = 1;
            // 
            // gbCorreo
            // 
            this.gbCorreo.Controls.Add(this.btnCorreo);
            this.gbCorreo.Controls.Add(this.txtCorreo);
            this.gbCorreo.Controls.Add(this.label3);
            this.gbCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCorreo.Location = new System.Drawing.Point(5, 220);
            this.gbCorreo.Name = "gbCorreo";
            this.gbCorreo.Size = new System.Drawing.Size(186, 102);
            this.gbCorreo.TabIndex = 2;
            this.gbCorreo.TabStop = false;
            this.gbCorreo.Text = "Búsqueda por Correo";
            // 
            // btnCorreo
            // 
            this.btnCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCorreo.Location = new System.Drawing.Point(13, 67);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(159, 23);
            this.btnCorreo.TabIndex = 6;
            this.btnCorreo.Text = "Buscar";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(13, 41);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(159, 25);
            this.txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // gbNombre
            // 
            this.gbNombre.Controls.Add(this.btnNombre);
            this.gbNombre.Controls.Add(this.txtNombre);
            this.gbNombre.Controls.Add(this.label2);
            this.gbNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNombre.Location = new System.Drawing.Point(5, 4);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(186, 102);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Búsqueda por Nombre";
            // 
            // btnNombre
            // 
            this.btnNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNombre.Location = new System.Drawing.Point(13, 67);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(159, 23);
            this.btnNombre.TabIndex = 6;
            this.btnNombre.Text = "Buscar";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(13, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 25);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // gbTelefono
            // 
            this.gbTelefono.Controls.Add(this.btnTelefono);
            this.gbTelefono.Controls.Add(this.txtTelefono);
            this.gbTelefono.Controls.Add(this.label1);
            this.gbTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelefono.Location = new System.Drawing.Point(5, 112);
            this.gbTelefono.Name = "gbTelefono";
            this.gbTelefono.Size = new System.Drawing.Size(186, 102);
            this.gbTelefono.TabIndex = 1;
            this.gbTelefono.TabStop = false;
            this.gbTelefono.Text = "Búsqueda por Teléfono";
            // 
            // btnTelefono
            // 
            this.btnTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTelefono.Location = new System.Drawing.Point(13, 67);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(159, 23);
            this.btnTelefono.TabIndex = 6;
            this.btnTelefono.Text = "Buscar";
            this.btnTelefono.UseVisualStyleBackColor = true;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(13, 41);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(159, 25);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teléfono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optCorreo);
            this.groupBox1.Controls.Add(this.optTelefono);
            this.groupBox1.Controls.Add(this.optNombre);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRAR POR";
            // 
            // optCorreo
            // 
            this.optCorreo.AutoSize = true;
            this.optCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCorreo.Location = new System.Drawing.Point(6, 78);
            this.optCorreo.Name = "optCorreo";
            this.optCorreo.Size = new System.Drawing.Size(67, 21);
            this.optCorreo.TabIndex = 2;
            this.optCorreo.TabStop = true;
            this.optCorreo.Text = "Correo";
            this.optCorreo.UseVisualStyleBackColor = true;
            this.optCorreo.CheckedChanged += new System.EventHandler(this.optCorreo_CheckedChanged);
            // 
            // optTelefono
            // 
            this.optTelefono.AutoSize = true;
            this.optTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTelefono.Location = new System.Drawing.Point(6, 51);
            this.optTelefono.Name = "optTelefono";
            this.optTelefono.Size = new System.Drawing.Size(77, 21);
            this.optTelefono.TabIndex = 1;
            this.optTelefono.TabStop = true;
            this.optTelefono.Text = "Teléfono";
            this.optTelefono.UseVisualStyleBackColor = true;
            this.optTelefono.CheckedChanged += new System.EventHandler(this.optTelefono_CheckedChanged);
            // 
            // optNombre
            // 
            this.optNombre.AutoSize = true;
            this.optNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNombre.Location = new System.Drawing.Point(6, 24);
            this.optNombre.Name = "optNombre";
            this.optNombre.Size = new System.Drawing.Size(76, 21);
            this.optNombre.TabIndex = 0;
            this.optNombre.TabStop = true;
            this.optNombre.Text = "Nombre";
            this.optNombre.UseVisualStyleBackColor = true;
            this.optNombre.CheckedChanged += new System.EventHandler(this.optNombre_CheckedChanged);
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactos.Location = new System.Drawing.Point(0, 0);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(415, 500);
            this.dgvContactos.TabIndex = 0;
            // 
            // frmBuscarContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 523);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Contactos";
            this.Load += new System.EventHandler(this.frmBuscarContactos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbCorreo.ResumeLayout(false);
            this.gbCorreo.PerformLayout();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbTelefono.ResumeLayout(false);
            this.gbTelefono.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optCorreo;
        private System.Windows.Forms.RadioButton optTelefono;
        private System.Windows.Forms.RadioButton optNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCorreo;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbTelefono;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListar;
    }
}