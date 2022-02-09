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
            
        }

        public bool guardarNuevoProducto(string query)
        {

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("carga correcta");


                conexion.Close();
                return true;
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar el producto. Intente nuevamente ");
                Console.WriteLine(E);
                conexion.Close();
                return false;
            }

        }
        public bool nuevoStock(string id, string stock, string stockMin)
        {
            try
            {
                conexion.Open();
                string query = "INSERT INTO stock VALUES (@id, @stock, @stockMin)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@stock",stock);
                cmd.Parameters.AddWithValue("@stockMin", stockMin);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("se cargo stock");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }

            return true;
        }


    }



}
