using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Extranjero: Comprador
    {
        public int porcAjuste { get; set; }
        public Extranjero(int unPorcAjuste, string unNombre): base(unPorcAjuste, unNombre)
        {
            porcAjuste = unPorcAjuste;
            nombre = unNombre;
        }
    }
}
