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

        public void cultivar(Parcela unaParcela, Cultivo unCultivo,int unasHectareas)
        {
            unaParcela.HCultivo = unaParcela.HCultivo + unasHectareas;
            unaParcela.HLibre = unaParcela.HLibre - unasHectareas;
            unaParcela.tipoCultivo = unCultivo;
        }

        public void cosechar(Silo unSilo,Parcela unaParcela, int unasHectareas)
        {
            int peso;
            unaParcela.HCultivo = unaParcela.HCultivo - unasHectareas;
            unaParcela.HLibre = unaParcela.HLibre + unasHectareas;
            peso = unaParcela.tipoCultivo.equivalenciaXH * unasHectareas;
            unSilo.CantKilos = unSilo.CantKilos + peso;
        }
        public void cambiarCultivo(Cultivo unCultivo,Parcela unaParcela,Silo unSilo)
        {
            if(unSilo.CantKilos == 0)
            {
                unaParcela.tipoCultivo = unCultivo;
            }
            else
            {
            }
        }
    }
}
