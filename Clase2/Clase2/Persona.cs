using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class Persona
    {
        /// <summary>
        /// Referencia al identificador de la clase
        /// </summary>
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Pais { get; set; }
        public char Genero { get; set; }

        /// <summary>
        /// Incrementa el valor de la edad en 1
        /// </summary>
        public void aumentarEdad() {
            this.Edad++;
        }

        /// <summary>
        /// Reemplaza el valor de la propiedad pais
        /// </summary>
        /// <param name="pais">Referencia al nuevo pais</param>
        public void cambiarNacionalidad(string pais) {
            this.Pais = pais;
        }


    }
}
