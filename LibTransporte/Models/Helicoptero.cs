using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte.Models
{
    public class Helicoptero : Transporte
    {
        public Helicoptero(int cantidadAspas, string modelo, int capacidad, decimal velocidad, decimal costo) : base(modelo, capacidad, velocidad, costo)
        {
            CantidadAspas= cantidadAspas;
        }

        public int CantidadAspas { get; set; }

        public override string Despegar()
        {
            if (Velocidad > 160)
            {
                return "Llego a la velocidad crucero";
            }
            return base.Despegar();
        }
    }
}
