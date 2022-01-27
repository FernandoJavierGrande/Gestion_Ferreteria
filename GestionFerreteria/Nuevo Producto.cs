using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionFerreteria.clases;
using System.Data.SqlClient;

namespace GestionFerreteria
{
    public partial class agregarNuevoProducto : Form
    {
        static string cnString = "server = localhost ; database = ferreteria ; integrated security = true ";
        SqlConnection conexion;
        

        public agregarNuevoProducto()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validarCampos;
            validarCampos = ValidarCampos();
            if (validarCampos == true)
            {
                MessageBox.Show("bandera = " + validarCampos);

                GuardarProducto guardar = new GuardarProducto();

                string insert = "insert into Productos ([codigo],[nombre],[marca],[descripcion],[categoria],[preciolista],[descuentolista], [preciobruto],[porcentaje],[preciofinal]) values ('" + txt_codigo.Text + "','" + txt_nombre.Text + "','" + txt_marca.Text + "','" + txt_desc.Text + "','" + cmb_cat.SelectedIndex.ToString() + "','" + double.Parse(txt_precioProveedor.Text) + "','" + double.Parse(txt_descProv.Text) + "','" + double.Parse(txt_costo.Text) + "','" + double.Parse(txt_porc.Text) + "','" + double.Parse(txt_preciof.Text) + "')";


                bool res = guardar.guardarNuevoProducto(insert);

            }
            else
            {
                MessageBox.Show("bandera = " + validarCampos);
                
            }
        
            
        }
        public SqlConnection conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cnString);
                return conexion;
            }
            catch (Exception EX)
            {
                Console.WriteLine("ERROR EN LA CONEXION A BBDD. " + EX );
                return null; 
            }
            


        }
        private void agregarNuevoProducto_Load(object sender, EventArgs e)
        {
            conexion = conectar();
            if (conexion != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT categoria FROM categorias", conexion);
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb_cat.Items.Add(dr["categoria"].ToString());
                    }
                    conexion.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al cargar las categorias, cierre la ventana e intente nuevamente");
                    Console.WriteLine(ex);
                }
                
            }
            else
            {
                MessageBox.Show("Error al cargar las categorias, cierre la ventana e intente nuevamente");
            }
            conexion = conectar();
            SqlCommand comando = new SqlCommand("SELECT MAX(id) FROM Productos", conexion);
            conexion.Open();
            SqlDataReader data = comando.ExecuteReader();
            if (data.Read())
            {
                int id_aux = Convert.ToInt32(data[0]) + 1;
                label_nuevoId.Text = id_aux.ToString();
            }
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {




            if (txt_codigo.Text.Trim().Length >= 4)
            {
                ColorCampos(txt_codigo);

            }
            else
            {
                txt_codigo.BackColor = Color.Red;
                MessageBox.Show("Debe tener 4 o mas caracteres");
            }

            

        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_nombre);


            //if (txt_nombre.Text.Equals(""))
            //{
            //    txt_nombre.BackColor = Color.Red;

            //}
            //else
            //{
            //    txt_nombre.BackColor = Color.LightGreen;

            //}
            ;
        }

        private void txt_marca_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_marca);



            //if (txt_marca.Text.Equals(""))
            //{
            //    txt_marca.BackColor = Color.Red;

            //}
            //else
            //{
            //    txt_marca.BackColor = Color.LightGreen;

            //}

        }

        private void txt_precioProv_Leave(object sender, EventArgs e)
        {

            //ColorCampos(txt_precioProveedor);


            //if (txt_precioProveedor.Text.Equals(""))
            //{
            //    txt_precioProveedor.BackColor = Color.Red;
            //    //bandera_validacion +=1;

            //}
            //else
            //{
            //    txt_precioProveedor.BackColor = Color.LightGreen;
            //    //bandera_validacion = true;
            //}
        }

        private void txt_descProv_Leave(object sender, EventArgs e)
        {

            //ColorCampos(txt_descProv);

            //if (txt_descProv.Text.Equals(""))
            //{
            //    txt_descProv.BackColor = Color.Red;
            //    //bandera_validacion ;

            //}
            //else
            //{
            //    txt_descProv.BackColor = Color.LightGreen;
            //    //bandera_validacion = true;
            //}
        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_costo); 

            //if (txt_costo.Text.Equals(""))
            //{
            //    txt_costo.BackColor = Color.Red;
                
            //}
            //else
            //{
            //    txt_costo.BackColor = Color.LightGreen;

            //}

        }

        private void txt_porc_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_porc);

            //if (txt_porc.Text.Equals(""))
            //{
            //    txt_porc.BackColor = Color.Red;
            //}
            //else
            //{
            //    txt_porc.BackColor = Color.LightGreen;

            //}

        }

        private void txt_preciof_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_preciof);

            //if (txt_preciof.Text.Equals(""))
            //{
            //    txt_preciof.BackColor = Color.Red;

            //}
            //else
            //{
            //    txt_preciof.BackColor = Color.LightGreen;

            //}

        }
        public bool ValidarCampos()
        {
            TextBox[] arrayTxt = { txt_codigo, txt_nombre, txt_marca, txt_costo, txt_porc, txt_preciof };

            foreach (var item in arrayTxt)
            {
                ColorCampos(item);
            }

            bool validar;
            if (txt_codigo.BackColor == Color.Red || txt_nombre.BackColor == Color.Red || txt_costo.BackColor == Color.Red || txt_porc.BackColor == Color.Red
                 || txt_marca.BackColor == Color.Red || txt_preciof.BackColor == Color.Red)
            {
                validar = false;
            }
            else
            {
                validar = true;
            }
            return validar;
        }
        public void ColorCampos(TextBox txtAEvaluar)
        {
            TextBox txtCampo = new TextBox();
            if (txtAEvaluar.Equals(txt_codigo))
            {
                if (txtAEvaluar.Text.Equals("") || txt_codigo.Text.Trim().Length==0)
                {

                    txtAEvaluar.BackColor = Color.Red;
                }
                else
                {
                    
                    txtAEvaluar.BackColor = Color.LightGreen;
                }
            }
            else if (txtAEvaluar.Equals(txt_costo))
            {
                try
                {
                    double aux = double.Parse(txt_costo.Text.Trim());
                    txtAEvaluar.BackColor = Color.LightGreen;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = Color.Red;

                }
            }
            else
            {
                if (txtAEvaluar.Text.Equals(""))
                {

                    txtAEvaluar.BackColor = Color.Red;
                }
                else
                {
                    //MessageBox.Show("Texto = '" + txtAEvaluar.Text + "'");
                    txtAEvaluar.BackColor = Color.LightGreen;
                }
            }
            

            
            
        }
    }
}
