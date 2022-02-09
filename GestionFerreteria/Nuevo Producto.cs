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

       
        private void boton_guardar_Click(object sender, EventArgs e)
        {
            bool validarCampos;
            validarCampos = ValidarCampos();
            if (validarCampos == true)
            {
                MessageBox.Show("bandera = " + validarCampos);

                GuardarProducto guardar = new GuardarProducto();

                string insert = "insert into Productos ([codigo],[nombre],[marca],[descripcion],[categoria],[preciolista],[descuentolista], [preciobruto],[porcentaje],[preciofinal]) values ('" + txt_codigo.Text.ToUpper() + "','" + txt_nombre.Text.ToUpper() + "','" + txt_marca.Text.ToUpper() + "','" + txt_desc.Text.ToUpper() + "','" + cmb_cat.SelectedIndex.ToString().ToUpper() + "','" + double.Parse(txt_precioProveedor.Text) + "','" + double.Parse(txt_descProv.Text) + "','" + double.Parse(txt_costo.Text) + "','" + double.Parse(txt_porc.Text) + "','" + double.Parse(txt_preciof.Text) + "')";

                string aux_id_stock = ultimo_id().ToString();

                bool res = guardar.guardarNuevoProducto(insert);

                
                string aux_stock = txt_stock.Text.Trim().ToUpper();
                string aux_stock_min = txt_StockMin.Text.Trim().ToUpper();

                if (res && (!aux_stock.Equals("") || !aux_stock_min.Equals("")))
                {
                    
                    bool resp = guardar.nuevoStock(aux_id_stock,aux_stock,aux_stock_min);
                    if (resp)
                    {
                        Console.WriteLine("stock ok");
                    }
                    else
                    {
                        Console.WriteLine("error al cargar stock");
                    }
                    limpiar();
                    
                }

            }
            else
            {
                MessageBox.Show("bandera = " + validarCampos);

            }
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
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
            ultimo_id();
            txt_codigo.Focus();
            label_fecha.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
        }
        public int ultimo_id()
        {
            int id_numerico = 0;
            conexion = conectar();
            SqlCommand comando = new SqlCommand("SELECT MAX(id) FROM Productos", conexion);
            conexion.Open();
            SqlDataReader data = comando.ExecuteReader();
            if (data.Read())
            {
                id_numerico = Convert.ToInt32(data[0]) + 1;
                label_nuevoId.Text = id_numerico.ToString();
            }

            return id_numerico;
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
        private void txt_stock_TextChanged(object sender, EventArgs e)
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

        

        private void cmb_cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                cmb_unidad.Focus();
            }
        }
        private void cmb_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txt_desc.Focus();
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
                txt_stock.Focus();
            }
        }
        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                validarCamposNumericos(txt_stock);
                cmb_proveedor.Focus();
            }
        }
        private void cmb_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                boton_guardar.Focus();
            }
        }

        private void txt_descProv_Leave(object sender, EventArgs e) //resta el porcentaje de descuento del precio de lista del proveedor
        {
            if (!txt_precioProveedor.Text.Trim().Equals("0") || !txt_descProv.Text.Trim().Equals("0"))
            {
                if (validarCamposNumericos(txt_descProv) && validarCamposNumericos(txt_precioProveedor))
                {


                    double costoParaRellenar, auxPrecio;
                    string descuento_temporal = txt_descProv.Text.Trim(), precioLista_temporal = txt_precioProveedor.Text.Trim();
                    double descuentoPrecioLista;
                    double precioDeLista;


                    
                    precioDeLista = double.Parse(cambiarPuntoPorComaBack(precioLista_temporal));

                    
                    descuentoPrecioLista = double.Parse(cambiarPuntoPorComaBack(descuento_temporal));
                   
                    auxPrecio = precioDeLista * descuentoPrecioLista / 100;

                    costoParaRellenar = precioDeLista - auxPrecio;

                    txt_costo.Text = costoParaRellenar.ToString();

                    cambiarComaPorPuntoEnLaInterfaz(txt_descProv);
                }

            }
            else
            {
                Console.WriteLine("esta en el else ");
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


                double costo = double.Parse(cambiarPuntoPorComaBack(costo_temporal));

                double porcentaje = double.Parse(cambiarPuntoPorComaBack(porcentaje_temporal));


                auxPrecio = porcentaje * costo / 100;

                precioFinal = auxPrecio + costo;
                precioFinal = Math.Round(precioFinal);


                txt_preciof.Text = precioFinal.ToString();

                cambiarComaPorPuntoEnLaInterfaz(txt_porc);
            }

        }
        public string cambiarPuntoPorComaBack(string contenido_txt)
        {
            if (contenido_txt.Contains("."))
            {
                contenido_txt = contenido_txt.Replace(".", ",");
            }

            return contenido_txt;
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

        public void limpiar()
        {
            
            txt_codigo.Clear();
            txt_codigo.BackColor = Color.White;
            txt_nombre.Clear();
            txt_nombre.BackColor = Color.White;
            txt_marca.Clear();
            txt_marca.BackColor = Color.White;
            cmb_cat.SelectedIndex = -1;
            txt_desc.Clear();
            txt_precioProveedor.Text = "0";
            txt_precioProveedor.BackColor = Color.White;
            txt_descProv.Text = "0";
            txt_descProv.BackColor = Color.White;
            txt_costo.Clear();
            txt_costo.BackColor = Color.White;
            txt_porc.Clear();
            txt_porc.BackColor = Color.White;
            txt_preciof.Clear();
            txt_preciof.BackColor = Color.White;    
            txt_StockMin.Clear();
            txt_StockMin.BackColor = Color.White;
            ultimo_id();
            txt_codigo.Focus();

        }

        
    }
}
