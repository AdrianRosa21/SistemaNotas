namespace SistemaNotas
{
    partial class IngresoDeEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbGrado = new ComboBox();
            cmbSeccion = new ComboBox();
            lblSeleccionGrado = new Label();
            lblSeccion = new Label();
            lblDocente = new Label();
            lblTitulo = new Label();
            lblNombre = new Label();
            txtEstudiantes = new TextBox();
            btnAgregarEstudiantes = new Button();
            lblLista = new Label();
            lbAlumnos = new ListBox();
            btnSalir = new Button();
            btnlimpiar = new Button();
            btnIrANotas = new Button();
            SuspendLayout();
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(372, 73);
            cmbGrado.Margin = new Padding(4, 5, 4, 5);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(266, 29);
            cmbGrado.TabIndex = 1;
            // 
            // cmbSeccion
            // 
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Location = new Point(372, 147);
            cmbSeccion.Margin = new Padding(4, 5, 4, 5);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(266, 29);
            cmbSeccion.TabIndex = 2;
            // 
            // lblSeleccionGrado
            // 
            lblSeleccionGrado.AutoSize = true;
            lblSeleccionGrado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionGrado.Location = new Point(60, 76);
            lblSeleccionGrado.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionGrado.Name = "lblSeleccionGrado";
            lblSeleccionGrado.Size = new Size(135, 21);
            lblSeleccionGrado.TabIndex = 4;
            lblSeleccionGrado.Text = "lblSeleccionGrado";
            lblSeleccionGrado.Click += label3_Click;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeccion.Location = new Point(60, 150);
            lblSeccion.Margin = new Padding(4, 0, 4, 0);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(80, 21);
            lblSeccion.TabIndex = 5;
            lblSeccion.Text = "lblSeccion";
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocente.Location = new Point(62, 26);
            lblDocente.Margin = new Padding(4, 0, 4, 0);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(84, 21);
            lblDocente.TabIndex = 6;
            lblDocente.Text = "lblDocente";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(374, 26);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(66, 21);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "lblTitulo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(60, 234);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 21);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "lblNombre";
            // 
            // txtEstudiantes
            // 
            txtEstudiantes.Location = new Point(256, 231);
            txtEstudiantes.Margin = new Padding(4, 5, 4, 5);
            txtEstudiantes.Name = "txtEstudiantes";
            txtEstudiantes.Size = new Size(502, 29);
            txtEstudiantes.TabIndex = 9;
            txtEstudiantes.TextChanged += txtEstudiantes_TextChanged;
            // 
            // btnAgregarEstudiantes
            // 
            btnAgregarEstudiantes.Location = new Point(256, 285);
            btnAgregarEstudiantes.Margin = new Padding(4, 5, 4, 5);
            btnAgregarEstudiantes.Name = "btnAgregarEstudiantes";
            btnAgregarEstudiantes.Size = new Size(117, 38);
            btnAgregarEstudiantes.TabIndex = 10;
            btnAgregarEstudiantes.Text = "btnAgregarEstudiantes";
            btnAgregarEstudiantes.UseVisualStyleBackColor = true;
            btnAgregarEstudiantes.Click += btnAgregarEstudiantes_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(372, 338);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(59, 21);
            lblLista.TabIndex = 11;
            lblLista.Text = "lblLista";
            // 
            // lbAlumnos
            // 
            lbAlumnos.FormattingEnabled = true;
            lbAlumnos.Location = new Point(256, 392);
            lbAlumnos.Name = "lbAlumnos";
            lbAlumnos.Size = new Size(502, 193);
            lbAlumnos.TabIndex = 12;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(28, 601);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "btnSalir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(444, 601);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(114, 34);
            btnlimpiar.TabIndex = 14;
            btnlimpiar.Text = "btnlimpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnIrANotas
            // 
            btnIrANotas.Location = new Point(880, 601);
            btnIrANotas.Name = "btnIrANotas";
            btnIrANotas.Size = new Size(123, 34);
            btnIrANotas.TabIndex = 15;
            btnIrANotas.Text = "btnIrANotas";
            btnIrANotas.UseVisualStyleBackColor = true;
            btnIrANotas.Click += btnIrANotas_Click;
            // 
            // IngresoDeEstudiantes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 647);
            Controls.Add(btnIrANotas);
            Controls.Add(btnlimpiar);
            Controls.Add(btnSalir);
            Controls.Add(lbAlumnos);
            Controls.Add(lblLista);
            Controls.Add(btnAgregarEstudiantes);
            Controls.Add(txtEstudiantes);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(lblDocente);
            Controls.Add(lblSeccion);
            Controls.Add(lblSeleccionGrado);
            Controls.Add(cmbSeccion);
            Controls.Add(cmbGrado);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "IngresoDeEstudiantes";
            Text = "IngresoDeEstudiantes";
            Load += IngresoDeEstudiantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGrado;
        private ComboBox cmbSeccion;
        private Label lblSeleccionGrado;
        private Label lblSeccion;
        private Label lblDocente;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtEstudiantes;
        private Button btnAgregarEstudiantes;
        private Label lblLista;
        private ListBox lbAlumnos;
        private Button btnSalir;
        private Button btnlimpiar;
        private Button btnIrANotas;
    }
}