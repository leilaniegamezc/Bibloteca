using System.Data;

using CapaDatos;

namespace CapaLibros
{
    public class CLLibro
    {
        public static DataTable Listar() => new CDLibros().Listar();

        /// <summary>
        /// Metodo Guardar que llama al metodo Guardar de la clase CDLibros de la CapaDatos
        /// </summary>
        /// <returns></returns>
        public static string Guardar(string nombre, string editor)
        {
            CDLibros datos = new CDLibros()
            {
                Nombre = nombre,
                IdEditor = editor,
            };

            return datos.Guardar(datos);
        }


        /// <summary>
        /// Metodo Guardar que llama al metodo Guardar de la clase CDLibros de la CapaDatos
        /// </summary>
        public static string Guardar(CDLibros libro) => libro.Guardar(libro);

        public static string Editar(int idCliente, string nombre, string editor)
        {
            CDLibros datos = new CDLibros()
            {
                Idcliente = idCliente,
                Nombre = nombre,
                IdEditor = editor
            };

            return datos.Editar(datos);
        }

        public static string Eliminar(int idCliente)
        {
            CDLibros datos = new CDLibros()
            {
                Idcliente = idCliente
            };
            return datos.Eliminar(datos);
        }

        /// <summary>
        /// Metodo BuscarNombre que llama al metodo <see cref="CDCliente.BuscarNombre(CDCliente)"/> de la <see cref="CapaDatos"/>
        /// </summary>
        /// <param name="textoBuscar"></param>
        /// <returns></returns>
        public static DataTable BuscarNombre(string textoBuscar)
        {
            CDLibros datos = new CDLibros()
            {
                Buscar = textoBuscar
            };
            return datos.BuscarNombre(datos);
        }

    }
}
