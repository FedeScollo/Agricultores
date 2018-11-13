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

        public Parcela(Capataz unCapataz, int unHCultivo, int unHLibre, int unNumParcela, Silo unSilo, int unTamanio, Cultivo unTipoCultivo)
        {

        }
<<<<<<< HEAD
        public double precioCultivo(Parcela unParcela)
        {
            double preCul;
            preCul = unParcela.tipoCultivo.precioVenta * silo.CantKilos;
            return preCul;
=======

        public int costoTotalParcela()
        {
            int v;
            v = tipoCultivo.costoXHectarea * silo.CantKilos;
            return v;
>>>>>>> bf5ddcec0e5942e65ad8d034bfa5d2494457f604
        }
    }
}
