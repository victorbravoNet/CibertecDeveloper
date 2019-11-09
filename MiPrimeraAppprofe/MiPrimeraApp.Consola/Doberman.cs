using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.Consola
{
    public class Doberman : Perro
    {
        public Doberman(int nivelDeEntrenamientoInicial) : base(nivelDeEntrenamientoInicial)
        {
            // para este caso, siempre inicializar con agresividad 4
            NivelDeAgresividad = 4;
        }

        public override void RecibeEntrenamiento()
        {
            NivelDeEntrenamiento += 1;
        }
    }
}
