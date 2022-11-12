using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte.Models.Base
{
    public abstract class Persona
    {
        public int TripulanteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(int tripulanteId, string nombre, string apellido)
        {
            TripulanteId = tripulanteId;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
