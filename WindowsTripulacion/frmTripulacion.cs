using LibTransporte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace WindowsTripulacion
{
    public partial class frmTripulacion : Form
    {
        List <Azafata> azafataList = new List<Azafata>();
        List <Jet> jetsList = new List<Jet>();
        List <Helicoptero> helicopterosList = new List<Helicoptero>();

        
        public frmTripulacion()
        {
            InitializeComponent();
        }

        private void btnAgregarAzafata_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Interaction.InputBox("Ingrese Id"));
            string nombre = Interaction.InputBox("Ingrese el Nombre");
            string apellido = Interaction.InputBox("Ingrese el Apellido");
             
            azafataList.Add(new Azafata(id, nombre, apellido));
        }

        private void btnQuitarAzafata_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Interaction.InputBox("Ingrese Id a eliminar"));

            azafataList.RemoveAll(azafata => azafata.TripulanteId == id);

            MessageBox.Show("Azafata eliminada con exito!");

        }

        private void btnCrearJet_Click(object sender, EventArgs e)
        {
            int idPiloto = Convert.ToInt32(Interaction.InputBox("Ingrese ID del Piloto"));
            string nombrePiloto = Interaction.InputBox("Ingrese Nombre del Piloto");
            string apellidoPiloto = Interaction.InputBox("Ingrese Apellido del Piloto");
            int idCopiloto = Convert.ToInt32(Interaction.InputBox("Ingrese ID del Copiloto"));
            string nombreCopiloto = Interaction.InputBox("Ingrese Nombre del Copiloto");
            string apellidoCopiloto = Interaction.InputBox("Ingrese Apellido del Copiloto");
            string modelo = Interaction.InputBox("Ingrese Modelo del Jet");
            int capacidad = Convert.ToInt32(Interaction.InputBox("Ingrese Capacidad del Jet"));
            decimal velocidad = Convert.ToDecimal(Interaction.InputBox("Ingrese la Velocidad del Jet"));
            decimal costo = Convert.ToDecimal(Interaction.InputBox("Ingrese el costo del Jet"));
            int idAzafata = Convert.ToInt32(Interaction.InputBox("Ingrese Id de la azafata"));
            
            foreach (Azafata azafata in azafataList)
            {
                if (azafata.TripulanteId == idAzafata && azafata.IsAbordo != true)
                {
                    azafata.IsAbordo = true;
                    jetsList.Add(new Jet(new Piloto(idPiloto, nombrePiloto, apellidoPiloto), new Copiloto(idCopiloto, nombreCopiloto, apellidoCopiloto), azafata, modelo, capacidad, velocidad, costo));
                    break;
                }
            }
            MessageBox.Show("Jet creado con exito!");
        }

        private void btnAgregarHelicoptero_Click(object sender, EventArgs e)
        {
            int cantidadAspas = Convert.ToInt32(Interaction.InputBox("Ingrese cantidad de aspas del Helicoptero"));
            string modelo = Interaction.InputBox("Ingrese Modelo del Helicoptero");
            int capacidad = Convert.ToInt32(Interaction.InputBox("Ingrese Capacidad del Helicoptero"));
            decimal velocidad = Convert.ToDecimal(Interaction.InputBox("Ingrese la Velocidad del Helicoptero"));
            decimal costo = Convert.ToDecimal(Interaction.InputBox("Ingrese el costo del Helicoptero"));
            helicopterosList.Add(new Helicoptero(cantidadAspas, modelo, capacidad, velocidad, costo));
            MessageBox.Show("Helicoptero creado con exito!");

        }

        private void btnMostrarListaAzafatas_Click(object sender, EventArgs e)
        {
            this.gridAzafatas.DataSource = null;
            this.gridAzafatas.Rows.Clear();       
            this.gridAzafatas.DataSource= helicopterosList;
        }
    }
}
