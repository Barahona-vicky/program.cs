using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona4845321
{
    public class PersonaNadadora : Persona
    {
        public PersonaNadadora(string ojos, string altura, string peso,
            string sexo) : base(ojos, altura, peso, sexo)
        {
        }
        public void Nadar()
        {
            // La practica de la natacion hara volver al peso inicial
            Console.WriteLine("Nadando para volver al peso ideal");
            this.Peso = "85";

        }


    }
}
