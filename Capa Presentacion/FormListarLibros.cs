using CapaLibros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuscarClick(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
