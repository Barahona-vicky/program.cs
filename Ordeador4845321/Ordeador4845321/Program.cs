using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordeador4845321
{
    using System;

    class Ordenador
    {
        public string Marca { get; set; }
        public string Procesador { get; set; }
        public int Memoria { get; set; }
        public int DiscoDuro { get; set; }

        public Ordenador(string marca, string procesador, int memoria, int discoDuro)
        {
            Marca = marca;
            Procesador = procesador;
            Memoria = memoria;
            DiscoDuro = discoDuro;
        }

        public void MayorCapacidad()
        {
            DiscoDuro += 100;
        }

        public void MenorCapacidad()
        {
            if (DiscoDuro >= 100)
            {
                DiscoDuro -= 100;
            }
            else
            {
                Console.WriteLine("No se puede reducir más la capacidad del disco duro.");
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Procesador: {Procesador}");
            Console.WriteLine($"Memoria: {Memoria} GB");
            Console.WriteLine($"Disco Duro: {DiscoDuro} GB");
        }
    }

    class Program
    {
        static void Main()
        {
            Ordenador pc = new Ordenador("Dell", "Intel Core i5", 8, 500);

            Console.WriteLine("Información inicial:");
            pc.MostrarInfo();

            pc.MayorCapacidad();
            Console.WriteLine("\nDespués de aumentar la capacidad:");
            pc.MostrarInfo();

            pc.MenorCapacidad();
            Console.WriteLine("\nDespués de reducir la capacidad:");
            pc.MostrarInfo();
        }
    }
}
