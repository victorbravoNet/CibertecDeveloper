namespace MiPrimeraApp.Consola
{
    public abstract class Perro
    {
        private int nivelDeEntrenamiento;
        protected int NivelDeEntrenamiento
        {
            get
            {
                return nivelDeEntrenamiento;
            }
            set
            {
                if (value < 1)
                    nivelDeEntrenamiento = 1;
                else
                {
                    if (value > 5)
                        nivelDeEntrenamiento = 5;
                    else
                        nivelDeEntrenamiento = value;
                }
            }
        }

        protected int NivelDeAgresividad { get; set; }

        // constructor con parametro
        protected Perro(int nivelDeEntrenamientoInicial)
        {
            NivelDeEntrenamiento = nivelDeEntrenamientoInicial;
            NivelDeAgresividad = 3;
        }

        public string Ladrar()
        {
            if (NivelDeAgresividad - nivelDeEntrenamiento > 3)
                return "Guau";
            return "...";
        }

        public abstract void RecibeEntrenamiento();

        public override string ToString()
        {
            return $"Nivel de entranamiento: {nivelDeEntrenamiento} - Nivel de agresividad {NivelDeAgresividad}";
        }
    }
}
