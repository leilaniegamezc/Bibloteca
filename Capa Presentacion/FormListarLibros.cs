using CapaLibros;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormListarLibros : Form
    {
        public FormListarLibros()
        {
            InitializeComponent();
        }

        private void FormListarLibros_Load(object sender, EventArgs e)
        {
            Top = Left = 0;
            Mostrar();
        }
        /// <summary>
        /// Metodo para mostrar los registros en el <see cref="DataGridView"/>
        /// </summary>
        public void Mostrar() => dlistado.DataSource = CLLibro.Listar();

        /// <summary>
        /// Metodo para buscar clientes por nombre
        /// </summary>
        public void BuscarNombre() => dlistado.DataSource = CLLibro.BuscarNombre(NombreTXT.Text);

        
        private void BuscarClick(object sender, EventArgs e)
        {
            if (NombreRBTN.Checked) BuscarNombre();
            else MessageBox.Show(
                "Seleccione un criterio de busqueda.",
                "Sistema de Ventas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        #region ???
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void NuevoBTN_Click(object sender, EventArgs e)
        {
            new FormRegistrarLibro() { Insert = true, Edit = false }.Show();
            Hide();
        }

        private void EditarBTN_Click(object sender, EventArgs e)
        {
            FormRegistrarLibro form = new FormRegistrarLibro() { Insert = false, Edit = true };
            form.NombreTXT.Text = dlistado.CurrentRow.Cells["Nombre_libro"].Value.ToString();
            form.AutorTXT.Text = dlistado.CurrentRow.Cells["idEditor"].Value.ToString();
            form.IDLibroTXT.Text = dlistado.CurrentRow.Cells["idLibro"].Value.ToString();

            string estado;
            try { estado = dlistado.CurrentRow.Cells["estado"].Value.ToString(); }
            catch { estado = "INACTIVO"; }

            if (estado.ToUpper().Equals("ACTIVO")) form.ActivoRBTN.Checked = true;
            else form.InactivoRBTN.Checked = true;

            form.Show();
            Hide();
        }
    }
}
