using GestionFerreteria.clases;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;


// sacar los metodos que calculan en otra clase,

// sacar los metodos que validan en otra clase


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

            }
  

        }
        private void txt_precioProveedor_TextChanged(object sender, EventArgs e)
        {
            validarCamposNumericos(txt_precioProveedor);
        }

        private void txt_descProv_TextChanged(object sender, EventArgs e)
        {
            validarCamposNumericos(txt_descProv);
        }
        private void txt_StockMin_TextChanged(object sender, EventArgs e)
        {
            validarCamposNumericos(txt_StockMin);
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_nombre);
        }

        private void txt_marca_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_marca);
        }
        private void txt_costo_Leave(object sender, EventArgs e)
        {
            ColorCampos(txt_costo);
            cambiarComaPorPuntoEnLaInterfaz(txt_costo);
        }
        private void txt_preciof_Leave(object sender, EventArgs e)
        {

            ColorCampos(txt_preciof);
            cambiarComaPorPuntoEnLaInterfaz(txt_preciof);
        }
        private void txt_precioProveedor_Leave(object sender, EventArgs e)
        {
            cambiarComaPorPuntoEnLaInterfaz(txt_precioProveedor);
        }

        private void txt_descProv_Leave(object sender, EventArgs e) //resta el porcentaje de descuento del precio de lista del proveedor
        {
            if (!txt_precioProveedor.Text.Trim().Equals("0") && !txt_descProv.Text.Trim().Equals("0"))
            {
                if (validarCamposNumericos(txt_descProv) && validarCamposNumericos(txt_precioProveedor))
                {


                    double costoParaRellenar, auxPrecio;
                    string descuento_temporal = txt_descProv.Text.Trim(), precioLista_temporal = txt_precioProveedor.Text.Trim();
                    double descuentoPrecioLista;
                    double precioDeLista;


                    if (precioLista_temporal.Contains("."))  // si encuentra un punto lo reemplaza por una coma
                    {
                        precioLista_temporal = precioLista_temporal.Replace(".", ",");
                    }
                    precioDeLista = double.Parse(precioLista_temporal);

                    if (descuento_temporal.Contains("."))      // si encuentra un punto lo reemplaza por una coma
                    {
                        descuento_temporal = descuento_temporal.Replace(".", ",");
                    }
                    descuentoPrecioLista = double.Parse(descuento_temporal);
                   
                    auxPrecio = precioDeLista * descuentoPrecioLista / 100;

                    costoParaRellenar = precioDeLista - auxPrecio;

                    txt_costo.Text = costoParaRellenar.ToString();

                    cambiarComaPorPuntoEnLaInterfaz(txt_descProv);
                }
            }

        }
        private void txt_porc_Leave(object sender, EventArgs e) // suma el porcentaje especificado
        {
            
            bool auxCalcular =  ColorCampos(txt_porc);
            if (auxCalcular)
            {
                double auxPrecio;
                double precioFinal;
                string porcentaje_temporal = txt_porc.Text.Trim();
                string costo_temporal = txt_costo.Text.Trim();


                if (costo_temporal.Contains("."))
                {
                    costo_temporal = costo_temporal.Replace(".",",");
                }
                double costo = double.Parse(costo_temporal);

                if (porcentaje_temporal.Contains("."))
                {
                    porcentaje_temporal = porcentaje_temporal.Replace(".", ",");
                }

                double porcentaje = double.Parse(porcentaje_temporal);


                auxPrecio = porcentaje * costo / 100;

                precioFinal = auxPrecio + costo;
                precioFinal = Math.Round(precioFinal);

                Console.WriteLine(precioFinal);

                txt_preciof.Text = precioFinal.ToString();

                cambiarComaPorPuntoEnLaInterfaz(txt_porc);
            }

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
        
        public bool validarCamposNumericos(TextBox txt)
        {
            if (!txt.Text.Trim().Equals(""))
            {
                try
                {
                    double aux;
                    aux = double.Parse(txt.Text.Trim());

                    txt.BackColor = colorOk;
                    return true;
                }
                catch (Exception)
                {
                    txt.BackColor = colorCancel;
                    return false;
                }
            }
            else
            {
                txt.BackColor = colorCancel;
                return false;
            }

        }
        public bool ColorCampos(TextBox txtAEvaluar)
        {
            bool salida = false;
            if (txtAEvaluar.Equals(txt_codigo))
            {
                if (txtAEvaluar.Text.Equals("") || txt_codigo.Text.Trim().Length == 0)
                {

                    txtAEvaluar.BackColor = colorCancel;
                    salida = false;
                }
                else
                {
                    txtAEvaluar.BackColor = colorOk;
                    salida = true;
                }
            }
            else if (txtAEvaluar.Equals(txt_costo))
            {
                try
                {
                    double aux = double.Parse(txtAEvaluar.Text.Trim());
                    txtAEvaluar.BackColor = colorOk;
                    salida = true;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = colorCancel;
                    salida = false;
                }
            }
            else if (txtAEvaluar.Equals(txt_porc))
            {
                try
                {
                    double aux = double.Parse(txtAEvaluar.Text.Trim());
                    txtAEvaluar.BackColor = colorOk;
                    salida = true;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = colorCancel;
                    salida = false;
                }
            }
            else if (txtAEvaluar.Equals(txt_preciof))
            {
                try
                {
                    double aux = double.Parse(txtAEvaluar.Text.Trim());
                    txtAEvaluar.BackColor = colorOk;
                    salida = true;
                }
                catch (Exception)
                {
                    txtAEvaluar.BackColor = colorCancel;
                    salida = false;
                }
            }
            else
            {
                if (txtAEvaluar.Text.Equals(""))
                {

                    txtAEvaluar.BackColor = colorCancel;
                    salida = false;
                }
                else
                {
                    txtAEvaluar.BackColor = colorOk;
                    salida = true;
                }
            }

            return salida;
        }
        public void cambiarComaPorPuntoEnLaInterfaz(TextBox txt)
        {
            if (txt.Text.Contains(","))
            {
                string texto_Temp = txt.Text.Trim();
                texto_Temp = texto_Temp.Replace(",",".");
                txt.Text = texto_Temp;
                if (txt.Text.Contains(","))
                {
                    Console.WriteLine("hay una coma " + texto_Temp);
                }
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                ColorCampos(txt_codigo);
                txt_nombre.Focus();
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                ColorCampos(txt_nombre);
                txt_marca.Focus();
            }
        }

        private void txt_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                ColorCampos(txt_marca);
                cmb_cat.Focus();
            }
        }

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txt_precioProveedor.Focus();
            }
        }

        private void cmb_cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txt_desc.Focus();
            }
        }

        private void txt_precioProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_precioProveedor);
                txt_descProv.Focus();
            }
        }

        private void txt_descProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_descProv);
                txt_costo.Focus();
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_costo);
                txt_porc.Focus();
            }
        }

        private void txt_porc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_porc);
                txt_preciof.Focus();
            }
        }

        private void txt_preciof_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_preciof);
                txt_StockMin.Focus();
            }
        }

        private void txt_StockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_StockMin);
                button1.Focus();
            }
        }
    }
}
