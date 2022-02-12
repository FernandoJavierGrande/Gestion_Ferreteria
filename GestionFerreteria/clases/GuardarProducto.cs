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

        public bool guardarNuevoProducto(Producto producto)
        {

            try
            {
                conexion.Open();

                string insert = "INSERT INTO Productos ([codigo],[codigobarras],[nombre],[marca],[descripcion],[categoria],[medida],[preciolista],[descuentolista],[preciobruto],[porcentaje],[preciofinal],[proveedor]) VALUES (@codigo,@barras,@nombre,@marca,@descripcion,@categoria,@medida,@precioProv,@descProv,@costo,@porc,@precioFinal,@proveedor)";

                SqlCommand cmd = new SqlCommand(insert, conexion);

           

                cmd.Parameters.AddWithValue("@codigo", producto.codigo);
                cmd.Parameters.AddWithValue("@barras", producto.codigo_barras);
                cmd.Parameters.AddWithValue("@nombre",producto.nombre);
                cmd.Parameters.AddWithValue("@marca",producto.marca);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@categoria", producto.categoria);
                cmd.Parameters.AddWithValue("@medida", producto.medida);
                cmd.Parameters.AddWithValue("@precioProv", producto.precio_lista);
                cmd.Parameters.AddWithValue("@descProv", producto.descuento_lista);
                cmd.Parameters.AddWithValue("@costo", producto.costo);
                cmd.Parameters.AddWithValue("@porc", producto.porcentaje);
                cmd.Parameters.AddWithValue("@precioFinal", producto.precio);
                cmd.Parameters.AddWithValue("@proveedor", producto.proveedor);

                

                cmd.ExecuteNonQuery();



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

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }

            return true;
        }


    }



}
