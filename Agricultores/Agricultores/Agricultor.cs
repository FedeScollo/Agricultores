using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Agricultor: Persona
    {
        public int cantParcelas { get; set; }
        public string nombre { get; set; }
        public Agricultor(int unCantParcelas, string unNombre): base (unNombre)
        {
            cantParcelas = unCantParcelas;
        }
    }
}
