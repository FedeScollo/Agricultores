using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Trigo : Cultivo
    {
        public int costoXHectarea { get; set; }
        public int equivalenciaXH { get; set; }
        public double precioVenta { get; set; }


        public Trigo(int unCostoXHevtarea, int unaEquivalenciaXH,double unPrecioVenta) : base(unCostoXHevtarea,70,unPrecioVenta)
        {

        }
    }
}
