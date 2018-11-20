using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Trigo : Cultivo
    {
        public Trigo(int unCostoXHevtarea, int unaEquivalenciaXH,double unPrecioVenta) : base(unCostoXHevtarea,unaEquivalenciaXH,unPrecioVenta)
        {
        }
    }
}
