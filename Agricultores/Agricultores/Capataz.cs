using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Capataz:Persona
    {
        public string nombre { get; set; }
        List<Venta> Ventas { get; set; }
        public Capataz(string unNombre,List<Venta> unasVentas): base(unNombre)
        {
            Ventas = unasVentas;
        }
    }
}
