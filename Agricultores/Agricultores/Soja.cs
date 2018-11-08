using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Soja : Cultivo
    {
        public int costoXHectarea { get; set; }
        public int equivalenciaXH { get; set; }
        public double precioVenta { get; set; }


        public Soja(int unCostoXHevtarea, int unaEquivalenciaXH,double unPrecioVenta) : base(10,80,unPrecioVenta)
        {

        }
    }
}
