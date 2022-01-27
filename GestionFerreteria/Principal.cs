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

namespace GestionFerreteria
{
    public partial class Presupuesto : Form
    {
        Producto prod = new Producto();
        public Presupuesto()
        {
            InitializeComponent();
           
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarNuevoProducto agregar = new agregarNuevoProducto();
            agregar.Show();
        }
    }
}
