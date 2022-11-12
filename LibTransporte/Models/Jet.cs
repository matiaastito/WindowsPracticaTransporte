using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte.Models
{
    public class Jet : Transporte
    {
        public Jet(Piloto piloto, Copiloto copiloto, Azafata azafata, string modelo, int capacidad, decimal velocidad, decimal costo) : base(modelo, capacidad, velocidad, costo)
        {
            Piloto= piloto;
            Copiloto= copiloto;
            Azafata= azafata;
        }

        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
        public Azafata Azafata { get; set; }

        
        public string AgregarAzafata(Azafata azafata)
        {
            Azafata= azafata;
            return $"Nombre: {Azafata.Nombre}\nApellido: {Azafata.Apellido}";
        }
        public void QuitarAzafata() 
        {
            Azafata = null; 
        }
        public string Mantenimiento()
        {
            QuitarAzafata();
            return "Jet en mantemiento...";
        }

         public override string Aterrizar(string pista)
         {
             return base.Aterrizar();
         }

         public override string Despegar(string pista)
         {
             return base.Despegar();
         }

        
    }
}
