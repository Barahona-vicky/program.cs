using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovil4845321
{
    class Freno
    {
        public void Frenar(Coche coche)
        {
            coche.VelocidadActual = 0;
            Console.WriteLine("El coche ha frenado por completo. Velocidad actual: 0 km/h");
        }
    }

    class Programa
    {
        static void Main()
        {
            Coche miCoche = new Coche("Toyota", "Supra", 250);
            Freno freno = new Freno(); // Creamos una instancia de Freno

            miCoche.Acelerar();
            miCoche.Acelerar();
            miCoche.Decelerar();
            freno.Frenar(miCoche); // Usamos la nueva clase para frenar el coche
            Console.ReadKey();
        }
    }
}
