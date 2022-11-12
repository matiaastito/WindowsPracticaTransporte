using LibTransporte.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte.Models
{
    public class Azafata : Persona
    {
        public Azafata(int tripulanteId, string nombre, string apellido) : base(tripulanteId, nombre, apellido)
        {
            IsAbordo = false;
        }
        public bool IsAbordo { get; set; }
    }
}
