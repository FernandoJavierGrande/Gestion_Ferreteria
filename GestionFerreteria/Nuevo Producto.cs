using GestionFerreteria.clases;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace GestionFerreteria
{
    public partial class agregarNuevoProducto : Form
    {
        static string cnString = "server = localhost ; database = ferreteria ; integrated security = true ";
        SqlConnection conexion;


        Color colorOk = Color.PaleGreen;
        Color colorCancel = Color.IndianRed;

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
                txt_codigo.BackColor = colorCancel;
                MessageBox.Show("Debe tener 4 o mas caracteres");
            }
  

        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_nombre);
            
        }

        private void txt_marca_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_marca);

        }

        private void txt_precioProv_Leave(object sender, EventArgs e)
        {
            //ColorCampos(txt_precioProveedor);
        }

        private void txt_descProv_Leave(object sender, EventArgs e)
        {

            //ColorCampos(txt_descProv);
            
        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_costo); 

        }

        private void txt_porc_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_porc);

        }

        private void txt_preciof_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_preciof);

        }
        public bool ValidarCampos()
        {
            TextBox[] arrayTxt = { txt_codigo, txt_nombre, txt_marca, txt_costo, txt_porc, txt_preciof };

            foreach (var item in arrayTxt)
            {
                ColorCampos(item);
            }
            if (cmb_cat.SelectedIndex==-1)
            {
                
                cmb_cat.SelectedIndex = 12;
            }
            bool validar;
            if (txt_codigo.BackColor == colorCancel || txt_nombre.BackColor == colorCancel || txt_precioProveedor.BackColor == colorCancel || txt_descProv.BackColor == colorCancel || txt_costo.BackColor == colorCancel || txt_porc.BackColor == colorCancel
                 || txt_marca.BackColor == colorCancel || txt_preciof.BackColor == colorCancel)
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
            
            if (txtAEvaluar.Equals(txt_codigo))
            {
                if (txtAEvaluar.Text.Equals("") || txt_codigo.Text.Trim().Length==0)
                {

                    txtAEvaluar.BackColor = colorCancel;
                }
                else
                {
                    txtAEvaluar.BackColor = colorOk;
                }
            }
            else if (txtAEvaluar.Equals(txt_costo))
            {
                try
                {
                    double aux = double.Parse(txtAEvaluar.Text.Trim());
                    txtAEvaluar.BackColor = colorOk;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = colorCancel;

                }
            }
            else if(txtAEvaluar.Equals(txt_porc))
            {
                try
                {
                    double aux = double.Parse(txtAEvaluar.Text.Trim());
                    txtAEvaluar.BackColor = colorOk;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = colorCancel;

                }
            }
            else if (txtAEvaluar.Equals(txt_preciof))
            {
                try
                {
                    double aux = double.Parse(txtAEvaluar.Text.Trim());
                    txtAEvaluar.BackColor = colorOk;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = colorCancel;

                }
            }
            else
            {
                if (txtAEvaluar.Text.Equals(""))
                {

                    txtAEvaluar.BackColor = colorCancel;
                }
                else
                {
                    txtAEvaluar.BackColor = colorOk;
                }
            }

            
        }

        private void txt_precioProveedor_TextChanged(object sender, EventArgs e)
        {
            if (!txt_precioProveedor.Text.Trim().Equals(""))
            {
                try
                {
                    double aux;
                    aux = double.Parse(txt_precioProveedor.Text.Trim());
                    txt_precioProveedor.BackColor = colorOk;
                }
                catch (Exception)
                {
                    txt_precioProveedor.BackColor= colorCancel;
                    
                }
            }
            else
            {
                txt_precioProveedor.BackColor =colorCancel;
            }
        }

        private void txt_descProv_TextChanged(object sender, EventArgs e)
        {
            if (!txt_descProv.Text.Trim().Equals(""))
            {
                try
                {
                    double aux;
                    aux = double.Parse(txt_descProv.Text.Trim());
                    txt_descProv.BackColor = colorOk;
                }
                catch (Exception)
                {
                    txt_descProv.BackColor = colorCancel;

                }
                
            }
            else
            {
                txt_descProv.BackColor = colorCancel;
            }
        }
    }
}
