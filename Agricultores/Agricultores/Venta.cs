using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Venta
    {
        public int cantKilo { get; set; }
        public int numParcela {get;set;}
        public Comprador comprador { get; set; }
        public DateTime fecha { get; set; }

        public Venta(int unaCantKilo,int unNumParcela,Comprador unComprador,DateTime unaFecha)
        {
            cantKilo = unaCantKilo;
            numParcela = unNumParcela;
            comprador = unComprador;
            fecha = unaFecha;
        }
    }
}
