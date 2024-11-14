using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Quisbert_CreadorPersonajeRol
{
    internal class Class2
    {
        // Propiedades de la clase
        internal string Nombre { get; set; }
        internal int Vida { get; set; }
        internal string Raza { get; set; }
        internal List<string> Skills { get; set; }

        // Constructor para inicializar las propiedades
        public Class2(string nombre, int vida, string raza, List<string> skills)
        {
            // Inicialización de las propiedades
            this.Nombre = nombre;
            this.Vida = vida;
            this.Raza = raza;
            this.Skills = skills;
        }
    }
}
