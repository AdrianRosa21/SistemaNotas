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
    public partial class AsignacionDeNotas : Form
    {
        private List<string> alumnos;

        public AsignacionDeNotas(List<string> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;

            cmbGrado.Items.AddRange(InfoEstudiantes.Grados);
            cmbSeccion.Items.AddRange(InfoEstudiantes.Secciones);
        }

        private void AsignacionDeNotas_Load(object sender, EventArgs e)
        {
            lblGrado.Text = $"Ingrese grado";
            lblAlumno.Text = "Seleccionar alumno:";
            lblNota.Text = "Ingrese la nota correspondiente:";
            btnAsignarNota.Text = "Asignar Nota";
            label1.Text = "Nota ingresada al alumno correspondiente:";
            btnEstudiantes.Text = "Ir a ingresar estudiantes";
            btnSalir.Text = "Salir";
            cmbGrado.Text = "Seleccione el grado del estudiante";
            cmbAlumno.Text = "Seleccione el nombre del estudiante";
            cmbSeccion.Text = "Seleccione la sección del estudiante";
            lblSeccion.Text = "Sección del estudiante";
            lblInfo.Text = "Información de los estudiantes agregados";

            // Agregar un control inicial en los ComboBoxes
            cmbGrado.SelectedIndex = 0;  // Selecciona el primer grado
            cmbSeccion.SelectedIndex = 0; // Selecciona la primera sección

            // Llamar al evento de grado para cargar los alumnos desde el inicio
            cmbGrado_SelectedIndexChanged(this, EventArgs.Empty);

            MostrarMatrizEstudiantes();
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlumno.Items.Clear();
            if (cmbAlumno.SelectedIndex == -1 || cmbSeccion.SelectedIndex == -1)
            {
                return;
            }

            string gradoSeleccionado = cmbGrado.SelectedItem.ToString();
            string seccionSeleccionada = cmbSeccion.SelectedItem.ToString();
            int gradoIndex = Array.IndexOf(InfoEstudiantes.Grados, gradoSeleccionado);
            int seccionIndex = Array.IndexOf(InfoEstudiantes.Secciones, seccionSeleccionada);

            List<string> alumnosFiltrados = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                string alumno = InfoEstudiantes.Estudiantes[gradoIndex, seccionIndex, i];
                if (!string.IsNullOrEmpty(alumno))
                {
                    alumnosFiltrados.Add(alumno);
                }
            }
            //Agregar los alumnos al combobox
            cmbAlumno.Items.AddRange(alumnosFiltrados.ToArray());

        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando se cambia la seccion, recargar los alumnos correspondientes
            cmbGrado_SelectedIndexChanged(sender, e);
        }

        private void btnAsignarNota_Click(object sender, EventArgs e)
        {
            if (cmbGrado.SelectedIndex == -1 || cmbSeccion.SelectedIndex == -1
                || cmbAlumno.SelectedIndex == -1 || string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Seleccione un grado, una seccion, un estudiante e ingrese una nota.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int gradoIndex = cmbGrado.SelectedIndex;
            int seccionIndex = cmbSeccion.SelectedIndex;
            int alumnoIndex = cmbAlumno.SelectedIndex;
            int nota;

            if (!int.TryParse(txtNota.Text, out nota) || nota < 0 || nota > 100)
            {
                MessageBox.Show("Ingrese una nota valida (0-100).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InfoEstudiantes.Notas[gradoIndex, seccionIndex, alumnoIndex] = nota;
            listBox1.Items.Add($"Nota {nota} asignada a {cmbAlumno.SelectedItem}");
            txtNota.Clear();
        }

        private void MostrarMatrizEstudiantes()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Grado", "Grado");
            dataGridView1.Columns.Add("Seccion", "Seccion");
            dataGridView1.Columns.Add("Alumno", "Alumno");

            for (int grado = 0; grado < InfoEstudiantes.Grados.Length; grado++)
            {
                for (int seccion = 0; seccion < InfoEstudiantes.Secciones.Length; seccion++)
                {
                    //10 alumnos maximo (Estiupulados en la matriz)
                    for (int alumno = 0; alumno < 10; alumno++)
                    {
                        string alumnoNombre = InfoEstudiantes.Estudiantes[grado, seccion, alumno];
                        if (!string.IsNullOrEmpty(alumnoNombre))
                        {
                            dataGridView1.Rows.Add(InfoEstudiantes.Grados[grado], InfoEstudiantes.Secciones[seccion], alumnoNombre);

                        }
                    }
                }
            }
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            IngresoDeEstudiantes form2 = new IngresoDeEstudiantes();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
