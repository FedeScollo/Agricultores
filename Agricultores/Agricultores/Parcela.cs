using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Parcela
    {
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;

        public Capataz capataz { get; set; }
        public int HCultivo { get; set; }
        public int HLibre { get; set; }
        public int NumParcela { get; set; }
        public Silo silo { get; set; }
        public int tamanio { get; set; }
        public Cultivo tipoCultivo { get; set; }

        public Parcela(Capataz unCapataz, int unHCultivo, int unHLibre, int unNumParcela, Silo unSilo, int unTamanio, Cultivo unTipoCultivo)
        {

        }

        public Parcela(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
        }

        public double precioCultivo(Parcela unParcela)
        {
            double preCul;
            preCul = unParcela.tipoCultivo.precioVenta * silo.CantKilos;
            return preCul;
        }

        public int costoTotalParcela()
        {
            int v;
            v = tipoCultivo.costoXHectarea * silo.CantKilos;
            return v;

        }
    }
}
