using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Cultivo
    {
        public int costoXHectarea { get; set; }
        public int equivalenciaXH { get; set; }
        public double precioVenta { get; set; }


        public Cultivo(int unCostoXHectarea, int unaEquivalenciaXH,double unPrecioVenta)
        {
            costoXHectarea = unCostoXHectarea;
            equivalenciaXH = unaEquivalenciaXH;
            precioVenta = unPrecioVenta;
        }
    }
}
