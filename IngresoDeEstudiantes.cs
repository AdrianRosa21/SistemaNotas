using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaNotas.Form1;

namespace SistemaNotas
{
    public partial class IngresoDeEstudiantes : Form
    {
        public static class InfoEstudiantes
        {
            public static int[,,] Notas = new int[3, 6, 10];
            public static string[] Grados =
            {
            "Septimo Grado",
            "Octavo Grado",
            "Noveno Grado",
            "Primer año bachillerato",
            "Segundo año bachillerato",
            "Tercer año Bachillerato"
        };
            public static string[] Secciones =
            {
            "A", "B", "C"
        };
            public static string[,,] Estudiantes = new string[3, 6, 10];
            public static List<string> alumnos = new List<string>();

        }

        public IngresoDeEstudiantes()
        {
            InitializeComponent();
            lblDocente.Text = "Docente a cargo " + Session.Docente;
            cmbGrado.Items.AddRange(InfoEstudiantes.Grados);
            cmbSeccion.Items.AddRange(InfoEstudiantes.Secciones);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IngresoDeEstudiantes_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ingreso de Estudiantes a asignar nota";
            lblSeleccionGrado.Text = "Seleccione el grado correspondiente";
            lblNombre.Text = "Nombre de estudiante:";
            btnAgregarEstudiantes.Text = "Agregar alumno";
            lblLista.Text = "Nombre de estudiantes agregados";
            btnSalir.Text = "Salir";
            btnlimpiar.Text = "Limpiar campos";
            btnIrANotas.Text = "Ir a ingresar notas";
            cmbGrado.Text = "Seleccione el grado del estudiante";
            txtEstudiantes.Text = "Ingrese nombre del estudiante";
            cmbSeccion.Text = "Seleccione la sección";
            lblSeccion.Text = "Selecciona la sección del estudiante";
        }

        private void btnAgregarEstudiantes_Click(object sender, EventArgs e)
        {
            if (cmbGrado.SelectedItem == null || cmbSeccion.SelectedItem == null ||
             string.IsNullOrEmpty(txtEstudiantes.Text))
            {
                MessageBox.Show("Seleccione un grado, una seccion e ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int gradoIndex = cmbGrado.SelectedIndex;
            int seccionIndex = cmbSeccion.SelectedIndex;
            string alumno = txtEstudiantes.Text.Trim();
            List<string> alumnos = new List<string>();

            for (int i = 0; i < InfoEstudiantes.Estudiantes.GetLength(2); i++)
            {
                if (InfoEstudiantes.Estudiantes[gradoIndex, seccionIndex, i] == null)
                {
                    InfoEstudiantes.Estudiantes[gradoIndex, seccionIndex, i] = alumno;
                    alumnos.Add($"{InfoEstudiantes.Grados[gradoIndex]} - " +
                                $"{InfoEstudiantes.Secciones[seccionIndex]}: " +
                                $"{InfoEstudiantes.Estudiantes[gradoIndex, seccionIndex, i]}");
                    lbAlumnos.Items.Add($"{InfoEstudiantes.Grados[gradoIndex]} - " +
                                         $"{InfoEstudiantes.Secciones[seccionIndex]}: {alumno}");
                    MessageBox.Show($"Estudiantes agregados:\n{string.Join("\n", alumnos)}",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEstudiantes.Clear();
                    return;
                }
                MessageBox.Show("La sección ya está llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIrANotas_Click(object sender, EventArgs e)
        {
            AsignacionDeNotas form3 = new AsignacionDeNotas(InfoEstudiantes.alumnos);
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtEstudiantes.Clear();
            lbAlumnos.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
