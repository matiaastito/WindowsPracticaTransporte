using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte.Models
{
    public class Compañia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CUIL { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }

        public Compañia(int id, string nombre, string cuil, string direccion, string telefono, string contacto)
        {
            Id = id;
            Nombre = nombre;
            CUIL = cuil;
            Direccion = direccion;
            Telefono = telefono;
            Contacto = contacto;
        }
    }
}
