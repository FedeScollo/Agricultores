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
        public Parcela parcela {get;set;}
        public Comprador comprador { get; set; }
        public DateTime fecha { get; set; }

        public Venta(int unaCantKilo,Parcela unaParcela,Comprador unComprador,DateTime unaFecha)
        {
            cantKilo = unaCantKilo;
            parcela = unaParcela;
            comprador = unComprador;
            fecha = unaFecha;
        }

        public double montoDeVentaParcela()
        {
            double monto;
            monto = cantKilo * parcela.tipoCultivo.precioVenta * comprador.porcAjuste;
            return monto;
        }
    }
}
