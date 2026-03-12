using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLibros
{
    public partial class FormRegistrarLibro : Form
    {
        public bool Insert = false, Edit = false;
        public FormRegistrarLibro() => InitializeComponent();

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            new FormListarLibros().Show();
            Hide();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            string estado = ActivoRBTN.Checked ? "ACTIVO" : "INACTIVO";

            try
            {
                if (string.IsNullOrEmpty(NombreTXT.Text) || string.IsNullOrEmpty(AutorTXT.Text)) MessageBox.Show("Ingrese los datos del cliente",
                        "Sistema de Ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                else
                {
                    if (Insert)
                    {
                        CLLibro.Guardar(NombreTXT.Text, AutorTXT.Text);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Edit)
                    {
                        CLLibro.Editar(Convert.ToInt32(IDLibroTXT.Text), NombreTXT.Text, AutorTXT.Text);
                        MessageBox.Show("Cliente editado correctamente", "Sistema de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Insert = Edit = false;

                    new FormListarLibros().Show();
                    Hide();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}; \n\tStack: {ex.StackTrace}"); }

        }

        private void FormRegistrarLibro_Load(object sender, EventArgs e) => Top = Left = 0;
    }
}
