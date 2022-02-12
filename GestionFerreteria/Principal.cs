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
    public partial class Presupuesto : Form
    {
        Producto prod = new Producto();
        buscar buscar = new buscar();
        static string cnString = "server = localhost ; database = ferreteria ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(cnString);
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public Presupuesto()
        {

            InitializeComponent();
            dgv.AllowUserToAddRows = false;

        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarNuevoProducto agregar = new agregarNuevoProducto();
            agregar.Show();
        }

        private void txt_codBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                e.Handled = true;

                LimpiarDGV();

                dt = buscar.buscarCodigoBarra(txt_codBarra.Text.Trim());

                
                llenarDgv(dt);
                
                
            }
            else
            {
                Console.WriteLine("  error en la clase ppal");
            }
                
            
        }
        public void llenarDgv(DataTable data)
        {

            dgv.DataSource = data;
            dgv.Columns[0].HeaderText = "Codigo";
            dgv.Columns[0].Width = 60;
            dgv.Columns[1].HeaderText = "Precio";
            dgv.Columns[1].Width = 40;
            
            dgv.Columns[2].Width = 90;
            dgv.Columns[3].Width = 60;
            dgv.Columns[4].HeaderText = "Cat.";
            dgv.Columns[4].Width = 50;
            dgv.Columns[5].Width = 40;
            dgv.Columns[6].Width = 30;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].HeaderText = "Obs";

            
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[1].Style.BackColor = Color.LightBlue;
                //dgv.Rows[i].Cells[1];
            }

            txt_codBarra.Focus();
            txt_codBarra.Clear();

        }
        public void LimpiarDGV()
        {
            dt.Clear();
            dt2.Clear();
        }

        private void boton_buscarGeneral_Click(object sender, EventArgs e)
        {
            if (!txt_buscar.Text.Equals(""))
            {
                //DataTable datatable = new DataTable();
                buscar buscar = new buscar();
                //LimpiarDGV();
                dt2 = buscar.buscarGeneral(txt_buscar.Text.Trim());

                if (dt2!=null)
                {
                    Console.WriteLine("ANTES DE LLENAR DGV");
                    llenarDgv(dt2);
                    
                }
            }
        }
    }
}
