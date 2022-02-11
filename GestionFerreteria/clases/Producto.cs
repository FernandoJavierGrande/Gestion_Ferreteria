using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFerreteria.clases
{
    internal class Producto
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public string codigo_barras { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        public double porcentaje { get; set; }
        public double costo { get; set; }
        public double precio_lista { get; set; }
        public double descuento_lista { get; set; }
        public string medida { get; set; }
        public string proveedor { get; set; }


    }
    
}
