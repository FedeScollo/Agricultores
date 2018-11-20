using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Capataz:Persona
    {
        List<Venta> Ventas { get; set; }
        public Capataz(string unNombre): base(unNombre)
        {
            Ventas = new List<Venta>();
        }

        public void vender(Cultivo unCultivo, Comprador unComprador, Venta unaVenta)
        {
            double PV = 0;
            
            PV = unaVenta.cantKilo * unCultivo.precioVenta * unComprador.porcAjuste % 100;

            Console.WriteLine("{0}", PV);
        }

        public void realizarVenta(Venta venta)
        {
            Ventas.Add(venta);
        }
    }
}
