using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Parcela
    {
        public Capataz capataz { get; set; }
        public int HCultivo { get; set; }
        public int HLibre { get; set; }
        public int NumParcela { get; set; }
        public Silo silo { get; set; }
        public int tamanio { get; set; }
        public Cultivo tipoCultivo { get; set; }

        public Parcela()
        {

        }
    }
}
