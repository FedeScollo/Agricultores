using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultores
{
    public class Agricultor : Persona
    {
        public List<Parcela> parcelas { get; set; }
        public List<Cultivo> cultivos { get; set; }
        public string nombre { get; set; }

        public Agricultor(List<Parcela> unasParcelas, List<Cultivo> unosCultivos, string unNombre)
            : base(unNombre)
        {
            parcelas = unasParcelas;
            cultivos = unosCultivos;
        }

        public void cultivar(Parcela unaParcela, Cultivo unCultivo, int unasHectareas)
        {
            unaParcela.HCultivo = unaParcela.HCultivo + unasHectareas;
            unaParcela.HLibre = unaParcela.HLibre - unasHectareas;
            unaParcela.tipoCultivo = unCultivo;
        }

        public void cosechar(Silo unSilo, Parcela unaParcela, int unasHectareas)
        {
            int peso;
            unaParcela.HCultivo = unaParcela.HCultivo - unasHectareas;
            unaParcela.HLibre = unaParcela.HLibre + unasHectareas;
            peso = unaParcela.tipoCultivo.equivalenciaXH * unasHectareas;
            unSilo.CantKilos = unSilo.CantKilos + peso;
        }
        public void cambiarCultivo(Cultivo unCultivo, Parcela unaParcela, Silo unSilo)
        {
            if (unSilo.CantKilos == 0)
            {
                unaParcela.tipoCultivo = unCultivo;
            }
            else
            {
            }
        }

        public void informarCultivo(Parcela unaParcela)
        {
            if ((unaParcela.silo.CantKilos > 0) || (cultivos.First() != unaParcela.tipoCultivo) || (unaParcela.tipoCultivo == unaParcela.tipoCultivo))
            {
                cultivos.Add(unaParcela.tipoCultivo);
            }
            else
            {
            }
        }

        public void parcelaSubUtilizada(Parcela unaParcela, Cultivo unCultivo)
        {
            if ((unCultivo.equivalenciaXH) <= (unaParcela.tamanio / 2))
            {
                Console.WriteLine("Tiene la parcela subutilizada.");
            }
        }
    }
}
