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

        }

        private void btnAgregarHelicoptero_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarListaAzafatas_Click(object sender, EventArgs e)
        {
            this.gridAzafatas.DataSource = null;
            this.gridAzafatas.Rows.Clear();       
            this.gridAzafatas.DataSource= azafataList;
        }
    }
}
