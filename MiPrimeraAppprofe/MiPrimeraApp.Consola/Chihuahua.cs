using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.Consola
{
    public class Chihuahua : Perro
    {
        public Chihuahua(int nivelDeEntrenamientoInicial) : base(nivelDeEntrenamientoInicial)
        {
            NivelDeAgresividad = 5;
        }

        public override void RecibeEntrenamiento()
        {
            // cada vez que el chihuhua se entrena, su nivel incrementa en 1
            NivelDeEntrenamiento += 1;
        }
    }
}
