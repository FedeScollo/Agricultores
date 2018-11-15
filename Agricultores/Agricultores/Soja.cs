using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Soja : Cultivo
    {
        public Soja(int unCostoXHectarea, int unaEquivalenciaXH,double unPrecioVenta) : base(unCostoXHectarea,unaEquivalenciaXH,unPrecioVenta)
        {
        }
    }
}
