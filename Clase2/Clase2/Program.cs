using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var listaPersonas = new List<Persona>();
            for (int i = 0; i < 100; i++)
            {
                listaPersonas.Add(new Persona()
                {
                    Id = i,
                    Nombre = "Nombre " + i,
                    Edad = random.Next(10, 80)
                });
            }

            foreach (var item in listaPersonas)
            {
                Console.WriteLine(item.Nombre + "  Edad: " + item.Edad);
            }

            Console.WriteLine("Ahora ordenados por Edad");
            var ordenadosPorEdad = from personitas in listaPersonas
                                   where personitas.Edad < 50
                                   orderby personitas.Edad ascending
                                   select personitas;

            foreach (var persona in ordenadosPorEdad)
            {
                Console.WriteLine(persona.Nombre + " -- Edad:" + persona.Edad);
            }
            Console.ReadKey();
        }
    }
}
