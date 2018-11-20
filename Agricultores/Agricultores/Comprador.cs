using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Comprador: Persona
    {
        public int porcAjuste { get; set; }
        public Comprador(int unPorcAjuste, string unNombre): base (unNombre)
        {
            porcAjuste = unPorcAjuste;
        }
    }
}
