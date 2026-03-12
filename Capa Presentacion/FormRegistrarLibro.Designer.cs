namespace CapaLibros
{
    partial class FormRegistrarLibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.AutorLBL = new System.Windows.Forms.Label();
            this.AutorTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.ActivoRBTN = new System.Windows.Forms.RadioButton();
            this.InactivoRBTN = new System.Windows.Forms.RadioButton();
            this.EstadoLBL = new System.Windows.Forms.Label();
            this.IDLibroTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // NombreLBL
            // 
            this.NombreLBL.AutoSize = true;
            this.NombreLBL.Location = new System.Drawing.Point(12, 56);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(44, 13);
            this.NombreLBL.TabIndex = 1;
            this.NombreLBL.Text = "Nombre";
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(12, 72);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(364, 20);
            this.NombreTXT.TabIndex = 2;
            // 
            // AutorLBL
            // 
            this.AutorLBL.AutoSize = true;
            this.AutorLBL.Location = new System.Drawing.Point(14, 106);
            this.AutorLBL.Name = "AutorLBL";
            this.AutorLBL.Size = new System.Drawing.Size(32, 13);
            this.AutorLBL.TabIndex = 3;
            this.AutorLBL.Text = "Autor";
            // 
            // AutorTXT
            // 
            this.AutorTXT.Location = new System.Drawing.Point(12, 122);
            this.AutorTXT.Name = "AutorTXT";
            this.AutorTXT.Size = new System.Drawing.Size(364, 20);
            this.AutorTXT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(12, 202);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 7;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(93, 202);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelarBTN.TabIndex = 8;
            this.CancelarBTN.Text = "&Cancelar";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // ActivoRBTN
            // 
            this.ActivoRBTN.AutoSize = true;
            this.ActivoRBTN.Location = new System.Drawing.Point(12, 179);
            this.ActivoRBTN.Name = "ActivoRBTN";
            this.ActivoRBTN.Size = new System.Drawing.Size(55, 17);
            this.ActivoRBTN.TabIndex = 9;
            this.ActivoRBTN.TabStop = true;
            this.ActivoRBTN.Text = "Activo";
            this.ActivoRBTN.UseVisualStyleBackColor = true;
            // 
            // InactivoRBTN
            // 
            this.InactivoRBTN.AutoSize = true;
            this.InactivoRBTN.Location = new System.Drawing.Point(73, 179);
            this.InactivoRBTN.Name = "InactivoRBTN";
            this.InactivoRBTN.Size = new System.Drawing.Size(63, 17);
            this.InactivoRBTN.TabIndex = 10;
            this.InactivoRBTN.TabStop = true;
            this.InactivoRBTN.Text = "Inactivo";
            this.InactivoRBTN.UseVisualStyleBackColor = true;
            // 
            // EstadoLBL
            // 
            this.EstadoLBL.AutoSize = true;
            this.EstadoLBL.Location = new System.Drawing.Point(12, 154);
            this.EstadoLBL.Name = "EstadoLBL";
            this.EstadoLBL.Size = new System.Drawing.Size(110, 13);
            this.EstadoLBL.TabIndex = 11;
            this.EstadoLBL.Text = "Seleccione un estado";
            // 
            // IDLibroTXT
            // 
            this.IDLibroTXT.Location = new System.Drawing.Point(208, 12);
            this.IDLibroTXT.Name = "IDLibroTXT";
            this.IDLibroTXT.Size = new System.Drawing.Size(100, 20);
            this.IDLibroTXT.TabIndex = 12;
            this.IDLibroTXT.Visible = false;
            // 
            // FormRegistrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDLibroTXT);
            this.Controls.Add(this.EstadoLBL);
            this.Controls.Add(this.InactivoRBTN);
            this.Controls.Add(this.ActivoRBTN);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AutorTXT);
            this.Controls.Add(this.AutorLBL);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.NombreLBL);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarLibro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRegistrarLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label AutorLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.Label EstadoLBL;
        public System.Windows.Forms.TextBox NombreTXT;
        public System.Windows.Forms.TextBox AutorTXT;
        public System.Windows.Forms.RadioButton ActivoRBTN;
        public System.Windows.Forms.RadioButton InactivoRBTN;
        public System.Windows.Forms.TextBox IDLibroTXT;
    }
}

