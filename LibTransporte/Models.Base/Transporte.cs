using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte
{
    public abstract class Transporte
    {
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public decimal Velocidad { get; set; }
        public decimal Costo { get; set; }

        public Transporte(string modelo, int capacidad, decimal velocidad, decimal costo)
        {
            Modelo = modelo;
            Capacidad = capacidad;
            Velocidad = velocidad;
            Costo = costo;
        }

        public virtual string InformarMensaje()
        {

            return $"Capacidad: {Capacidad} \nVelocidad: {Velocidad} \nCosto: {Costo}";
        }

        public virtual string Despegar()
        {
            return "Despegando...";
        }

        public virtual string Aterrizar()
        {
            return "Aterrizando...";
        }

        public virtual string Aterrizar(string pista)
        {
            return $"Aterrizando en la pista {pista}";
        }

        public virtual string Despegar(string pista)
        {
            return $"Despegando en la pista {pista}";
        }
    }
}
