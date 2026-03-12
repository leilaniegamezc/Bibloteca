namespace CapaPresentacion
{
    partial class FormListarLibros
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
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreRBTN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NuevoBTN = new System.Windows.Forms.Button();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.Location = new System.Drawing.Point(598, 37);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(75, 23);
            this.BuscarBTN.TabIndex = 5;
            this.BuscarBTN.Text = "Buscar";
            this.BuscarBTN.UseVisualStyleBackColor = true;
            this.BuscarBTN.Click += new System.EventHandler(this.BuscarClick);
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(679, 37);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelarBTN.TabIndex = 6;
            this.CancelarBTN.Text = "Cancelar";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(133, 40);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(459, 20);
            this.NombreTXT.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.CancelarBTN);
            this.panel1.Controls.Add(this.BuscarBTN);
            this.panel1.Controls.Add(this.NombreTXT);
            this.panel1.Location = new System.Drawing.Point(24, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 87);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreRBTN);
            this.groupBox1.Location = new System.Drawing.Point(3, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 41);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio de Busqueda";
            // 
            // NombreRBTN
            // 
            this.NombreRBTN.AutoSize = true;
            this.NombreRBTN.Location = new System.Drawing.Point(6, 19);
            this.NombreRBTN.Name = "NombreRBTN";
            this.NombreRBTN.Size = new System.Drawing.Size(62, 17);
            this.NombreRBTN.TabIndex = 8;
            this.NombreRBTN.TabStop = true;
            this.NombreRBTN.Text = "Nombre";
            this.NombreRBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incio Bibloteca";
            // 
            // dlistado
            // 
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Location = new System.Drawing.Point(24, 147);
            this.dlistado.Name = "dlistado";
            this.dlistado.Size = new System.Drawing.Size(764, 190);
            this.dlistado.TabIndex = 0;
            // 
            // NuevoBTN
            // 
            this.NuevoBTN.Location = new System.Drawing.Point(632, 343);
            this.NuevoBTN.Name = "NuevoBTN";
            this.NuevoBTN.Size = new System.Drawing.Size(75, 23);
            this.NuevoBTN.TabIndex = 8;
            this.NuevoBTN.Text = "&Nuevo";
            this.NuevoBTN.UseVisualStyleBackColor = true;
            this.NuevoBTN.Click += new System.EventHandler(this.NuevoBTN_Click);
            // 
            // EditarBTN
            // 
            this.EditarBTN.Location = new System.Drawing.Point(713, 343);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(75, 23);
            this.EditarBTN.TabIndex = 9;
            this.EditarBTN.Text = "&Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // FormListarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.NuevoBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.label1);
            this.Name = "FormListarLibros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormListarLibros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.RadioButton NombreRBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NuevoBTN;
        private System.Windows.Forms.Button EditarBTN;
    }
}

