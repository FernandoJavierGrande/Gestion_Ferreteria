using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GestionFerreteria.clases
{
    internal class configuraciones
    {
        public ComboBox leerUnidades()
        {
            ComboBox cmb = new ComboBox();
            if (System.IO.File.Exists("unidad.xml"))
            {
                DataTable DT = new DataTable(); 
                DT.ReadXml("unidad.xml");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    cmb.Items.Add(DT.Rows[i]["value"]);
                }

            }
            else
            {
                Console.WriteLine("no entro al if");
            }


            return cmb; 
        }
        public void agregarUnidad(string unidad)
        {
            
        }
    }
}
