using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Nacional: Comprador
    {
        public int porcAjuste { get; set; }

        public Nacional(int unPorcAjuste, string unNombre): base(unPorcAjuste, unNombre)
        {
            porcAjuste = unPorcAjuste;
            nombre = unNombre;
        }
    }
}
