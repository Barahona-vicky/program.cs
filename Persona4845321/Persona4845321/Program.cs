using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona4845321
{
    public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }
        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;

        public void Hablar(string texto)
        {
            // Se muestra la conversacion a decir
            Console.WriteLine("Voy a decir" + texto);
        }

        public void Comer(double calorias)
        {
            // Se indica las calorias que se ganan al comer
            Console.WriteLine("Ganando" + calorias + "Calorias");
            this.Peso += calorias / 1000;
        }

        public void correr(double calorias)
        {
            // Se indican las calorias que se pierden al correr
            Console.WriteLine("Perdiendo" + calorias + "calorias");
            this.Peso = Convert.ToString(calorias / 1000);
        }
        static void Main(string[] args)
        {
            Persona Personal = new Persona("Verdes", "187", "V");
            Console.WriteLine("Descripcion de la persona: ");
            Console.WriteLine("Ojos: " + Personal.Ojos);
            Console.WriteLine("Altura: " + Personal.Altura);
            Console.WriteLine("Peso: " + Personal.Peso);
            Console.WriteLine("Sexo: " + Personal.Sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: " + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es: " + Personal.Peso);
        }
    }
}
