using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaNotas.IngresoDeEstudiantes;

namespace SistemaNotas
{
    public partial class GestionDeInventario : Form
    {

        public static class Inventario
        {
            public static string[,,] inventario = new string[5, 5, 10];
            public static string[] Productos  = {//
                "Telefono",
                "Computadora",
                "Audifonos",
                "Celulares",
                "Usb",
                "Cables",
                ""
             };
            public static string[] Sucursales = {
                ""
             };
            public static string[] Secciones = {
                ""
             };


        }
        public GestionDeInventario()
        {
            InitializeComponent();
            cmbProductos.Items.AddRange(Inventario.Productos);
            cmbSucursales.Items.AddRange(Inventario.Sucursales);
            cmbSecciones.Items.AddRange(Inventario.Secciones);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionDeInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
