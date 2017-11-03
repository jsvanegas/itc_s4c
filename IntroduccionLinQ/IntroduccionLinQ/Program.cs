using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var persona = new { Id = 1, Nombre = "Camila" };

            var personas = new[] {
                new { Id=1, Nombre="Camila", Pais="Colombia" },
                new { Id=2, Nombre="Andres", Pais="Venezuela" },
                new { Id=3, Nombre="Carlos", Pais="Peru" },
                new { Id=4, Nombre="Diana", Pais="Ecuador" },
                new { Id=5, Nombre="Rodrigo", Pais="Argentina" },
                new { Id=6, Nombre="cesar", Pais="Uruguay" }
            };

            //var nombresPorC = from p in personas
            //                  where p.Nombre.ToUpper().StartsWith("C")
            //                  orderby p.Pais descending
            //                  select p;


            var nombresPorC = from p in personas
                              where p.Nombre.ToUpper().StartsWith("C")
                              orderby p.Pais descending
                              select new
                              {
                                  Id = (1000 + p.Id),
                                  Name = p.Nombre.First().ToString().ToUpper() + p.Nombre.Substring(1),
                                  Country = p.Pais.Substring(0, 3).ToUpper()
                              };

            foreach (var persona in nombresPorC)
            {
                Console.WriteLine("{0}: Nombre - {1}; Pais - {2}", persona.Id, persona.Name, persona.Country);
            }
            Console.ReadKey();
        }
    }
}