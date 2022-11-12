using LibTransporte.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte.Models
{
    public class Piloto : Persona
    {
        public Piloto(int tripulanteId, string nombre, string apellido) : base(tripulanteId, nombre, apellido)
        {
        }
    }
}
