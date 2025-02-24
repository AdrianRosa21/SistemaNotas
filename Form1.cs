namespace SistemaNotas
{
    public partial class Form1 : Form
    {
        public static class Session
        {
            public static string Docente;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbtitulo.Text = "Sistema de ingreso de notas";
            lblUsuario.Text = "Usuario: ";
            lbllContra.Text = "Contraseña";
            btningresar.Text = "Iniciar sesión";
            btnSalir.Text = "Salir";
            checkcontra.Text = "Ver contraseña";
            txtContra.PasswordChar = '*';

            logo.Image = Image.FromFile("C:\\Users\\dell.ARRUPE\\Source\\Repos\\SistemaNotas\\img\\arrupe.png");
        }

        private void checkcontra_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkcontra.Checked == true)
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContra.Text;

            if (usuario == "Abilaine" && contraseña == "1234")
            {
                Session.Docente = "Prof. " + usuario;
                IngresoDeEstudiantes form2 = new IngresoDeEstudiantes();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
