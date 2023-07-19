using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Aduana
    {
        // constructor
        public Aduana()
        {
            Personas = new List<Persona>(); 
        }
        // propiedad
        public List<Persona> Personas { get; set; }
    }
}
