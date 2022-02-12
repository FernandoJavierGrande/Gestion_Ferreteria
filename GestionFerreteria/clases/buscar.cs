using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionFerreteria.clases
{
    internal class buscar
    {
        static string cnString = "server = localhost ; database = ferreteria ; integrated security = true ";

        SqlConnection conexion = new SqlConnection(cnString);

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public DataTable buscarCodigoBarra(string str)
        {
          
            conexion.Open();
            string query = "SELECT [codigo],[preciofinal],[nombre],[marca],[categoria],[medida],[id],[descripcion] FROM Productos WHERE codigobarras = '" + str +"'";

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            using (data)
            {
                data.Fill(dt);
            }

            conexion.Close();
            return dt;
        }
        public DataTable buscarGeneral(string str)
        {

            conexion.Open();
            string query = "SELECT [codigo],[preciofinal],[nombre],[marca],[categoria],[medida],[id],[descripcion] FROM Productos WHERE nombre LIKE '%"+ str + "%' or codigo LIKE '%" + str + "%' or marca LIKE '%" + str + "%'";


            SqlCommand cmd = new SqlCommand(query, conexion);
            //cmd.Parameters.AddWithValue("@buscar",str);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            using (dataAdapter)
            {
                dataAdapter.Fill(dt2);
            }

            conexion.Close();

            return dt2;

        }
    }
}




//if (data != null)
//{



//salidaProd.Id = int.Parse(dr["id"].ToString());
//salidaProd.codigo_barras = dr["codigobarras"].ToString();
//salidaProd.nombre = dr["nombre"].ToString();
//salidaProd.marca = dr["marca"].ToString();
//salidaProd.descripcion = dr["descripcion"].ToString();
//salidaProd.categoria = dr["categoria"].ToString();
//salidaProd.medida = dr["medida"].ToString();
//salidaProd.precio_lista = double.Parse(dr["preciolista"].ToString());
//salidaProd.descuento_lista = double.Parse(dr["descuentolista"].ToString());
//salidaProd.costo = double.Parse(dr["preciobruto"].ToString());
//salidaProd.porcentaje = double.Parse(dr["porcentaje"].ToString());
//salidaProd.precio = double.Parse(dr["preciofinal"].ToString());
//salidaProd.proveedor = dr["proveedor"].ToString();


//}
