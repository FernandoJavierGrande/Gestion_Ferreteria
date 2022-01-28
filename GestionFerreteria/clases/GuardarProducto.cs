using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionFerreteria.clases
{
    internal class GuardarProducto
    {
        static string cnString = "server = localhost ; database = ferreteria ; integrated security = true ";

        SqlConnection conexion = new SqlConnection(cnString);
        Producto producto = new Producto();
        public GuardarProducto()
        {
            conexion.Open();
        }

        public bool guardarNuevoProducto(string query)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("carga correcta");
                

                conexion.Close();
                return true;
        }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar el producto. Intente nuevamente");
                return false;
            }

}


    }



}
