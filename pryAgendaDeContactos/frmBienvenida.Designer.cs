namespace pryAgendaDeContactos
{
    partial class frmBienvenida
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.OldLace;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(338, 104);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(106, 49);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(286, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda de Contactos Personalizada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Bisque;
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Image = global::pryAgendaDeContactos.Properties.Resources.auto_stories_50dp_5F6368_FILL0_wght400_GRAD0_opsz48;
            this.pbLogo.Location = new System.Drawing.Point(49, 25);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(204, 190);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.OldLace;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(338, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 49);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSalir;
    }
}

