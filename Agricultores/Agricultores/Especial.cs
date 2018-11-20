using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Especial: Comprador
    {
        public Especial(int unPorcAjuste, string unNombre): base(unPorcAjuste, unNombre)
        {
        }
    }
}
