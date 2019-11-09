using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.Consola
{
    class Program
    {
        class PruebaDispose : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("se destruyó el objeto");
            }
        }

        static void Main(string[] args)
        {
            //using (var prueba = new PruebaDispose())
            //{
            //    Console.WriteLine("Se creo un nuevo objeto disposable");
            //}

            Console.WriteLine("Creando un chihuahua");
            var perro1 = new Chihuahua(1);
            Console.WriteLine(perro1.ToString());
            Console.WriteLine($"Perro 1 ladra: {perro1.Ladrar()}");
            Console.WriteLine("Entrenando al perro 1...");
            System.Threading.Thread.Sleep(1000);
            perro1.RecibeEntrenamiento();
            Console.WriteLine($"Perro 1 ladra: {perro1.Ladrar()}");

            System.Threading.Thread.Sleep(1000);

            // utilizar un método estático
            Console.WriteLine(EjerciciosBaseDatos.InsertarArtista("nuevo artista"));

            // obtener la lista de artistas
            EjerciciosBaseDatos.ListarTablaArtista();

            //Console.ReadLine();
        }
    }
}
