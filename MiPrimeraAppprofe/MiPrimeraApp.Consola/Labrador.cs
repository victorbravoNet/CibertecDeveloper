using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.Consola
{
    public class Labrador : Perro
    {
        public Labrador(int nivelDeEntrenamientoInicial) : base(nivelDeEntrenamientoInicial)
        {
        }

        public override void RecibeEntrenamiento()
        {
            NivelDeEntrenamiento += 2;
        }
    }
}
