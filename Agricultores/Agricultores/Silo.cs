using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Silo
    {
        public int CantKilos { get; set; }
        public Silo(int CantKilos)
        {

        }

        public int costoTotalParcela(Parcela unaParcela)
        {
            int v;
            v = unaParcela.tipoCultivo.costoXHectarea * unaParcela.silo.CantKilos;
            return v;
        }


    }
}
